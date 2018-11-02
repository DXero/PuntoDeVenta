using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Ventas
{
    public partial class Agregar_venta : Form
    {
        public Agregar_venta()
        {
            InitializeComponent();
            //comboBox2.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
            //if (no.Checked == true)
            //{
            //    Si.Checked = false;
            //    comboBox2.Enabled = false;
            //}
        }

        private void Si_CheckedChanged(object sender, EventArgs e)
        {
            //if (Si.Checked == true)
            //{
            //    no.Checked = false;
            //    comboBox2.Enabled = true;
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
             
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!textBox2.Text.Contains(".")))
            {
                
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
            }
        }
    }
}
