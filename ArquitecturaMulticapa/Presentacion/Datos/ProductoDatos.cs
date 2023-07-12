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
    public class ProductoDatos
    {
        //Lista los productos
        public static List<ProductoEntidad> ListaProductos()
        {
            try
            {
                List<ProductoEntidad> lista = new List<ProductoEntidad>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [PRO_ID]
                                          ,[PRO_NOMBRE]
                                          ,[PRO_PRECIO]
                                      FROM [productos]
                                     ";
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ProductoEntidad productos = new ProductoEntidad();
                        productos.IdProducto = Convert.ToInt32(dr["PRO_ID"]);
                        productos.NombreProducto = dr["PRO_NOMBRE"].ToString();
                        productos.PrecioProducto = Convert.ToDouble(dr["PRO_PRECIO"].ToString());
                        lista.Add(productos);
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

        public static ProductoEntidad DevolverProductoPorId(int id)
        {
            ProductoEntidad producto = new ProductoEntidad();
            try
            {

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [PRO_ID]
                                          ,[PRO_NOMBRE]
                                          ,[PRO_PRECIO]
                                      FROM [productos] where [PRO_ID]=@id
                                     ";

                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        producto.IdProducto = Convert.ToInt32(dr["PRO_ID"].ToString());
                        producto.NombreProducto = (dr["PRO_NOMBRE"]).ToString();
                        producto.PrecioProducto = Convert.ToDouble(dr["PRO_PRECIO"].ToString());


                    }
                }


                conexion.Close();

                return producto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}