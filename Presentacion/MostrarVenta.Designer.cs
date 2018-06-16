namespace Presentacion
{
    partial class MostrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListarVentas = new System.Windows.Forms.DataGridView();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarVentas
            // 
            this.dgvListarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarVentas.Location = new System.Drawing.Point(13, 97);
            this.dgvListarVentas.Name = "dgvListarVentas";
            this.dgvListarVentas.ReadOnly = true;
            this.dgvListarVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarVentas.Size = new System.Drawing.Size(775, 341);
            this.dgvListarVentas.TabIndex = 0;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(712, 68);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(75, 23);
            this.btnDevolucion.TabIndex = 1;
            this.btnDevolucion.Text = "&Devolucion";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(13, 68);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(545, 68);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(100, 20);
            this.tbxPass.TabIndex = 3;
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(545, 42);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(100, 20);
            this.tbxUser.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(493, 45);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // MostrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.dgvListarVentas);
            this.Name = "MostrarVenta";
            this.Text = "MostrarVenta";
            this.Load += new System.EventHandler(this.MostrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarVentas;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
    }
}