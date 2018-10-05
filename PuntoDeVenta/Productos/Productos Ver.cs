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
        }
        private void ActualizarTabla()
        {
            using (var context = new ModelVista())
            {
                dataGridView2.DataSource = context.VistaProductos.ToList();
            }
        }
        private void Productos_Ver_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            new Producto_Nuevo().ShowDialog();
            ActualizarTabla();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                new Producto_Modificar(int.Parse(row.Cells[0].Value.ToString())).ShowDialog();
            ActualizarTabla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
