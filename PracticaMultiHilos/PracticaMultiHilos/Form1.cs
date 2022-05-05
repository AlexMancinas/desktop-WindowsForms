using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PracticaMultiHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread hilo;
        delegate void delegado(int valor);

        private void btnSalair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            hilo = new Thread(new ThreadStart(Proceso1));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso2));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso3));
            hilo.Start();
        }

        public void Proceso1()
        {

            for (int i = 0; i <= 100; i++)
            {
                delegado md = new delegado(actualizar1);
                this.Invoke(md, new object[] { i });
                Thread.Sleep(70);
            }
        }
        public void actualizar1(int valor)
        {
            progressBar1.Value = valor;
        }
        public void Proceso2()
        {
            for (int i = 0; i <= 100; i++)
            {
                delegado md = new delegado(actualizar2);
                this.Invoke(md, new object[] { i });
                Thread.Sleep(100);
            }
        }
        public void actualizar2(int valor)
        {
            progressBar2.Value = valor;
        }

        public void Proceso3()
        {
            for (int i = 0; i <= 100; i++)
            {
                delegado md = new delegado(actualizar3);
                this.Invoke(md, new object[] { i });
                Thread.Sleep(50);
            }
        }
        public void actualizar3(int valor)
        {
            progressBar3.Value = valor;
        }
    }
}
