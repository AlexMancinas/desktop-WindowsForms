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
    public partial class MantenimientoProductos : Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {

        }
        //Guardar Productos
        public override Boolean Guardar()
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {

                try
                {
                    string insertar = string.Format("EXEC ActualizarProductos '{0}','{1}','{2}'", textIdProducto.Text.Trim(), textDescripcionProducto.Text.Trim(), textPrecioProducto.Text.Trim());
                    Biblioteca.Herramientas(insertar);
                    MessageBox.Show("Producto guardado correctamente");
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
        //Eliminar Productos
        public override void ELiminar()
        {
            try
            {
                string eliminar = string.Format("EXEC EliminarProducto '{0}'", textIdProducto.Text.Trim());
                Biblioteca.Herramientas(eliminar);
                MessageBox.Show("El producto se ha eliminado correctamente");
            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrudo un error: " + error);
            }
            
        }

        private void textIdProducto_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
