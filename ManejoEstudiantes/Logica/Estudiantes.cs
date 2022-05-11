using Logica.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Estudiantes : Library
    {
        private List<TextBox> listTextBox;

        public Estudiantes(List<TextBox> listTextBox)
        {
            this.listTextBox = listTextBox;
        }
    }
}
