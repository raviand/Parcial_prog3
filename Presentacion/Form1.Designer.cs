namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboListaProductos = new System.Windows.Forms.GroupBox();
            this.lblTotalPesos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnMostrarVentas = new System.Windows.Forms.Button();
            this.gboListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // gboListaProductos
            // 
            this.gboListaProductos.Controls.Add(this.lblTotalPesos);
            this.gboListaProductos.Controls.Add(this.lblTotal);
            this.gboListaProductos.Controls.Add(this.dgvDetalleVentas);
            this.gboListaProductos.Controls.Add(this.lblCantidad);
            this.gboListaProductos.Controls.Add(this.btnAgregar);
            this.gboListaProductos.Controls.Add(this.lblProducto);
            this.gboListaProductos.Controls.Add(this.txtCantidad);
            this.gboListaProductos.Controls.Add(this.cboProductos);
            this.gboListaProductos.Location = new System.Drawing.Point(28, 46);
            this.gboListaProductos.Name = "gboListaProductos";
            this.gboListaProductos.Size = new System.Drawing.Size(565, 289);
            this.gboListaProductos.TabIndex = 8;
            this.gboListaProductos.TabStop = false;
            this.gboListaProductos.Text = "Detalle Venta:";
            // 
            // lblTotalPesos
            // 
            this.lblTotalPesos.AutoSize = true;
            this.lblTotalPesos.Location = new System.Drawing.Point(481, 264);
            this.lblTotalPesos.Name = "lblTotalPesos";
            this.lblTotalPesos.Size = new System.Drawing.Size(25, 13);
            this.lblTotalPesos.TabIndex = 9;
            this.lblTotalPesos.Text = "$$$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(426, 264);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Location = new System.Drawing.Point(6, 52);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.Size = new System.Drawing.Size(553, 198);
            this.dgvDetalleVentas.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(300, 28);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.Location = new System.Drawing.Point(412, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(65, 28);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(358, 25);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(37, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(123, 25);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(171, 21);
            this.cboProductos.TabIndex = 3;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(196, 19);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(242, 21);
            this.cboClientes.TabIndex = 10;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(148, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(512, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.Location = new System.Drawing.Point(420, 341);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(86, 23);
            this.btnGenerarVenta.TabIndex = 13;
            this.btnGenerarVenta.Text = "Generar Venta";
            this.btnGenerarVenta.UseVisualStyleBackColor = true;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(645, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnMostrarVentas
            // 
            this.btnMostrarVentas.Location = new System.Drawing.Point(28, 341);
            this.btnMostrarVentas.Name = "btnMostrarVentas";
            this.btnMostrarVentas.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarVentas.TabIndex = 16;
            this.btnMostrarVentas.Text = "&Ver ventas";
            this.btnMostrarVentas.UseVisualStyleBackColor = true;
            this.btnMostrarVentas.Click += new System.EventHandler(this.btnMostrarVentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 405);
            this.Controls.Add(this.btnMostrarVentas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.gboListaProductos);
            this.Name = "Form1";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gboListaProductos.ResumeLayout(false);
            this.gboListaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox gboListaProductos;
        internal System.Windows.Forms.DataGridView dgvDetalleVentas;
        internal System.Windows.Forms.Label lblCantidad;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Label lblProducto;
        internal System.Windows.Forms.TextBox txtCantidad;
        internal System.Windows.Forms.ComboBox cboProductos;
        internal System.Windows.Forms.ComboBox cboClientes;
        internal System.Windows.Forms.Label lblCliente;
        internal System.Windows.Forms.Label lblTotalPesos;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnGenerarVenta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnMostrarVentas;
    }
}

