using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Servicio;

namespace Presentacion
{
    public partial class MostrarVenta : Form
    {
        public List<DetalleVenta> ventas { get; set; }
        public List<Producto> productos { get; set; }
        VentaService vs;
        DetalleVenta detalleVenta;
        List<Usuario> usuarios;
        UsuarioService us;


        public MostrarVenta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            bool puedeborrar = false;
            foreach(Usuario pair in usuarios)
            {
                if(tbxUser.Text.CompareTo(pair.Nombre) == 0)
                {
                    if (tbxPass.Text.CompareTo(pair.Clave) == 0)
                    {
                        puedeborrar = true;
                        detalleVenta = (DetalleVenta)dgvListarVentas.CurrentRow.DataBoundItem;
                        vs.detalleVenta = detalleVenta;
                        vs.productosOriginales = productos;
                        vs.cargarStock();
                        MessageBox.Show("Se elimino con exito");

                    }
                }
            }
            if (puedeborrar == false)
            {
                MessageBox.Show("No tiene permiso para eliminar");
            }


            Close();
        }

        private void MostrarVenta_Load(object sender, EventArgs e)
        {
            us = new UsuarioService();
            //Aca listo las ventas
            vs = new VentaService();
            dgvListarVentas.DataSource = vs.listarVentas();
            usuarios = us.traerUsuarios();
        }
    }
}
