using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data;
using System.Data.SqlClient;

using System.Transactions;

namespace Datos
{
    public class PedidoDatos
    {
        //crear nuevo pedido con su detalle
        public static PedidoEntidad NuevoPedido(PedidoEntidad pedido)
        {
            try
            {
                using (var ts = new TransactionScope())
                {
                    SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO [pedidos]
                                                       ([PED_CLIENTE]
                                                       ,[PED_REPARTIDOR]
                                                       ,[PED_DIRECCION]
                                                       ,[PED_ESTADO]
                                                       ,[PED_FECHA]
                                                       ,[TOTAL]
                                                       ,[ESTADO])
                                        VALUES 
                                                (@PED_CLIENTE,@PED_REPARTIDOR,
                                                @PED_DIRECCION,@PED_ESTADO,@PED_FECHA,@TOTAL,@ESTADO);
                                        SELECT SCOPE_IDENTITY();
                                                ";
                    cmd.Parameters.AddWithValue("@PED_CLIENTE", pedido.IdClientePedido);
                    cmd.Parameters.AddWithValue("@PED_REPARTIDOR", pedido.IdRepartidorPedido);
                    cmd.Parameters.AddWithValue("@PED_DIRECCION", pedido.Direccion);
                    cmd.Parameters.AddWithValue("@PED_ESTADO", pedido.EstadoPedido);
                    cmd.Parameters.AddWithValue("@PED_FECHA", pedido.FechaPedido);
                    cmd.Parameters.AddWithValue("@TOTAL", pedido.TotalPedido);
                    cmd.Parameters.AddWithValue("@ESTADO", pedido.Estado);
                    int idPedido = Convert.ToInt32(cmd.ExecuteScalar());
                    pedido.IdPedido = idPedido;


                    ts.Complete();
                    conexion.Close();

                    return pedido;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Guarda el detalle del pedido
        public static DetallePedidoEntidad GuardarDetalle(DetallePedidoEntidad detalle)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [pedido_detalle]
                                                   ([DET_ID_PER]
                                                   ,[DET_PRO]
                                                   ,[DET_CANTIDAD])
                                        VALUES 
                                                (@ID_PED,@DET_PRO,
                                                @DET_CANTIDAD)
                                          ";

                cmd.Parameters.AddWithValue("@ID_PED", detalle.IdPedido);
                cmd.Parameters.AddWithValue("@DET_PRO", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@DET_CANTIDAD", detalle.Cantidad);

                cmd.ExecuteScalar();
                conexion.Close();
                return detalle;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //lista los pedidos
        public static List<PedidoEntidad> ListaPedidos()
        {
            try
            {
                List<PedidoEntidad> lista = new List<PedidoEntidad>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @" SELECT [PED_ID]
                                  ,[PED_CLIENTE]
                                  ,[PED_REPARTIDOR]
                                  ,[PED_DIRECCION]
                                  ,[PED_ESTADO]
                                  ,[PED_FECHA]
                                  ,[TOTAL]
                              FROM [pedidos]";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PedidoEntidad pedidoEntidad = new PedidoEntidad();

                        pedidoEntidad.IdRepartidorPedido = Convert.ToInt32(dr["PED_REPARTIDOR"].ToString());
                        pedidoEntidad.NombreR = DatosUsuario.DevolverNombreUsuario(Convert.ToInt32(dr["PED_REPARTIDOR"].ToString()));
                        pedidoEntidad.IdPedido = Convert.ToInt32(dr["PED_ID"].ToString());
                        pedidoEntidad.Direccion = dr["PED_DIRECCION"].ToString();
                        pedidoEntidad.IdClientePedido = Convert.ToInt32(dr["PED_CLIENTE"].ToString());
                        pedidoEntidad.NombreC = DatosUsuario.DevolverNombreUsuario(pedidoEntidad.IdClientePedido);
                        pedidoEntidad.FechaPedido = (dr["PED_FECHA"].ToString());
                        pedidoEntidad.EstadoPedido = dr["PED_ESTADO"].ToString();
                        pedidoEntidad.TotalPedido = Convert.ToDouble(dr["TOTAL"].ToString());

                        lista.Add(pedidoEntidad);
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
        //Lista los pedidos por cliente en los estados 'pendiente' (p) y 'no asignado' (na)
        public static List<PedidoEntidad> ListaPedidosClientes(string cliente)
        {
            try
            {
                List<PedidoEntidad> lista = new List<PedidoEntidad>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT dbo.pedidos.PED_ID
                                  ,dbo.usuarios.USU_NOMBRE +' '+ dbo.usuarios.USU_APELLIDO as NOMBRE
                                  ,dbo.pedidos.PED_ESTADO
                                  ,dbo.pedidos.PED_FECHA
                                  ,dbo.pedidos.TOTAL
                                  ,dbo.pedidos.PED_REPARTIDOR
                                  ,dbo.pedidos.PED_DIRECCION
                                   FROM dbo.pedidos INNER JOIN dbo.usuarios ON dbo.pedidos.PED_CLIENTE = dbo.usuarios.USU_ID
                                   WHERE (dbo.pedidos.PED_ESTADO = 'na' or dbo.pedidos.PED_ESTADO = 'p')
                                    and dbo.pedidos.ESTADO = 'C'
                                    and dbo.pedidos.PED_CLIENTE=(SELECT USU_ID
																FROM dbo.usuarios
																WHERE USU_USERNAME = @ID_CLIENTE) ";
                cmd.Parameters.AddWithValue("@ID_CLIENTE", cliente);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PedidoEntidad pedido = new PedidoEntidad();
                        /*if (dr["PED_REPARTIDOR"].ToString().Equals(""))
                        {
                            pedido.NombreR = "";
                        }
                        else
                        {*/
                        pedido.NombreR = DatosUsuario.DevolverNombreUsuario(Convert.ToInt32(dr["PED_REPARTIDOR"].ToString()));
                        // }

                        pedido.IdPedido = Convert.ToInt32(dr["PED_ID"].ToString());

                        pedido.Direccion = dr["PED_DIRECCION"].ToString();
                        pedido.FechaPedido = (dr["PED_FECHA"].ToString());
                        pedido.EstadoPedido = dr["PED_ESTADO"].ToString();
                        pedido.TotalPedido = Convert.ToDouble((dr["TOTAL"].ToString()));
                        lista.Add(pedido);

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
        //se carga el pedido dependiendo del estado q sea enviado
        public static List<PedidoEntidad> CargarPedidosPorEstado(string estado)
        {
            try
            {
                List<PedidoEntidad> lista = new List<PedidoEntidad>();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(); //sentencias SQL
                cmd.Connection = conexion; //se vincula la conexion
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT [PED_ID]
                                  ,[PED_CLIENTE]
                                  ,[PED_REPARTIDOR]
                                  ,[PED_DIRECCION]
                                  ,[PED_ESTADO]
                                  ,[PED_FECHA]
                                  ,[TOTAL]
                              FROM [dbo].[pedidos]
                              where PED_ESTADO=@estado";

                cmd.Parameters.AddWithValue("@estado", estado);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PedidoEntidad pedidoEntidad = new PedidoEntidad();

                        pedidoEntidad.IdRepartidorPedido = Convert.ToInt32(dr["PED_REPARTIDOR"].ToString());
                        pedidoEntidad.NombreR = DatosUsuario.DevolverNombreUsuario(Convert.ToInt32(dr["PED_REPARTIDOR"].ToString()));

                        pedidoEntidad.IdPedido = Convert.ToInt32(dr["PED_ID"].ToString());
                        pedidoEntidad.Direccion = dr["PED_DIRECCION"].ToString();
                        pedidoEntidad.IdClientePedido = Convert.ToInt32(dr["PED_CLIENTE"].ToString());
                        pedidoEntidad.NombreC = DatosUsuario.DevolverNombreUsuario(pedidoEntidad.IdClientePedido);

                        pedidoEntidad.FechaPedido = (dr["PED_FECHA"].ToString());
                        pedidoEntidad.EstadoPedido = dr["PED_ESTADO"].ToString();
                        pedidoEntidad.TotalPedido = Convert.ToDouble(dr["TOTAL"].ToString());

                        lista.Add(pedidoEntidad);
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

        //se carga el detalle del pedido
        public static List<ProductoEntidad> CargarPedidoDetalle(string pedido)
        {
            try
            {
                List<ProductoEntidad> lista = new List<ProductoEntidad>();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(); //sentencias SQL
                cmd.Connection = conexion; //se vincula la conexion
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"select pr.PRO_NOMBRE as Nombre, pr.PRO_PRECIO as Precio, pedido_detalle.DET_CANTIDAD as Cantidad
                                    from pedido_detalle
                                    inner join pedidos p on pedido_detalle.DET_ID_PER=p.PED_ID
                                    inner join productos pr on pedido_detalle.DET_PRO=pr.PRO_ID
                                    where p.PED_ID=@pedido";


                cmd.Parameters.AddWithValue("@pedido", pedido);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ProductoEntidad productoEntidad = new ProductoEntidad();
                        productoEntidad.NombreProducto = dr["Nombre"].ToString();
                        productoEntidad.PrecioProducto = Convert.ToDouble(dr["Precio"].ToString());
                        productoEntidad.Cantidad = Convert.ToInt32(dr["Cantidad"].ToString());
                        lista.Add(productoEntidad);
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
        //se asigna el repartidor a los que no tienen repartidor
        public static PedidoEntidad AsignarRepartidor(PedidoEntidad pedidoEntidad)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(); //sentencias SQL
                cmd.Connection = conexion; //se vincula la conexion
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"update pedidos
                                    set PED_REPARTIDOR=@repartidor, PED_ESTADO='P'
                                    where PED_ID=@id";

                cmd.Parameters.AddWithValue("@repartidor", pedidoEntidad.IdRepartidorPedido);
                cmd.Parameters.AddWithValue("@id", pedidoEntidad.IdPedido);

                cmd.ExecuteNonQuery();
                conexion.Close();

                return pedidoEntidad;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        // Se actualiza el Estado del Pedido
        public static PedidoEntidad ActualizarEstadoPedido(PedidoEntidad pedidoEntidad)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(); //sentencias SQL
                cmd.Connection = conexion; //se vincula la conexion
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"update pedidos
                                    set PED_ESTADO=@estado
                                    where PED_ID=@id";

                cmd.Parameters.AddWithValue("@estado", pedidoEntidad.EstadoPedido);
                cmd.Parameters.AddWithValue("@id", pedidoEntidad.IdPedido);

                cmd.ExecuteNonQuery();
                conexion.Close();

                return pedidoEntidad;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static PedidoEntidad ObtenerPedidoPorId(int id)
        {
            try
            {
                PedidoEntidad pedidoEntidad = new PedidoEntidad();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand("");
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT  [PED_ID]
                                                  ,[PED_CLIENTE]
                                                  ,[PED_REPARTIDOR]
                                                  ,[PED_DIRECCION]
                                                  ,[PED_ESTADO]
                                                  ,[PED_FECHA]
                                                  ,[TOTAL]
                                              FROM [pedidos]
                                              WHERE [PED_ID]=@id
                                                ";


                cmd.Parameters.AddWithValue("@id", id);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        if (dr["PED_REPARTIDOR"].ToString().Equals(""))
                        {
                            pedidoEntidad.NombreR = "";
                        }
                        else
                        {
                            pedidoEntidad.IdRepartidorPedido = Convert.ToInt32(dr["PED_REPARTIDOR"].ToString());
                            pedidoEntidad.NombreR = DatosUsuario.DevolverNombreUsuario(Convert.ToInt32(dr["PED_REPARTIDOR"].ToString()));
                        }
                        pedidoEntidad.IdPedido = Convert.ToInt32(dr["PED_ID"].ToString());
                        pedidoEntidad.Direccion = dr["PED_DIRECCION"].ToString();
                        pedidoEntidad.IdClientePedido = Convert.ToInt32(dr["PED_CLIENTE"].ToString());
                        pedidoEntidad.NombreC = DatosUsuario.DevolverNombreUsuario(pedidoEntidad.IdClientePedido);
                        //pedidoEntidad.IdRepartidorPedido = Convert.ToInt32(dr["PED_REPARTIDOR"].ToString());
                        //pedidoEntidad.NombreR = DatosUsuario.DevolverNombreUsuario(pedidoEntidad.IdRepartidorPedido);
                        pedidoEntidad.FechaPedido = (dr["PED_FECHA"].ToString());
                        pedidoEntidad.EstadoPedido = dr["PED_ESTADO"].ToString();
                        pedidoEntidad.TotalPedido = Convert.ToDouble(dr["TOTAL"].ToString());


                    }
                }


                conexion.Close();

                return pedidoEntidad;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //lista pedidos de estado Abierto
        public static PedidoEntidad ListaPedidosAbierto(string cliente)
        {
            PedidoEntidad pedido = new PedidoEntidad();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT dbo.pedidos.PED_ID
                                  ,dbo.usuarios.USU_NOMBRE +' '+ dbo.usuarios.USU_APELLIDO as NOMBRE
                                  ,dbo.pedidos.PED_ESTADO
                                  ,dbo.pedidos.PED_FECHA
                                  ,dbo.pedidos.TOTAL
                                  ,dbo.pedidos.PED_DIRECCION
                                   FROM dbo.pedidos INNER JOIN dbo.usuarios ON dbo.pedidos.PED_CLIENTE = dbo.usuarios.USU_ID
                                   WHERE (dbo.pedidos.PED_ESTADO = 'na' or dbo.pedidos.PED_ESTADO = 'p')
                                    and dbo.pedidos.ESTADO = 'A'
                                    and dbo.pedidos.PED_CLIENTE=(SELECT USU_ID
																FROM dbo.usuarios
																WHERE USU_USERNAME = @cliente)";
                cmd.Parameters.AddWithValue("@cliente", cliente);
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        pedido.IdPedido = Convert.ToInt32(dr["PED_ID"].ToString());
                        pedido.NombreC = dr["NOMBRE"].ToString();
                        pedido.Direccion = dr["PED_DIRECCION"].ToString();
                        pedido.FechaPedido = dr["PED_FECHA"].ToString();
                        pedido.EstadoPedido = dr["PED_ESTADO"].ToString();
                        pedido.TotalPedido = Convert.ToDouble(dr["TOTAL"].ToString());
                    }
                }
                conexion.Close();
                return pedido;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualiza el estado final
        public static PedidoEntidad ActualizarEstadoFinal(PedidoEntidad pedidoEntidad)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(); //sentencias SQL
                cmd.Connection = conexion; //se vincula la conexion
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"update pedidos
                                    set ESTADO=@estado,
                                    PED_DIRECCION=@direccion,
                                    PED_FECHA=@fecha
                                    where PED_ID=@id and ESTADO='A' 
                                    and PED_CLIENTE=@usuario";
                cmd.Parameters.AddWithValue("@estado", pedidoEntidad.Estado);
                cmd.Parameters.AddWithValue("@fecha", pedidoEntidad.FechaPedido);
                cmd.Parameters.AddWithValue("@direccion", pedidoEntidad.Direccion);
                cmd.Parameters.AddWithValue("@id", pedidoEntidad.IdPedido);
                cmd.Parameters.AddWithValue("@usuario", pedidoEntidad.IdClientePedido);

                cmd.ExecuteNonQuery();
                conexion.Close();

                return pedidoEntidad;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //lista los pedidos según el repartidor
        public static List<PedidoEntidad> CargarPedidosPorRepartidor(string repartidor)
        {
            try
            {
                List<PedidoEntidad> lista = new List<PedidoEntidad>();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(); //sentencias SQL
                cmd.Connection = conexion; //se vincula la conexion
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT [PED_ID]
                                  ,[PED_CLIENTE]
                                  ,[PED_REPARTIDOR]
                                  ,[PED_DIRECCION]
                                  ,[PED_ESTADO]
                                  ,[PED_FECHA]
                                  ,[TOTAL]
                              FROM [dbo].[pedidos]
                              where PED_ESTADO='p' and PED_REPARTIDOR=@repartidor";

                cmd.Parameters.AddWithValue("@repartidor", repartidor);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PedidoEntidad pedidoEntidad = new PedidoEntidad();
                        pedidoEntidad.IdPedido = Convert.ToInt32(dr["PED_ID"].ToString());
                        pedidoEntidad.Direccion = dr["PED_DIRECCION"].ToString();
                        pedidoEntidad.IdClientePedido = Convert.ToInt32(dr["PED_CLIENTE"].ToString());
                        pedidoEntidad.NombreC = DatosUsuario.DevolverNombreUsuario(pedidoEntidad.IdClientePedido);
                        pedidoEntidad.IdRepartidorPedido = Convert.ToInt32(dr["PED_REPARTIDOR"].ToString());
                        pedidoEntidad.NombreR = DatosUsuario.DevolverNombreUsuario(pedidoEntidad.IdRepartidorPedido);
                        pedidoEntidad.FechaPedido = dr["PED_FECHA"].ToString();
                        pedidoEntidad.EstadoPedido = dr["PED_ESTADO"].ToString();
                        pedidoEntidad.TotalPedido = Convert.ToDouble(dr["TOTAL"].ToString());

                        lista.Add(pedidoEntidad);
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
    }
}