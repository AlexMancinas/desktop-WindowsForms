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
    public partial class MantenimientoClientes : Mantenimiento
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }
        //Guardar CLientes
        public override Boolean Guardar()
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1)==false)
            {
                try
                {
                    string insertar = string.Format("EXEC ActualizarClientes '{0}','{1}','{2}'", textIdCliente.Text.Trim(), textNombreCliente.Text.Trim(), textApellidoCliente.Text.Trim());
                    Biblioteca.Herramientas(insertar);
                    MessageBox.Show("Cliente guardado correctamente");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //Eliminar Clientes
        public override void ELiminar()
        {
            try
            {
                string eliminar = string.Format("EXEC EliminarCLientes '{0}'", textIdCliente.Text.Trim());
                Biblioteca.Herramientas(eliminar);
                MessageBox.Show("El cliente se ha eliminado correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrudo un error: " + error);
            }

        }

        private void textIdCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
