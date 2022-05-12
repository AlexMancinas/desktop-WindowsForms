using Data;
using LinqToDB;
using Logica.library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Estudiantes 
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;
        private Library library;
        private Upload_image upload_Image;

        public Estudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            library= new Library();
            image = (PictureBox)objetos[0];
            upload_Image = new Upload_image();
        }

        //Validaciones para que no permita campos vacios
        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "El No. ID es requerido";
                listLabel[0].ForeColor = Color.Red;
                listLabel[0].Focus();
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "El Nombre es requerido";
                    listLabel[1].ForeColor = Color.Red;
                    listLabel[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "El Apellido es requerido";
                        listLabel[2].ForeColor = Color.Red;
                        listLabel[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "El Email es requerido";
                            listLabel[3].ForeColor = Color.Red;
                            listLabel[3].Focus();
                        }
                        else
                        {
                            if (library.textBoxEvent.comprobarFormatoEmail(listTextBox[3].Text))
                            {
                               var imageArray = library.upload_Image.ImageToByte(image.Image);
                                using (var db = new Conexion())
                                {
                                    db.Insert(new Estudiante()
                                    {
                                        nid = listTextBox[0].Text,
                                        nombre = listTextBox[1].Text,
                                        apellido = listTextBox[2].Text,
                                        email = listTextBox[3].Text,
                                    });
                                }
                                
                            }
                            else
                            {
                                listLabel[3].Text = "Email no valido";
                                listLabel[3].ForeColor = Color.Red;
                                listLabel[3].Focus();
                            }
                        }
                    }
                }
            }
            
        }
    }
}
