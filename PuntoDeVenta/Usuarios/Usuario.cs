using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Usuarios
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void TextNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
                return;
            }

        }

        private void TextApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
               e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
                return;
            }
            
        }

        private void TextDui_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
                return;
            }
        }

        private void TextDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextNombre.Text != "" && TextApellido.Text != "" && TextDui.Text != "" && TextTelefono.Text != "")
            {
                var add = new ModelDB.Contexto();
                var us = new ModelDB.Usuarios();
                us.Us_Usuario = "luis2018";
                us.Us_Nombre = TextNombre.Text;
                us.Us_Apellido = TextApellido.Text;
                us.Us_Correo = TextCorreo.Text;
                us.Us_Telefono = Convert.ToInt32(TextTelefono.Text);
                us.Us_DUI = Convert.ToInt32(TextDui.Text);
                us.Us_Estado = true;
                add.Usuarios.Add(us);
                add.SaveChanges(); MessageBox.Show("Usuario guardado");

            }
            else MessageBox.Show("Faltan campos por llenar");
        }

        private void TextNombre_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
