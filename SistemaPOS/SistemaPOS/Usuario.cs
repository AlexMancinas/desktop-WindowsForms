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
    public partial class Usuario : FormBase
    {
        public Usuario()
        {
            InitializeComponent();
        }
        //Muestra los datos del usuario 
        private void Usuario_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Usuarios WHERE id_usuario = " + Login.Codigo;
            DataSet Data = Biblioteca.Herramientas(consulta);

            lNombre.Text = Data.Tables[0].Rows[0]["username"].ToString();
            lUser.Text = Data.Tables[0].Rows[0]["account"].ToString();
            lCodigo.Text = Data.Tables[0].Rows[0]["id_usuario"].ToString();

            string imagen = Data.Tables[0].Rows[0]["imagen"].ToString();
            pictureBox1.Image = Image.FromFile(imagen);
        }
        //Salir del programa al presionar la X
        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Pasar de la ventana usuario al contenedor principal (MDI)
        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal con_principal = new ContenedorPrincipal();
            this.Hide();
            con_principal.Show();

        }
    }
}
