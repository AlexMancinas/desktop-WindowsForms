namespace SistemaPOS
{
    partial class MantenimientoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textIdProducto = new LibreriaDLL.ErrorTxtBox();
            this.textDescripcionProducto = new LibreriaDLL.ErrorTxtBox();
            this.textPrecioProducto = new LibreriaDLL.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(69, 304);
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 304);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 304);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(634, 304);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(64, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(335, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "PRODUCTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(570, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 161);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textIdProducto
            // 
            this.textIdProducto.Location = new System.Drawing.Point(268, 107);
            this.textIdProducto.Name = "textIdProducto";
            this.textIdProducto.Size = new System.Drawing.Size(176, 22);
            this.textIdProducto.TabIndex = 13;
            this.textIdProducto.Validar = true;
            this.textIdProducto.ValidarNumeros = true;
            this.textIdProducto.TextChanged += new System.EventHandler(this.textIdProducto_TextChanged);
            // 
            // textDescripcionProducto
            // 
            this.textDescripcionProducto.Location = new System.Drawing.Point(268, 187);
            this.textDescripcionProducto.Multiline = true;
            this.textDescripcionProducto.Name = "textDescripcionProducto";
            this.textDescripcionProducto.Size = new System.Drawing.Size(176, 89);
            this.textDescripcionProducto.TabIndex = 16;
            this.textDescripcionProducto.Validar = true;
            this.textDescripcionProducto.ValidarNumeros = false;
            // 
            // textPrecioProducto
            // 
            this.textPrecioProducto.Location = new System.Drawing.Point(268, 146);
            this.textPrecioProducto.Name = "textPrecioProducto";
            this.textPrecioProducto.Size = new System.Drawing.Size(176, 22);
            this.textPrecioProducto.TabIndex = 17;
            this.textPrecioProducto.Validar = true;
            this.textPrecioProducto.ValidarNumeros = false;
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPrecioProducto);
            this.Controls.Add(this.textDescripcionProducto);
            this.Controls.Add(this.textIdProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProductos";
            this.Text = "MantenimientoProductos";
            this.Load += new System.EventHandler(this.MantenimientoProductos_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.textIdProducto, 0);
            this.Controls.SetChildIndex(this.textDescripcionProducto, 0);
            this.Controls.SetChildIndex(this.textPrecioProducto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LibreriaDLL.ErrorTxtBox textIdProducto;
        private LibreriaDLL.ErrorTxtBox textDescripcionProducto;
        private LibreriaDLL.ErrorTxtBox textPrecioProducto;
    }
}