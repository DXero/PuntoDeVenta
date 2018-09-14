using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Clientes
{
    public partial class cliente_form : Form
    {
        public cliente_form()
        {
            InitializeComponent();   
        }
        bool validacion = true;
        //**********************Validacion solo letras************************
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        //**********************Validacion solo numeros************************
        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textoFechaDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textFechaMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textoFechaYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }




        private void textTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            validacion = true;
            //***********
            if(textNombre.Text == "" || textApellidos.Text == "" ){MessageBox.Show("Los campos 'Nombres' y 'Apellidos' son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false;}
                if (textTelefono.Text != "" && textTelefono.Text.Length != 8) { MessageBox.Show("el campo 'Telefono' debe contener 8 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
                if (textNit.Text != "" && textNit.Text.Length != 14) { MessageBox.Show("el campo 'NIT' debe contener 14 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
                if (textDui.Text != "" && textDui.Text.Length != 9) { MessageBox.Show("el campo 'DUI' debe contener 9 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
                if((textoFechaDia.Text != "" && textoFechaDia.Text.Length != 2) || (textFechaMes.Text != "" && textFechaMes.Text.Length != 2) || (textoFechaYear.Text != "" && textoFechaYear.Text.Length != 4))
                     {MessageBox.Show("El formato de fecha es Dia-Mes-Año", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false;}
               if((textoFechaDia.Text != "" && Int32.Parse(textoFechaDia.Text)>12) || (textFechaMes.Text != "" && Int32.Parse(textFechaMes.Text) > 12) || ((textoFechaYear.Text != "" && Int32.Parse(textoFechaYear.Text) >2010) || (textFechaMes.Text != "" && Int32.Parse(textFechaMes.Text) <1930)))
            { { MessageBox.Show("La fecha ingresada no es valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; } }
                //***********
            if (validacion != false)
            {
                //************* AQUI VA EL CODIGO *****************
                //************* AQUI VA EL CODIGO *****************
                //************* AQUI VA EL CODIGO *****************
                //************* AQUI VA EL CODIGO *****************
            }
        }

        private void textoFechaDia_TextChanged(object sender, EventArgs e)
        {
            if(textoFechaDia.Text.Length == 2)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textFechaMes_TextChanged(object sender, EventArgs e)
        {
            if (textFechaMes.Text.Length == 2)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textoFechaYear_TextChanged(object sender, EventArgs e)
        {
            if (textoFechaYear.Text.Length == 4)
            {
                SendKeys.Send("{TAB}");
            }
        }

       
    }
}
