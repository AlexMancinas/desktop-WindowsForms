using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BD.Conexion();
            MessageBox.Show("Se ha conectado correctamente");

            dataGridView1.DataSource = Consulta();
        }

        public DataTable Consulta()
        {
            BD.Conexion();
            DataTable datos = new DataTable();
            string consultar = "SELECT * FROM Empleados"; 
            SqlCommand cmd = new SqlCommand(consultar, BD.Conexion());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);
            return datos;   

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            BD.Conexion();
            string insertar = "INSERT INTO Empleados(codigo,nombre,apellido,direccion) VALUES (@codigo,@nombre,@apellido,@direccion) ";
            SqlCommand insert = new SqlCommand(insertar, BD.Conexion());
            insert.Parameters.AddWithValue("@codigo",textCodigo);
            insert.Parameters.AddWithValue("@nombre", textNombre);
            insert.Parameters.AddWithValue("@apellido", textApellido);
            insert.Parameters.AddWithValue("@direccion", textDireccion);

            insert.ExecuteNonQuery();

            MessageBox.Show("Se cargo el empleado");
            dataGridView1.DataSource = Consulta();
        }
    }
}
