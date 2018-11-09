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

namespace PuntoDeVenta.Ventas
{
    public partial class AnularVenta : Form
    {
        public AnularVenta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = int.Parse(comboBox1.Text);
            foreach (var venta in new Contexto().VENTAS.Where(st => st.IdVenta == a).ToList())
            {
                foreach(var detalle in venta.DETALLEVENTAS.ToList())
                {
                    string[] row = { detalle.VENTA.CLIENTE.nombres.ToString(), detalle.PRODUCTO.descripcion, detalle.Cantidad.ToString(), ((double)detalle.precio * detalle.Cantidad).ToString() };
                    TablaDetalle.Rows.Add(row);
                }
                
            }

                
            
        }

        private void AnularVenta_Load(object sender, EventArgs e)
        {
            foreach (var venta in new Contexto().VENTAS.ToList())
                comboBox1.Items.Add(venta.IdVenta.ToString());
        }
    }
}
