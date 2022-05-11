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
        private Estudiantes estudiante = new Estudiantes();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {
            estudiante.CargarImagen(pictureBoxImagen);
        }
    }
}
