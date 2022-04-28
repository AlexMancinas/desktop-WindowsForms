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
    public partial class ConsultarProductos : Consultas
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }

       
        private void ConsultarProductos_Load(object sender, EventArgs e)
        {
            //Hacer que se muestre la informacion en la tabla
            dataGridView1.DataSource = MostrarInfoDG("Articulos").Tables[0];
        }
        // Buscador productos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //validacion para campos en blanco del buscador
            if (string.IsNullOrEmpty(textBuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string buscar = "Select * from Articulos WHERE Nombre_producto LIKE ('%" + textBuscar.Text.Trim() + "%')";
                    DS = Biblioteca.Herramientas(buscar);
                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se puede conectar, Error: ", error.Message);
                }
            }
        }
    }
}
