using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarConf_Click(object sender, EventArgs e)
        {
            if (rbElestar.Checked)
            {
                listBoxConfGuard.Items.Add(rbElestar.Text);
            }
            else if (rbEptium.Checked)
            {
                listBoxConfGuard.Items.Add(rbEptium.Text);
            }
            else if (rbMDA.Checked)
            {
                listBoxConfGuard.Items.Add(rbMDA.Text);
            }
            else if (rbSXM.Checked)
            {
                listBoxConfGuard.Items.Add(rbSXM.Text);
            }
            if (rb512Gb.Checked)
            {
                listBoxConfGuard.Items.Add(rb512Gb.Text);
            }
            else if (rb4TB.Checked)
            {
                listBoxConfGuard.Items.Add(rb4TB.Text);
            }
            else if (rb1tb.Checked)
            {
                listBoxConfGuard.Items.Add(rb1tb.Text);
            }
            else if (rb16tb.Checked)
            {
                listBoxConfGuard.Items.Add(rb16tb.Text);
            }
            int indice = checkedListBoxOtrosDisp.SelectedIndex;
            if( indice != -1)
            {
                if(checkedListBoxOtrosDisp.GetItemChecked(indice) == true)
                {
                    listBoxConfGuard.Items.Add(checkedListBoxOtrosDisp.Items[indice].ToString());
                }
            }
            if (checkBoxCont.Checked == true)
            {
                listBoxConfGuard.Items.Add(checkBoxCont.Text);
            }
            else if (checkBoxGrabador.Checked == true)
            {
                listBoxConfGuard.Items.Add(checkBoxGrabador.Text);
            }
            listBoxConfGuard.Items.Add(comboBox1.Text);
        }
    }
}
