using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicio;
using Dominio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Cliente cliente { get; set; }
        public Producto producto { get; set; }
        private IList<DetalleVenta> listaDetalleVenta = new List<DetalleVenta>();
        public DetalleVenta detalleVenta;
        private ProductoService productoService;
        private ClienteService clienteService;
        VentaService vs;
        MostrarVenta mv;


        public Form1()
        {
            productoService = new ProductoService();
             clienteService = new ClienteService();
            vs = new VentaService();
            InitializeComponent();
            mv = new MostrarVenta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //poblar grilla con coleccion de items detalleVenta.
            //listadetalleventa.add(new detalle venta)
            int cant = 0;
            
            if(cboClientes.SelectedIndex != -1 && cboProductos.SelectedIndex != -1)
            {
                cliente = (Cliente) cboClientes.SelectedItem;
                producto = (Producto) cboProductos.SelectedItem;
                if(txtCantidad.Text.CompareTo("") != 0)
                    cant = Int32.Parse(txtCantidad.Text);
               
                if(cant < producto.Stock && cant > 0)
                {
                    detalleVenta = new DetalleVenta();
                    detalleVenta.Cantidad = cant;
                    detalleVenta.PrecioUnitario = producto.PrecioVenta;
                    detalleVenta.Producto = producto;
                    detalleVenta.PrecioSubTotal = cant * producto.PrecioVenta;
                    listaDetalleVenta.Add(detalleVenta);
                }
                else
                {
                    MessageBox.Show("La cantidad excede el stock del producto");
                }
            }
            else
            {
                MessageBox.Show("Faltan seleccionar campos");

            }
            dgvDetalleVentas.DataSource = null;
            dgvDetalleVentas.DataSource = listaDetalleVenta;
            dgvDetalleVentas.Columns["IdDetalleVenta"].Visible = false;
            dgvDetalleVentas.Columns["IdVenta"].Visible = false;
            load();
        }

        

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            if(dgvDetalleVentas.RowCount > 0)
            {
                try
                {
                    vs.cliente = cliente;
                    vs.detalles = (List<DetalleVenta>)dgvDetalleVentas.DataSource;
                    vs.productos = (List<Producto>)cboProductos.DataSource;
                    vs.guardarVenta();
                    dgvDetalleVentas = null;
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error en guardar en base");
                }

            }
            //generar venta primero debera generar la venta y recuperar el id para poder dar de alta todos los
            //detalles de la venta.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            try
            {
                cboClientes.DataSource = clienteService.listarTodos();
                cboProductos.DataSource = productoService.listarTodos();

                dgvDetalleVentas.DataSource = listaDetalleVenta;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void load()
        {
            try
            {
                cboClientes.DataSource = clienteService.listarTodos();
                cboProductos.DataSource = productoService.listarTodos();

                dgvDetalleVentas.DataSource = listaDetalleVenta;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                cboClientes.DataSource = clienteService.listarTodos();
                cboProductos.DataSource = productoService.listarTodos();

                dgvDetalleVentas.DataSource = listaDetalleVenta;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            mv.productos = (List<Producto>)productoService.listarTodos();
            mv.ShowDialog();
            cboProductos.DataSource = productoService.listarTodos();
        }
    }
}
