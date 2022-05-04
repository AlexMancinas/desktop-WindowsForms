using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        XmlSerializer xs;
        List<Employees> le;
        public Form1()
        {
            InitializeComponent();

            le = new List<Employees>();

            xs = new XmlSerializer(typeof(List<Employees>));
        }

        //Metodo para almacenar datos en access
        private void CreateEmp()
        {
            var conString = ConfigurationManager.ConnectionStrings["Employees"].ConnectionString;
            OleDbConnection Conector = new OleDbConnection(conString);
            try
            {
                
                Conector.Open();
               
                string Insert = @"INSERT Into Employees(Employee_ID,LastName,FirstName,DateOfBirth)
                                                  values(@Employee_ID,@LastName,@FirstName,@DateOfBirth)";
                OleDbCommand cmd = new OleDbCommand(Insert,Conector);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@Employee_ID",txtEmployeeID.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text.Trim());
                if (cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Empleado guardado");
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Error al subir archivo"+error);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //llamamos metodo para almacenar en access
            CreateEmp();
            
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CreateTxtFile_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\MANCINAS\source\repos\WindowsFormsApp5\Output_PipeDelimited.txt", true);
            streamWriter.WriteLine(txtEmployeeID.Text+"|"+txtLastName.Text+"|"+txtFirstName.Text+"|"+txtDateOfBirth.Text);
            streamWriter.Close();

        }

        private void CreateXMLFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:/Users/MANCINAS/source/repos/WindowsFormsApp5/Output_XML.xml", FileMode.Create,FileAccess.Write);
            Employees employeesClass = new Employees();
            employeesClass.Employee_ID = int.Parse(txtEmployeeID.Text);
            employeesClass.LastName = txtLastName.Text;
            employeesClass.FirstName = txtFirstName.Text;
            employeesClass.DateOfBirth = txtDateOfBirth.Text;

            le.Add(employeesClass);

            xs.Serialize(fs, le);
            fs.Close();
        }
    }
}
