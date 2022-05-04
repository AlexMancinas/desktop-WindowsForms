namespace WindowsFormsApp5
{
    partial class Form1
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
            this.employessDataSet = new WindowsFormsApp5.EmployessDataSet();
            this.employessDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp5.EmployessDataSetTableAdapters.EmployeesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.CreateTxtFile = new System.Windows.Forms.Button();
            this.CreateXMLFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employessDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employessDataSet
            // 
            this.employessDataSet.DataSetName = "EmployessDataSet";
            this.employessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employessDataSetBindingSource
            // 
            this.employessDataSetBindingSource.DataSource = this.employessDataSet;
            this.employessDataSetBindingSource.Position = 0;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employessDataSetBindingSource;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(211, 72);
            this.txtEmployeeID.MaxLength = 8;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(211, 128);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(164, 22);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(211, 183);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(164, 22);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(211, 232);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(100, 22);
            this.txtDateOfBirth.TabIndex = 3;
            this.txtDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(480, 75);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(135, 46);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CreateTxtFile
            // 
            this.CreateTxtFile.Location = new System.Drawing.Point(480, 150);
            this.CreateTxtFile.Name = "CreateTxtFile";
            this.CreateTxtFile.Size = new System.Drawing.Size(135, 55);
            this.CreateTxtFile.TabIndex = 9;
            this.CreateTxtFile.Text = "Create Text File";
            this.CreateTxtFile.UseVisualStyleBackColor = true;
            this.CreateTxtFile.Click += new System.EventHandler(this.CreateTxtFile_Click);
            // 
            // CreateXMLFile
            // 
            this.CreateXMLFile.Location = new System.Drawing.Point(480, 232);
            this.CreateXMLFile.Name = "CreateXMLFile";
            this.CreateXMLFile.Size = new System.Drawing.Size(135, 55);
            this.CreateXMLFile.TabIndex = 10;
            this.CreateXMLFile.Text = "Create XML File";
            this.CreateXMLFile.UseVisualStyleBackColor = true;
            this.CreateXMLFile.Click += new System.EventHandler(this.CreateXMLFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(644, 368);
            this.Controls.Add(this.CreateXMLFile);
            this.Controls.Add(this.CreateTxtFile);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(662, 415);
            this.MinimumSize = new System.Drawing.Size(662, 415);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employessDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employessDataSetBindingSource;
        private EmployessDataSet employessDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployessDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button CreateTxtFile;
        private System.Windows.Forms.Button CreateXMLFile;
    }
}

