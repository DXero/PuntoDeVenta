using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Proveedores
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void txt_NomEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NomEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
                return;
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
                return;
            }
        }

        private void txt_Contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
                return;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_NomEmpresa.Text != "" && txt_Telefono.Text != "" && txt_Contacto.Text != "" && txt_Correo.Text != "")
            {
                //Aqui va la consulta del boton.
            }
            else MessageBox.Show("Faltan campos por llenar");

        }

       
        

       
        
    }
}
