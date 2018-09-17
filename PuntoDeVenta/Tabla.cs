using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Tabla : Form
    {
        public Tabla()
        {
            InitializeComponent();
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDataSet.PROVEEDORES' table. You can move, or remove it, as needed.
            this.pROVEEDORESTableAdapter.Fill(this.sistemaDataSet.PROVEEDORES);

        }
    }
}
