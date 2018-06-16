using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
namespace Servicio
{
    public class ProductoService
    {
        //Traer productos


        //Descontar Stock

        //Devolver Stock
        public IList<Producto> listarTodos()
        {
            IList<Producto> lista = new List<Producto>();
            AccesoDatos conexion = new AccesoDatos();
            SqlDataReader lector;
            try
            {
                conexion.setearConsulta("Select IdProducto, Nombre, Venta, Stock From Productos");
                lector = conexion.leerConsulta();
                while (lector.Read())
                {
                    Producto aux = new Producto();
                    aux.IdProducto = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.PrecioVenta = lector.GetDecimal(2);
                    aux.Stock = lector.GetInt32(3);
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
    }
}
