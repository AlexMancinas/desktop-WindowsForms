using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;
namespace SistemaPOS
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            //verificar quien es el usuario que inicio sesion y mostrartlo en el label 'VENDEDOR' 
            string vendedor = "Select * from Usuarios where id_usuario = " + Login.Codigo;
            DataSet ds;
            ds = Biblioteca.Herramientas(vendedor);

            lbVendedor.Text = ds.Tables[0].Rows[0]["username"].ToString().Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()) == false)
                {
                    string cmd = string.Format("Select Nombre_cliente from Clientes where id_cliente = '{0}'", txtCodigoCliente.Text.Trim());
                    DataSet ds = Biblioteca.Herramientas(cmd);

                    txtCliente.Text = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString().Trim();

                    txtDescripcionProd.Focus();
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }
    }
}
