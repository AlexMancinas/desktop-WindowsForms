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
    public partial class Administrador : FormBase
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Extrae los datos del usuario y los muestra en pantalla 
        private void Administrador_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Usuarios WHERE id_usuario = " + Login.Codigo;
            DataSet Data = Biblioteca.Herramientas(consulta);

            lAdmin.Text = Data.Tables[0].Rows[0]["username"].ToString();
            lAdminUser.Text = Data.Tables[0].Rows[0]["account"].ToString();
            lAdminCodigo.Text = Data.Tables[0].Rows[0]["id_usuario"].ToString();

            string imagen = Data.Tables[0].Rows[0]["imagen"].ToString();
            pictureBox1.Image = Image.FromFile(imagen);


        }
        //Cierra la ventana donde muestra datos del usuario y se pasa al contenedor principal
        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal con_principal = new ContenedorPrincipal();
            this.Hide();
            con_principal.Show();
        }
    }
}
