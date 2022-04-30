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

        //Variables a utilizar para el los contadores
        public static int contadorFila = 0;
        public static double total;
        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Biblioteca.ValidarFormulario(this,errorProvider1) == false)
            {
                bool existe = false;
                int numeroFila = 0;

                //Si aun no se llena nada, hace el primer registro de la tabla
                if(contadorFila == 0)
                {
                    dataGridView1.Rows.Add(TxtCodigoProducto.Text, txtDescripcionProd.Text,txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                    contadorFila++;
                    
                    
                }
                else
                {
                    //Revisa si ya existe el prodcuto que se quiere ingresar
                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if(Fila.Cells[0].Value.ToString() == TxtCodigoProducto.Text)
                        {
                            existe = true;
                            numeroFila = Fila.Index;
                                
                        }
                       
                    }
                    //Suma los productos si la estan en las lista y le aumenta mas
                    if (existe == true)
                    {
                        dataGridView1.Rows[numeroFila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value);
                        dataGridView1.Rows[numeroFila].Cells[4].Value = importe;


                    }
                    //Coloca nuevos productos ingresados en la siguiente fila
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
            //lee todas las celdas para hacer la suma
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
        //Mandar llamar la ventana ConsultarCLientes para seleccionar el cliente al que se le va a facturar
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ConsultarCliente ConsulClien = new ConsultarCliente();
            ConsulClien.ShowDialog();

            if(ConsulClien.DialogResult == DialogResult.OK)
            {
                txtCodigoCliente.Text = ConsulClien.dataGridView1.Rows[ConsulClien.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = ConsulClien.dataGridView1.Rows[ConsulClien.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                TxtCodigoProducto.Focus();
            }
        }
        //Mandar llamar la ventana de ConsultarProductos para seleccionar los productos necesarios
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConsulPro = new ConsultarProductos();
            ConsulPro.ShowDialog();
            if(ConsulPro.DialogResult == DialogResult.OK)
            {
                TxtCodigoProducto.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcionProd.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                txtCantidad.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        //Borrar todo y te vuelve a dejar el selector en el CODIGO DEL CLIENTE
        public override void Nuevo()
        {
            txtCodigoCliente.Text = "";
            txtCliente.Text = "";
            txtDescripcionProd.Text = "";
            txtDescripcionProd.Text = "";
            txtCantidad.Text = "";
            lbTotal.Text = "USD$ 0";
            dataGridView1.Rows.Clear();

            contadorFila = 0;
            total = 0;
            txtCodigoCliente.Focus();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            
            if (contadorFila != 0)
            {
                try 
                {
                    string cmd = string.Format("Exec ActualizarFacturas '{0}'",txtCodigoCliente.Text.Trim());
                    DataSet DS = Biblioteca.Herramientas(cmd);

                    string Numerofactura = DS.Tables[0].Rows[0]["NumeroFactura"].ToString().Trim();

                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        cmd = String.Format("Exec ActualizarDetalles '{0}','{1}','{2}','{3}'",Numerofactura,Fila.Cells[0].Value.ToString(),Fila.Cells[2].Value.ToString(),Fila.Cells[3].Value.ToString());
                        DS = Biblioteca.Herramientas(cmd);
                    }
                    cmd = ("Exec DatosFactura " + Numerofactura);
                    DS=Biblioteca.Herramientas(cmd);

                    Factura fac = new Factura();
                    fac.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                    fac.ShowDialog();

                    Nuevo();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error);
                }
            }
        }
    }
}
