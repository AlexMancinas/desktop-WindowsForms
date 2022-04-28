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
    public partial class ConsultarCliente : Consultas
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        //Buscar Clientes
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validador de no espacios en blanco
            if (string.IsNullOrEmpty(textBuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string buscar = "Select * from Clientes WHERE Nombre_cliente  LIKE ('%" + textBuscar.Text.Trim() + "%')";
                    DS = Biblioteca.Herramientas(buscar);
                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se puede conectar, Error: ", error.Message);
                }
            }
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            //Para visualizar los datos de los clientes
            dataGridView1.DataSource = MostrarInfoDG("Clientes").Tables[0];
        }
    }
}
