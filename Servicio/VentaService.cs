using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Servicio
{
    public class VentaService
    {
        //crear venta
        public Venta venta { get; set; }
        public List<DetalleVenta> detalles { get; set; }
        public Cliente cliente { get; set; }
        AccesoDatos accesoDatos;
        public List<Producto> productos { get; set; }
        public DetalleVenta detalleVenta { get; set; }
        public List<Producto> productosOriginales { get; set; }

        public VentaService()
        {
            detalleVenta = new DetalleVenta();
            accesoDatos = new AccesoDatos();
            venta = new Venta();
            detalles = new List<DetalleVenta>();
        }
       
        public void guardarVenta()
        {

            String query = $"exec insertarVenta " + cliente.IdCliente;
            String query2;


            int res;
            try
            {
                accesoDatos.setearConsulta(query);
                res = accesoDatos.ejecutarAccionEscalar();

                foreach (DetalleVenta item in detalles)
                {
                    /*foreach(Producto pair in productos)
                    {
                        if(pair.IdProducto == item.Producto.IdProducto)
                        {
                            String query3 = " UPDATE PRODUCTOS SET Stock = " + (pair.Stock - item.Cantidad) + " where idproducto = " + pair.IdProducto;
                            accesoDatos.setearConsulta(query3);
                            accesoDatos.ejecutarAccion();
                            break;
                        }
                    }*/

                    query2 = " exec insetarDetalleVenta " + res + " , " + item.Producto.IdProducto + " , " + item.Cantidad;
                    accesoDatos.setearConsulta(query2);
                    accesoDatos.ejecutarAccion();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cargarStock()
        {
            int cant = 0;
            foreach (Producto item in productosOriginales)
            {
                if (item.IdProducto == detalleVenta.Producto.IdProducto)
                {
                    cant = item.Stock;
                    break;
                }
            }

            String query = "Update PRODUCTOS SET STOCK = "+ (detalleVenta.Cantidad + cant) + " where idProducto = " + detalleVenta.Producto.IdProducto;
            accesoDatos.setearConsulta(query);
            accesoDatos.ejecutarAccion();
            query = "DeLETE DETALLE_VENTAS WHERE idDetalleVenta= " + detalleVenta.IdDetalleVenta;
            accesoDatos.setearConsulta(query);
            accesoDatos.ejecutarAccion();


        }

        private void actualizarStock( int restaStock)
        {

            try
            {
                foreach (Producto item in productos)
                {
                  String  query = " UPDATE PRODUCTOS SET Stock = " + (  - item.Stock) + " where idproducto = " + item.IdProducto;
                    accesoDatos.setearConsulta(query);
                    accesoDatos.ejecutarAccion();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        //anular venta
        /*
            public int IdDetalleVenta { get; set; }
            public int IdVenta { get; set; }
            public Producto Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal PrecioSubTotal { get; set; } 
         */
         public List<DetalleVenta> listarVentas()
        {
            String query = "SELECT DV.IdDetalleVenta, DV.IdVenta, DV.IdProducto, DV.Cantidad, P.Nombre FROM DETALLE_VENTAS AS DV INNER JOIN PRODUCTOS AS P ON P.IdProducto = DV.IdProducto ORDER BY DV.IdVenta";
            SqlDataReader lector;
            DetalleVenta dv;
            
            try
            {
                accesoDatos.setearConsulta(query);
                
                lector = accesoDatos.leerConsulta();

                while (lector.Read())
                {
                    dv = new DetalleVenta();
                    dv.Producto = new Producto();
                    dv.IdDetalleVenta = lector.GetInt32(0);
                    dv.IdVenta = lector.GetInt32(1);
                    dv.Producto.IdProducto = lector.GetInt32(2);
                    dv.Cantidad = lector.GetInt32(3);
                    dv.Producto.Nombre = lector.GetString(4);
                    detalles.Add(dv);
                }

                return detalles;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
