namespace SistemaPOS
{
    partial class Facturacion
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
            this.components = new System.ComponentModel.Container();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnColocar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCliente = new LibreriaDLL.ErrorTxtBox();
            this.txtCodigoCliente = new LibreriaDLL.ErrorTxtBox();
            this.lbVendedor = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new LibreriaDLL.ErrorTxtBox();
            this.txtPrecio = new LibreriaDLL.ErrorTxtBox();
            this.txtCantidad = new LibreriaDLL.ErrorTxtBox();
            this.txtDescripcionProd = new LibreriaDLL.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(891, 514);
            this.btnSalir.Size = new System.Drawing.Size(116, 34);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(365, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 37);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(472, 189);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 36);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(553, 189);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(102, 36);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(659, 189);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 36);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnColocar
            // 
            this.btnColocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocar.Location = new System.Drawing.Point(744, 189);
            this.btnColocar.Name = "btnColocar";
            this.btnColocar.Size = new System.Drawing.Size(90, 36);
            this.btnColocar.TabIndex = 5;
            this.btnColocar.Text = "Colocar";
            this.btnColocar.UseVisualStyleBackColor = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(840, 189);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(90, 36);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "Código";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(195, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 51);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(395, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 51);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(615, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 51);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(809, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 51);
            this.label8.TabIndex = 14;
            this.label8.Text = "Importe";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 222);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(471, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 166);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(654, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(728, 514);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(128, 32);
            this.lbTotal.TabIndex = 25;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(936, 189);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 36);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(159, 152);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(175, 30);
            this.txtCliente.TabIndex = 28;
            this.txtCliente.Validar = true;
            this.txtCliente.ValidarNumeros = false;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(159, 98);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(175, 30);
            this.txtCodigoCliente.TabIndex = 29;
            this.txtCodigoCliente.Validar = true;
            this.txtCodigoCliente.ValidarNumeros = false;
            // 
            // lbVendedor
            // 
            this.lbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendedor.Location = new System.Drawing.Point(159, 49);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(175, 23);
            this.lbVendedor.TabIndex = 30;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(34, 241);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(134, 27);
            this.TxtCodigoProducto.TabIndex = 31;
            this.TxtCodigoProducto.Validar = true;
            this.TxtCodigoProducto.ValidarNumeros = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(459, 241);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(129, 27);
            this.txtPrecio.TabIndex = 32;
            this.txtPrecio.Validar = true;
            this.txtPrecio.ValidarNumeros = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(646, 241);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 27);
            this.txtCantidad.TabIndex = 33;
            this.txtCantidad.Validar = true;
            this.txtCantidad.ValidarNumeros = false;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProd.Location = new System.Drawing.Point(250, 241);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(129, 27);
            this.txtDescripcionProd.TabIndex = 34;
            this.txtDescripcionProd.Validar = true;
            this.txtDescripcionProd.ValidarNumeros = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 560);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.lbVendedor);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnColocar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnClientes, 0);
            this.Controls.SetChildIndex(this.btnProductos, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnColocar, 0);
            this.Controls.SetChildIndex(this.btnFacturar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lbTotal, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtCodigoCliente, 0);
            this.Controls.SetChildIndex(this.lbVendedor, 0);
            this.Controls.SetChildIndex(this.TxtCodigoProducto, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.txtDescripcionProd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnColocar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnNuevo;
        private LibreriaDLL.ErrorTxtBox txtCliente;
        private LibreriaDLL.ErrorTxtBox txtCodigoCliente;
        private System.Windows.Forms.Label lbVendedor;
        private LibreriaDLL.ErrorTxtBox TxtCodigoProducto;
        private LibreriaDLL.ErrorTxtBox txtPrecio;
        private LibreriaDLL.ErrorTxtBox txtCantidad;
        private LibreriaDLL.ErrorTxtBox txtDescripcionProd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}