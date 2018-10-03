using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuntoDeVenta.Compras
{
    public partial class FormularioCompras : Form
    {
        public FormularioCompras()
        {
            InitializeComponent();
        }
        bool validacion = true;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormularioCompras_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void FechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textoFechaDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textFechaMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textoFechaYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            validacion = true;
            //***********
            if (cbxProveedor.Text == "") { MessageBox.Show("Se debe de especificar el 'Proveedor'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
            //termina validacion de campos solos
            if (validacion != false)
            { 
                    //Codigo Aqui
            }
    }

        private void txtComentario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            validacion = true;
            if (txtCodProducto.Text == "") { MessageBox.Show("El campo 'Codigo del Producto' es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
            if (txtCosto.Text == "") { MessageBox.Show("el campo 'Costo' es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
            if (txtCantidad.Text == "") { MessageBox.Show("el campo 'Cantidad' es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
            //Termina Validacion de campos solos
            if (validacion != false)
            {
                //Codigo Aqui
            }
        }
    }
}
