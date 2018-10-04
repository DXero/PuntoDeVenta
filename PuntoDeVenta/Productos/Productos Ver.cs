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

namespace PuntoDeVenta.Productos
{
    public partial class Productos_Ver : Form
    {
        public Productos_Ver()
        {
            InitializeComponent();

            using(var context = new ModelVista())
            {
                dataGridView1.DataSource = context.VistaProductos.ToList();
            }

        }

        private void Productos_Ver_Load(object sender, EventArgs e)
        {

        }

        private void Productos_Ver_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet41.CPROD' Puede moverla o quitarla según sea necesario.
            this.cPRODTableAdapter.Fill(this.sistemaDataSet41.CPROD);
        }
    }
}
