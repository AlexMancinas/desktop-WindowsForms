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
    public class Estudiantes : Library
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;

        public Estudiantes(List<TextBox> listTextBox, List<Label> listLabel)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
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
                      
                    }
                }
            }
        }
    }
}
