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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            //verificar quien es el usuario que inicio sesion y mostrartlo en el label 'VENDEDOR' 
            string vendedor = "Select * from Usuarios where id_usuario = " + Login.Codigo;
            DataSet ds;
            ds = Biblioteca.Herramientas(vendedor);

            lbVendedor.Text = ds.Tables[0].Rows[0]["username"].ToString().Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Manda llamar el nombre del cliente identficado por el codigo 
                if (string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()) == false)
                {
                    string cmd = string.Format("Select Nombre_cliente from Clientes where id_cliente = '{0}'", txtCodigoCliente.Text.Trim());
                    DataSet ds = Biblioteca.Herramientas(cmd);

                    txtCliente.Text = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString().Trim();

                    TxtCodigoProducto.Focus();
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        public static int contadorFila = 0;
        public static double total;
        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Biblioteca.ValidarFormulario(this,errorProvider1) == false)
            {
                bool existe = false;
                int numeroFila = 0;

                if(contadorFila == 0)
                {
                    dataGridView1.Rows.Add(TxtCodigoProducto.Text, txtDescripcionProd.Text,txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                    contadorFila++;
                    
                    
                }
                else
                {
                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if(Fila.Cells[0].Value.ToString() == TxtCodigoProducto.Text)
                        {
                            existe = true;
                            numeroFila = Fila.Index;
                                
                        }
                       
                    }
                    if (existe == true)
                    {
                        dataGridView1.Rows[numeroFila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value);
                        dataGridView1.Rows[numeroFila].Cells[4].Value = importe;


                    }
                    else
                    {
                        
                            dataGridView1.Rows.Add(TxtCodigoProducto.Text, txtDescripcionProd.Text, txtPrecio.Text, txtCantidad.Text);
                            double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                            dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                            contadorFila++;
                       


                    }
                }
              

            }
            total = 0;
            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                
                total += Convert.ToDouble(Fila.Cells[4].Value);

                
            }
            lbTotal.Text = "USD$ " + total.ToString(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if(contadorFila > 0)
            {
                //Seccion para solo eliminar la fila que se esta seleccionando y la autosuma se muestre 
                //sin el elemento que se eliminó
                total -= Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                lbTotal.Text  = "USD$ "+total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                contadorFila--;
            }
        }
    }
}
