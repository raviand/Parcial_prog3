using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
namespace Servicio
{
    public class ClienteService
    {
        //Traer Clientes
        public IList<Cliente> listarTodos()
        {
            IList<Cliente> lista = new List<Cliente>();
            AccesoDatos conexion = new AccesoDatos();
            SqlDataReader lector;
            try
            {
                conexion.setearConsulta("Select IdCliente, Nombre From Clientes");
                lector = conexion.leerConsulta();
                while (lector.Read())
                {
                    Cliente aux = new Cliente(lector.GetInt32(0), lector.GetString(1));
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
