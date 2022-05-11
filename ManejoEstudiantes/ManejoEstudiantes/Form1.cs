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
            InitializeComponent();
            var listTextBox = new List<TextBox>();  
            listTextBox.Add(textBoxId);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxEmail);
            estudiante = new Estudiantes(listTextBox);

        }

        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {
            estudiante.upload_Image.CargarImagen(pictureBoxImagen);
        }

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

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBoxId.Text.Length < 8)
            {
                estudiante.textBoxEvent.numberKeyPress(e);
            }
            else
            {
                MessageBox.Show("Maximo de 8 numeros");
                e.Handled = true;
            }
        }

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

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

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

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

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

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
