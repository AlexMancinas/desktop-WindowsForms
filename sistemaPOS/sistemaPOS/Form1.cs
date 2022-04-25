using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaDLL;

namespace sistemaPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string validar = string.Format("Select * FROM Clientes WHERE account='{0}' AND password='{1}'", textUsuario.Text.Trim(), textPassword.Text.Trim());
                DataSet conectar = Biblioteca.Herramientas(validar);

                string cuenta = conectar.Tables[0].Rows[0]["account"].ToString().Trim();
                string conrasena = conectar.Tables[0].Rows[0]["password"].ToString().Trim();
                
                if(cuenta == textUsuario.Text.Trim() && conrasena == textPassword.Text.Trim())
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
