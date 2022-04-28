using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPOS
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        //Creacion del boton 'SALIR'
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?" ,"Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        private void FormBase_Load(object sender, EventArgs e)
        {
             
        }
        //Boton ELiminar
        public virtual void ELiminar()
        {

        }
        //Boton Nuevo
        public virtual void Nuevo()
        {

        }
        //Boton Consultar
        public virtual void Consultar()
        {

        }
        //Boton Guardar
        public virtual Boolean Guardar()
        {
            return false;
        }
    }
}
