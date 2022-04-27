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
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }
        public static String Codigo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                //Se manda llamar la base de datos 'Usuarios'
               
                string validar = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'",textUsuario.Text.Trim(),textPassword.Text.Trim());
                DataSet conectar = Biblioteca.Herramientas(validar);

                Codigo = conectar.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
                //Se declara la variable cuenta y contraseña y se le asignan los parametros de la base de datos
                string cuenta = conectar.Tables[0].Rows[0]["account"].ToString().Trim();
                string contrasena = conectar.Tables[0].Rows[0]["password"].ToString().Trim();

                //Valida si el usuario esta registrado en la base de datos
                if(cuenta == textUsuario.Text.Trim() && contrasena == textPassword.Text.Trim())
                {
                    MessageBox.Show("Inicio de sesion exitoso");

                    //Valida si el usuario tiene derechos de administrador o solo de usuario 
                    if (Convert.ToBoolean(conectar.Tables[0].Rows[0]["validar_admin"].ToString().Trim()) == true)
                    {
                        Administrador Admin = new Administrador();
                        this.Hide();//cierra la ventana de login 
                        Admin.Show(); //muestra la ventana de usuario
                    }
                    else
                    {
                        Usuario User = new Usuario();
                        this.Hide();
                        User.Show();
                    }
                    
                }
            }
            //En caso de que no este en la base de datos
            catch (Exception error)
            {
                MessageBox.Show("Usuario no encontrado" + error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
