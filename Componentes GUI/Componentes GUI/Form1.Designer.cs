namespace Componentes_GUI
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
            this.gbProcesador = new System.Windows.Forms.GroupBox();
            this.rbEptium = new System.Windows.Forms.RadioButton();
            this.rbSXM = new System.Windows.Forms.RadioButton();
            this.rbMDA = new System.Windows.Forms.RadioButton();
            this.rbElestar = new System.Windows.Forms.RadioButton();
            this.groupBoxMemoria = new System.Windows.Forms.GroupBox();
            this.rb1tb = new System.Windows.Forms.RadioButton();
            this.rb512Gb = new System.Windows.Forms.RadioButton();
            this.rb16tb = new System.Windows.Forms.RadioButton();
            this.rb4TB = new System.Windows.Forms.RadioButton();
            this.checkedListBoxOtrosDisp = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCont = new System.Windows.Forms.CheckBox();
            this.checkBoxGrabador = new System.Windows.Forms.CheckBox();
            this.listBoxConfGuard = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarConf = new System.Windows.Forms.Button();
            this.gbProcesador.SuspendLayout();
            this.groupBoxMemoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProcesador
            // 
            this.gbProcesador.Controls.Add(this.rbEptium);
            this.gbProcesador.Controls.Add(this.rbSXM);
            this.gbProcesador.Controls.Add(this.rbMDA);
            this.gbProcesador.Controls.Add(this.rbElestar);
            this.gbProcesador.Location = new System.Drawing.Point(60, 43);
            this.gbProcesador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProcesador.Name = "gbProcesador";
            this.gbProcesador.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProcesador.Size = new System.Drawing.Size(267, 123);
            this.gbProcesador.TabIndex = 0;
            this.gbProcesador.TabStop = false;
            this.gbProcesador.Text = "Procesador";
            // 
            // rbEptium
            // 
            this.rbEptium.AutoSize = true;
            this.rbEptium.Location = new System.Drawing.Point(144, 25);
            this.rbEptium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEptium.Name = "rbEptium";
            this.rbEptium.Size = new System.Drawing.Size(69, 20);
            this.rbEptium.TabIndex = 3;
            this.rbEptium.TabStop = true;
            this.rbEptium.Text = "Eptium";
            this.rbEptium.UseVisualStyleBackColor = true;
            // 
            // rbSXM
            // 
            this.rbSXM.AutoSize = true;
            this.rbSXM.Location = new System.Drawing.Point(23, 71);
            this.rbSXM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSXM.Name = "rbSXM";
            this.rbSXM.Size = new System.Drawing.Size(56, 20);
            this.rbSXM.TabIndex = 2;
            this.rbSXM.TabStop = true;
            this.rbSXM.Text = "SXM";
            this.rbSXM.UseVisualStyleBackColor = true;
            // 
            // rbMDA
            // 
            this.rbMDA.AutoSize = true;
            this.rbMDA.Location = new System.Drawing.Point(144, 71);
            this.rbMDA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMDA.Name = "rbMDA";
            this.rbMDA.Size = new System.Drawing.Size(58, 20);
            this.rbMDA.TabIndex = 1;
            this.rbMDA.TabStop = true;
            this.rbMDA.Text = "MDA";
            this.rbMDA.UseVisualStyleBackColor = true;
            // 
            // rbElestar
            // 
            this.rbElestar.AutoSize = true;
            this.rbElestar.Location = new System.Drawing.Point(23, 25);
            this.rbElestar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbElestar.Name = "rbElestar";
            this.rbElestar.Size = new System.Drawing.Size(70, 20);
            this.rbElestar.TabIndex = 0;
            this.rbElestar.TabStop = true;
            this.rbElestar.Text = "Elestar";
            this.rbElestar.UseVisualStyleBackColor = true;
            // 
            // groupBoxMemoria
            // 
            this.groupBoxMemoria.Controls.Add(this.rb1tb);
            this.groupBoxMemoria.Controls.Add(this.rb512Gb);
            this.groupBoxMemoria.Controls.Add(this.rb16tb);
            this.groupBoxMemoria.Controls.Add(this.rb4TB);
            this.groupBoxMemoria.Location = new System.Drawing.Point(415, 43);
            this.groupBoxMemoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMemoria.Name = "groupBoxMemoria";
            this.groupBoxMemoria.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMemoria.Size = new System.Drawing.Size(267, 123);
            this.groupBoxMemoria.TabIndex = 1;
            this.groupBoxMemoria.TabStop = false;
            this.groupBoxMemoria.Text = "Memoria";
            // 
            // rb1tb
            // 
            this.rb1tb.AutoSize = true;
            this.rb1tb.Location = new System.Drawing.Point(8, 71);
            this.rb1tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb1tb.Name = "rb1tb";
            this.rb1tb.Size = new System.Drawing.Size(53, 20);
            this.rb1tb.TabIndex = 4;
            this.rb1tb.TabStop = true;
            this.rb1tb.Text = "1TB";
            this.rb1tb.UseVisualStyleBackColor = true;
            // 
            // rb512Gb
            // 
            this.rb512Gb.AutoSize = true;
            this.rb512Gb.Location = new System.Drawing.Point(8, 25);
            this.rb512Gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb512Gb.Name = "rb512Gb";
            this.rb512Gb.Size = new System.Drawing.Size(68, 20);
            this.rb512Gb.TabIndex = 5;
            this.rb512Gb.TabStop = true;
            this.rb512Gb.Text = "512GB";
            this.rb512Gb.UseVisualStyleBackColor = true;
            // 
            // rb16tb
            // 
            this.rb16tb.AutoSize = true;
            this.rb16tb.Location = new System.Drawing.Point(145, 71);
            this.rb16tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb16tb.Name = "rb16tb";
            this.rb16tb.Size = new System.Drawing.Size(60, 20);
            this.rb16tb.TabIndex = 6;
            this.rb16tb.TabStop = true;
            this.rb16tb.Text = "16TB";
            this.rb16tb.UseVisualStyleBackColor = true;
            // 
            // rb4TB
            // 
            this.rb4TB.AutoSize = true;
            this.rb4TB.Location = new System.Drawing.Point(145, 23);
            this.rb4TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb4TB.Name = "rb4TB";
            this.rb4TB.Size = new System.Drawing.Size(53, 20);
            this.rb4TB.TabIndex = 7;
            this.rb4TB.TabStop = true;
            this.rb4TB.Text = "4TB";
            this.rb4TB.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxOtrosDisp
            // 
            this.checkedListBoxOtrosDisp.FormattingEnabled = true;
            this.checkedListBoxOtrosDisp.Items.AddRange(new object[] {
            "TECLADO",
            "RATON",
            "MICROFONO",
            "ALTAVOCES ",
            "MONITOR LFT"});
            this.checkedListBoxOtrosDisp.Location = new System.Drawing.Point(423, 212);
            this.checkedListBoxOtrosDisp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBoxOtrosDisp.Name = "checkedListBoxOtrosDisp";
            this.checkedListBoxOtrosDisp.Size = new System.Drawing.Size(159, 106);
            this.checkedListBoxOtrosDisp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Otros dispositivos";
            // 
            // checkBoxCont
            // 
            this.checkBoxCont.AutoSize = true;
            this.checkBoxCont.Location = new System.Drawing.Point(60, 212);
            this.checkBoxCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCont.Name = "checkBoxCont";
            this.checkBoxCont.Size = new System.Drawing.Size(165, 20);
            this.checkBoxCont.TabIndex = 5;
            this.checkBoxCont.Text = "Controlador RAID 5010";
            this.checkBoxCont.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrabador
            // 
            this.checkBoxGrabador.AutoSize = true;
            this.checkBoxGrabador.Location = new System.Drawing.Point(60, 240);
            this.checkBoxGrabador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxGrabador.Name = "checkBoxGrabador";
            this.checkBoxGrabador.Size = new System.Drawing.Size(185, 20);
            this.checkBoxGrabador.TabIndex = 6;
            this.checkBoxGrabador.Text = "Grabador Violet Ray HDD";
            this.checkBoxGrabador.UseVisualStyleBackColor = true;
            // 
            // listBoxConfGuard
            // 
            this.listBoxConfGuard.FormattingEnabled = true;
            this.listBoxConfGuard.ItemHeight = 16;
            this.listBoxConfGuard.Location = new System.Drawing.Point(40, 422);
            this.listBoxConfGuard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxConfGuard.Name = "listBoxConfGuard";
            this.listBoxConfGuard.Size = new System.Drawing.Size(640, 116);
            this.listBoxConfGuard.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "32 bits",
            "64 bits"});
            this.comboBox1.Location = new System.Drawing.Point(60, 302);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Configuracion de disco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Configuraciones guardadas";
            // 
            // btnGuardarConf
            // 
            this.btnGuardarConf.Location = new System.Drawing.Point(415, 361);
            this.btnGuardarConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarConf.Name = "btnGuardarConf";
            this.btnGuardarConf.Size = new System.Drawing.Size(168, 28);
            this.btnGuardarConf.TabIndex = 11;
            this.btnGuardarConf.Text = "Guardar configuracion";
            this.btnGuardarConf.UseVisualStyleBackColor = true;
            this.btnGuardarConf.Click += new System.EventHandler(this.btnGuardarConf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 554);
            this.Controls.Add(this.btnGuardarConf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxConfGuard);
            this.Controls.Add(this.checkBoxGrabador);
            this.Controls.Add(this.checkBoxCont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxOtrosDisp);
            this.Controls.Add(this.groupBoxMemoria);
            this.Controls.Add(this.gbProcesador);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Configure su ordenador";
            this.gbProcesador.ResumeLayout(false);
            this.gbProcesador.PerformLayout();
            this.groupBoxMemoria.ResumeLayout(false);
            this.groupBoxMemoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProcesador;
        private System.Windows.Forms.GroupBox groupBoxMemoria;
        private System.Windows.Forms.RadioButton rbEptium;
        private System.Windows.Forms.RadioButton rbSXM;
        private System.Windows.Forms.RadioButton rbMDA;
        private System.Windows.Forms.RadioButton rbElestar;
        private System.Windows.Forms.RadioButton rb1tb;
        private System.Windows.Forms.RadioButton rb512Gb;
        private System.Windows.Forms.RadioButton rb16tb;
        private System.Windows.Forms.RadioButton rb4TB;
        private System.Windows.Forms.CheckedListBox checkedListBoxOtrosDisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCont;
        private System.Windows.Forms.CheckBox checkBoxGrabador;
        private System.Windows.Forms.ListBox listBoxConfGuard;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarConf;
    }
}

