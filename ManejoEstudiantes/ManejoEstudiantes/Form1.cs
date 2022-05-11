using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoEstudiantes
{
    public partial class Form1 : Form
    {
        private Estudiantes estudiante ;
        public Form1()
        {
            //crear una lista con los textBox
            InitializeComponent();
            var listTextBox = new List<TextBox>();  
            listTextBox.Add(textBoxId);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxEmail);
            //Crear una lista con los Label
            var listLabel = new List<Label>();
            listLabel.Add(label_id);
            listLabel.Add(label_nombre);
            listLabel.Add(label_apellido);
            listLabel.Add(label_email);
            
            estudiante = new Estudiantes(listTextBox,listLabel);

        }
        //PICTUREBOX FOTO ESTUDIANTE
        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {
            estudiante.upload_Image.CargarImagen(pictureBoxImagen);
        }


        //TEXTBOX ID
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.Text.Equals(""))
            {
                label_id.ForeColor = Color.LightSlateGray;
            }

            else
            {
                label_id.ForeColor = Color.Green;
                //label_id.Text = "No. ID";

            }
        }
        //TEXTBOX ID
        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBoxId.Text.Length < 8)
            {
                estudiante.textBoxEvent.numberKeyPress(e);
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Maximo de 8 numeros");
                e.Handled = true;
            }
        }


        //TEXTBOX NOMBRE
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                label_nombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_nombre.ForeColor= Color.Green;
            }
        }
        //TEXTBOX NOMBRE
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }


        //TEXTBOX APELLIDO
        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellido.Text.Equals(""))
            {
                label_apellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_apellido.ForeColor = Color.Green;
            }
        }
        //TEXTBOX APELLIDO
        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }


        //TEXTBOX EMAIL
        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                label_email.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_email.ForeColor = Color.Green;
            }
        }

        
        //BTN AGREGAR O CARGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar();
        }
    }
}
