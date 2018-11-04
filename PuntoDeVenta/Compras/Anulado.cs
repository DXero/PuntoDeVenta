using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Compras
{
    public partial class Anulado : Form
    {
        public Anulado()
        {
            InitializeComponent();
        }

        private void textMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] NoPermitir = { 'é', 'ý', 'ú', 'í', 'ñ', 'ó', 'á', 'ë', 'ÿ', 'ü', 'ï', 'ö', 'ä', 'ê', 'û', 'î', 'ô', 'â', '-', '_', '^', '[', ']', '{', '}', '/' };
            char[] Permitir = { '$', '%', '.', ',' };

            //Validamos si el carácter es un valor permitido, si es falso entramos
            if (!Permitir.Contains(e.KeyChar))
            {
                //Validamos que el valor sea un carácter no permitido
                if (NoPermitir.Contains(e.KeyChar))
                {
                    MessageBox.Show("Carácter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                else
                {
                    //Si no es un carácter no permitido validamos que sea letra y numero o la tecla back
                    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
                    {
                        MessageBox.Show("Solo se permiten letras y números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textMotivo.Text != "" )
            {
          

            }
                else MessageBox.Show("Faltan campos por llenar");
            
        }
    }
}
