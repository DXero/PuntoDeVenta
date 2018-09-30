using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta.ModelDB;

namespace PuntoDeVenta.Usuarios
{
    public partial class UsModificar : Form
    {
           
        public UsModificar()
        {
            InitializeComponent();

        }

        private void UsModificar_Load(object sender, EventArgs e)
        {
            TextUs.Text = StaticValue.us.ToString();
            
            var mdf = new ModelDB.Contexto();
            var us = new ModelDB.Usuarios();
            us = mdf.Usuarios.Where(id => id.Us_Usuario == StaticValue.us).First();
            TextNombre.Text = us.Us_Nombre.ToString();
            TextApellido.Text = us.Us_Apellido.ToString();
            TextTelefono.Text = us.Us_Telefono.ToString();
            TextCorreo.Text = us.Us_Correo.ToString();
            TextDui.Text = us.Us_DUI.ToString();


        }
            

        private void button1_Click(object sender, EventArgs e) //btn actualizar;
        {
            var us = new ModelDB.Usuarios();
            var mdf = new ModelDB.Contexto();
            if (TextUs.Text != "" && TextNombre.Text != "" && TextApellido.Text != "" && TextTelefono.Text != "" && TextCorreo.Text != "" && TextDui.Text != "")
            {
                us.Us_Usuario = TextUs.Text;
                us.Us_Nombre = TextNombre.Text;
                us.Us_Apellido = TextApellido.Text;
                us.Us_Telefono = Convert.ToInt32(TextTelefono.Text);
                us.Us_Correo = TextCorreo.Text;
                us.Us_DUI = Convert.ToInt32(TextDui.Text);

                mdf.SaveChanges();
                MessageBox.Show("Usuario Modificado");
                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
