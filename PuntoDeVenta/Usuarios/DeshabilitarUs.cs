using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Usuarios
{
    public partial class DeshabilitarUs : Form
    {
        public DeshabilitarUs()
        {
            InitializeComponent();
        }

        private void DeshabilitarUs_Load(object sender, EventArgs e)
        {
            textBox1.Text = StaticValue.us.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var us = new ModelDB.Usuarios();
            var mdf = new ModelDB.Contexto();

            if (MessageBox.Show("Esta seguro que desea deshabilitar este usuario", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                us = mdf.Usuarios.Where(id => id.Us_Usuario == StaticValue.us).First();
                us.Us_Estado = false;

                if (mdf.SaveChanges() > 0){MessageBox.Show("El usuario se deshabilitó correctamente"); Close(); }
                }

            }
    }
}
