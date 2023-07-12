using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ConsultaDatos
    {
        public static List<ConsultasEntidad> ConsultaProductos(DateTime fechaInicial, DateTime fechaFinal, int cantidad, string filtro)
        {
            List<ConsultasEntidad> resultados = new List<ConsultasEntidad>();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                if (filtro.Equals("monto"))
                {
                    cmd.CommandText = @"  SELECT TOP (@cantidad) pd.DET_PRO,pr.PRO_NOMBRE, sum(pd.DET_CANTIDAD) AS cantidad, sum(pd.DET_CANTIDAD*pr.PRO_PRECIO) as monto
                                      FROM   dbo.pedido_detalle pd INNER JOIN
                                             dbo.pedidos p ON pd.DET_ID_PER = p.PED_ID INNER JOIN
                                             dbo.productos pr ON pd.DET_PRO = pr.PRO_ID
                                      WHERE (p.PED_FECHA between @fechaInicio and @fechaFinal)
                                      GROUP BY pr.PRO_NOMBRE, pd.DET_PRO
                                      ORDER BY 4 DESC ";

                }
                else if (filtro.Equals("cantidad"))
                {
                    cmd.CommandText = @"  SELECT TOP (@cantidad) pd.DET_PRO,pr.PRO_NOMBRE, sum(pd.DET_CANTIDAD) AS cantidad, sum(pd.DET_CANTIDAD*pr.PRO_PRECIO) as monto
                                      FROM   dbo.pedido_detalle pd INNER JOIN
                                             dbo.pedidos p ON pd.DET_ID_PER = p.PED_ID INNER JOIN
                                             dbo.productos pr ON pd.DET_PRO = pr.PRO_ID
                                      WHERE (p.PED_FECHA between @fechaInicio and @fechaFinal)
                                      GROUP BY pr.PRO_NOMBRE, pd.DET_PRO
                                      ORDER BY 3 DESC ";

                }

                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicial);
                cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                //cmd.Parameters.AddWithValue("@filtro ", filtro);

                using (var dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        ConsultasEntidad resultado = new ConsultasEntidad();
                        resultado.ID = Convert.ToInt32(dr["DET_PRO"].ToString());
                        resultado.Nombre = (dr["PRO_NOMBRE"].ToString());
                        resultado.Cantidad = Convert.ToInt32(dr["cantidad"].ToString());
                        resultado.Monto = Convert.ToDouble(dr["monto"].ToString());

                        resultados.Add(resultado);



                    }
                }


                conexion.Close();

                return resultados;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // consulta de clientes

        public static List<ConsultasEntidad> ConsultaClientes(DateTime fechaInicial, DateTime fechaFinal, int cantidad, string filtro)
        {
            List<ConsultasEntidad> resultados = new List<ConsultasEntidad>();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                if (filtro.Equals("monto"))
                {
                    cmd.CommandText = @"   select TOP (@cantidad) p.PED_CLIENTE, u.USU_NOMBRE+' '+u.USU_APELLIDO as Nombre,sum(p.TOTAL) as Monto, COUNT(p.PED_CLIENTE) as Cantidad  
                                              from pedidos p INNER JOIN  usuarios u on p.PED_CLIENTE=u.USU_ID
                                              where p.PED_FECHA between @fechaInicio and @fechaFinal
                                              GROUP BY p.PED_CLIENTE,  u.USU_NOMBRE+' '+u.USU_APELLIDO
                                              ORDER BY 3 DESC  ";
                }
                else if (filtro.Equals("cantidad"))
                {
                    cmd.CommandText = @"   select TOP (@cantidad) p.PED_CLIENTE, u.USU_NOMBRE+' '+u.USU_APELLIDO as Nombre,sum(p.TOTAL) as Monto, COUNT(p.PED_CLIENTE) as Cantidad  
                                              from pedidos p INNER JOIN  usuarios u on p.PED_CLIENTE=u.USU_ID
                                              where p.PED_FECHA between @fechaInicio and @fechaFinal
                                              GROUP BY p.PED_CLIENTE,  u.USU_NOMBRE+' '+u.USU_APELLIDO
                                              ORDER BY 4 DESC  ";
                }

                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicial);
                cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                //cmd.Parameters.AddWithValue("@filtro ", filtro);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ConsultasEntidad resultado = new ConsultasEntidad();
                        resultado.ID = Convert.ToInt32(dr["PED_CLIENTE"].ToString());
                        resultado.Nombre = (dr["Nombre"].ToString());
                        resultado.Cantidad = Convert.ToInt32(dr["Cantidad"].ToString());
                        resultado.Monto = Convert.ToDouble(dr["Monto"].ToString());

                        resultados.Add(resultado);

                    }
                }

                conexion.Close();

                return resultados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // consulta de los repartidores

        public static List<ConsultasEntidad> ConsultaRepartidores(DateTime fechaInicial, DateTime fechaFinal, int cantidad, string filtro)
        {
            List<ConsultasEntidad> resultados = new List<ConsultasEntidad>();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                if (filtro.Equals("monto"))
                {
                    cmd.CommandText = @" select TOP (@cantidad) p.PED_REPARTIDOR, u.USU_NOMBRE+' '+u.USU_APELLIDO as Nombre,sum(p.TOTAL) as Monto, COUNT(p.PED_REPARTIDOR) as Cantidad  
                                              from pedidos p INNER JOIN  usuarios u on p.PED_REPARTIDOR=u.USU_ID
                                              where p.PED_FECHA between @fechaInicio and @fechaFinal 
                                              and u.USU_TIPO='R'
                                              GROUP BY p.PED_REPARTIDOR,  u.USU_NOMBRE+' '+u.USU_APELLIDO
                                              ORDER BY 3 DESC  ";
                }
                else if (filtro.Equals("cantidad"))
                {
                    cmd.CommandText = @" select TOP (@cantidad) p.PED_REPARTIDOR, u.USU_NOMBRE+' '+u.USU_APELLIDO as Nombre,sum(p.TOTAL) as Monto, COUNT(p.PED_REPARTIDOR) as Cantidad  
                                              from pedidos p INNER JOIN  usuarios u on p.PED_REPARTIDOR=u.USU_ID
                                              where p.PED_FECHA between @fechaInicio and @fechaFinal
                                              and u.USU_TIPO='R'
                                              GROUP BY p.PED_REPARTIDOR,  u.USU_NOMBRE+' '+u.USU_APELLIDO
                                              ORDER BY 4 DESC  ";
                }
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicial);
                cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                cmd.Parameters.AddWithValue("@filtro ", filtro);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ConsultasEntidad resultado = new ConsultasEntidad();
                        resultado.ID = Convert.ToInt32(dr["PED_REPARTIDOR"].ToString());
                        resultado.Nombre = (dr["Nombre"].ToString());
                        resultado.Cantidad = Convert.ToInt32(dr["Cantidad"].ToString());
                        resultado.Monto = Convert.ToDouble(dr["Monto"].ToString());

                        resultados.Add(resultado);

                    }
                }

                conexion.Close();

                return resultados;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
