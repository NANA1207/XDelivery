using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public static class DatosUsuario
    {
        //Los usuarios se guardaran con el USU_TIPO='R', 'A', 'C'
        public static UsuarioEntidad GuardarUsuario(UsuarioEntidad usuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [dbo].[usuarios]
                                                       ([USU_USERNAME]
                                                       ,[USU_CONTRASEÑA]
                                                       ,[USU_NOMBRE]
                                                       ,[USU_APELLIDO]
                                                       ,[USU_TIPO]
                                                       ,[USU_ESTADO])
                                            VALUES
                                                  (@username,@contrasena, @nombre,
                                                   @apellido,@tipo,@estado);
                                    SELECT SCOPE_IDENTITY();
                                            ";
                cmd.Parameters.AddWithValue("@username", usuario.Username);
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@tipo", usuario.TipoUsuario);
                cmd.Parameters.AddWithValue("@estado", usuario.EstadoUsuario);

                int idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                usuario.IdUsuario = idUsuario;

                conexion.Close();

                return usuario;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // Acctulizar Usuarios para modificar y bloquear.
        public static UsuarioEntidad ActualizarUsuario(UsuarioEntidad usuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE [dbo].[usuarios]
                                    SET [USU_USERNAME]=@username
                                        ,[USU_CONTRASEÑA]= @contrasena
                                        ,[USU_NOMBRE]= @nombre
                                        ,[USU_APELLIDO]= @apellido
                                        ,[USU_TIPO]= @tipo
                                        ,[USU_ESTADO]= @estado
                                    WHERE [USU_ID]=@id;
                                        ";
                cmd.Parameters.AddWithValue("@username", usuario.Username);
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@tipo", usuario.TipoUsuario);
                cmd.Parameters.AddWithValue("@estado", usuario.EstadoUsuario);
                cmd.Parameters.AddWithValue("@id", usuario.IdUsuario);

                cmd.ExecuteNonQuery();

                conexion.Close();

                return usuario;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Devuelve el Usuario por ID
        public static UsuarioEntidad DevolverUsuarioPorId(int id)
        {
            UsuarioEntidad usuario = new UsuarioEntidad();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [USU_ID]
                                          ,[USU_USERNAME]
                                          ,[USU_CONTRASEÑA]
                                          ,[USU_NOMBRE]
                                          ,[USU_APELLIDO]
                                          ,[USU_TIPO]
                                          ,[USU_ESTADO]
                                      FROM [dbo].[usuarios] where [USU_ID] = @id ";

                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        usuario.IdUsuario = Convert.ToInt32(dr["USU_ID"].ToString());
                        usuario.Username = (dr["USU_USERNAME"].ToString());
                        usuario.Contrasena = (dr["USU_CONTRASEÑA"].ToString());
                        usuario.Nombre = (dr["USU_NOMBRE"].ToString());
                        usuario.Apellido = (dr["USU_APELLIDO"].ToString());
                        usuario.TipoUsuario = dr["USU_TIPO"].ToString();
                        usuario.EstadoUsuario = (dr["USU_ESTADO"].ToString());


                    }
                }


                conexion.Close();

                return usuario;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Busca el usuario por Username para comprobar en el login.
        public static UsuarioEntidad DevolverUsuarioPorUsername(string username)
        {
            UsuarioEntidad usuario = new UsuarioEntidad();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [USU_ID]
                                          ,[USU_USERNAME] 
                                          ,[USU_CONTRASEÑA]
                                          ,[USU_NOMBRE]
                                          ,[USU_APELLIDO]
                                          ,[USU_TIPO]
                                          ,[USU_ESTADO]
                                      FROM [dbo].[usuarios] where [USU_USERNAME] = @username ";

                cmd.Parameters.AddWithValue("@username", username);

                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        usuario.IdUsuario = Convert.ToInt32(dr["USU_ID"].ToString());
                        usuario.Username = (dr["USU_USERNAME"].ToString());
                        usuario.Contrasena = (dr["USU_CONTRASEÑA"].ToString());
                        usuario.Nombre = (dr["USU_NOMBRE"].ToString());
                        usuario.Apellido = (dr["USU_APELLIDO"].ToString());
                        usuario.TipoUsuario = dr["USU_TIPO"].ToString();
                        usuario.EstadoUsuario = (dr["USU_ESTADO"].ToString());


                    }
                }


                conexion.Close();

                return usuario;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Repartidores filtra ususarios por USU_TIPO
        public static List<UsuarioEntidad> ListaUsuariosPorTipo(string tipo)
        {
            try
            {
                List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [USU_ID]
                                          ,[USU_USERNAME]
                                          ,[USU_CONTRASEÑA]
                                          ,[USU_NOMBRE]
                                          ,[USU_APELLIDO]
                                          ,[USU_TIPO]
                                          ,[USU_ESTADO]
                                      FROM [usuarios]
                                      WHERE [USU_TIPO] = @USU_TIPO
                                     ";
                cmd.Parameters.AddWithValue("@USU_TIPO", tipo);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        UsuarioEntidad usuario = new UsuarioEntidad();
                        usuario.IdUsuario = Convert.ToInt32(dr["USU_ID"].ToString());
                        usuario.Username = dr["USU_USERNAME"].ToString();
                        usuario.Contrasena = dr["USU_CONTRASEÑA"].ToString();
                        usuario.Nombre = dr["USU_NOMBRE"].ToString();
                        usuario.Apellido = dr["USU_APELLIDO"].ToString();
                        usuario.TipoUsuario = dr["USU_TIPO"].ToString();
                        usuario.EstadoUsuario = dr["USU_ESTADO"].ToString();
                        lista.Add(usuario);
                    }
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //devuelve el nombre del usuario por su id (se ocupa para listar los pedidos)
        public static string DevolverNombreUsuario(int id)
        {
            string nombre = "";
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [USU_NOMBRE] + ' ' +[USU_APELLIDO] as NOMBRE
                                      FROM [dbo].[usuarios] where [USU_ID] = @id ";

                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {


                        nombre = (dr["NOMBRE"].ToString());



                    }
                }


                conexion.Close();

                return nombre;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        //Devuelve una busqueda de usuario ya sea por username, Nombre o Apellido
        public static List<UsuarioEntidad> BuscarUsuarioPorNombre(string nombre, string tipo)
        {
            try
            {
                List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                if (nombre.Equals("null"))
                {
                    cmd.CommandText = @"SELECT [USU_ID]
                                          ,[USU_USERNAME]
                                          ,[USU_CONTRASEÑA]
                                          ,[USU_NOMBRE]
                                          ,[USU_APELLIDO]
                                          ,[USU_TIPO]
                                          ,[USU_ESTADO]
                                      FROM [usuarios]
                                      WHERE [USU_TIPO]=@TIPO and [USU_ESTADO]='H'
                                     ";
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                    cmd.Parameters.AddWithValue("@TIPO", tipo);

                }
                else
                {
                    cmd.CommandText = @"SELECT [USU_ID]
                                          ,[USU_USERNAME]
                                          ,[USU_CONTRASEÑA]
                                          ,[USU_NOMBRE]
                                          ,[USU_APELLIDO]
                                          ,[USU_TIPO]
                                          ,[USU_ESTADO]
                                      FROM [usuarios]
                                      WHERE ([USU_USERNAME] = @NOMBRE 
                                         OR [USU_NOMBRE] = @NOMBRE
                                         OR [USU_APELLIDO] = @NOMBRE) and [USU_TIPO]=@TIPO and [USU_ESTADO]='H'
                                     ";
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                    cmd.Parameters.AddWithValue("@TIPO", tipo);

                }
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        UsuarioEntidad usuario = new UsuarioEntidad();
                        usuario.IdUsuario = Convert.ToInt32(dr["USU_ID"].ToString());
                        usuario.Username = dr["USU_USERNAME"].ToString();
                        usuario.Contrasena = dr["USU_CONTRASEÑA"].ToString();
                        usuario.Nombre = dr["USU_NOMBRE"].ToString();
                        usuario.Apellido = dr["USU_APELLIDO"].ToString();
                        usuario.TipoUsuario = dr["USU_TIPO"].ToString();
                        usuario.EstadoUsuario = dr["USU_ESTADO"].ToString();
                        lista.Add(usuario);
                    }
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static UsuarioEntidad ValidarUsuario(UsuarioEntidad usuarioEntidad)
        {
            try
            {

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(); //sentencias SQL
                cmd.Connection = conexion; //se vincula la conexion
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT [USU_ID]
                                  ,[USU_USERNAME]
                                  ,[USU_CONTRASEÑA]
                                  ,[USU_NOMBRE]
                                  ,[USU_APELLIDO]
                                  ,[USU_TIPO]
                                  ,[USU_ESTADO]
                              FROM [usuarios]
                              where USU_CONTRASEÑA=@clave
                                AND USU_USERNAME=@user";

                cmd.Parameters.AddWithValue("@user", usuarioEntidad.Username);
                cmd.Parameters.AddWithValue("@clave", usuarioEntidad.Contrasena);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        usuarioEntidad.IdUsuario = Convert.ToInt32(dr["USU_ID"].ToString());
                        usuarioEntidad.Nombre = dr["USU_NOMBRE"].ToString();
                        usuarioEntidad.Apellido = dr["USU_APELLIDO"].ToString();
                        usuarioEntidad.TipoUsuario = dr["USU_TIPO"].ToString();
                        usuarioEntidad.EstadoUsuario = dr["USU_ESTADO"].ToString();
                        return usuarioEntidad;
                    }
                    return null;
                }





            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}