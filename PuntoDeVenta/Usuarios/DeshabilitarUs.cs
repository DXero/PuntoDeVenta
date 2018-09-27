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
    }
}
