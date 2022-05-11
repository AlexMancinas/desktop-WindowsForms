using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condicion que solo nos permite ingresar datos de tipo texto 
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //Condicion que permite no dar salto de linea cuanto se oprima enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            //Condicion que nos permite la tecla backspace 
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled= false;
            }
            //Condicion que nos permite la tecla space 
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
