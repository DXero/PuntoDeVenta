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
    public partial class Producto_Nuevo : Form
    {
        public Producto_Nuevo()
        {
            InitializeComponent();
            foreach(var a in new Contexto().CATEGORIA.ToList())
            cb_Categoria.Items.Add(a.descripcion);
            foreach (var a in new Contexto().DESCUENTOS.ToList())
                cb_Descuento.Items.Add(a.descripcion);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] NoPermitir = { 'é', 'ý', 'ú', 'í', 'ñ', 'ó', 'á', 'ë', 'ÿ', 'ü', 'ï', 'ö', 'ä', 'ê', 'û', 'î', 'ô', 'â' };
            char[] Permitir = { '-', '_' };

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras y números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
        
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txt_Precio.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txt_Costo.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(txt_Codigo.Text.Length > 0 && txt_Costo.Text.Length > 0 && txt_Descripcion.Text.Length > 0 && txt_Precio.Text.Length > 0 && cb_Descuento.Text.Length > 0 && cb_Categoria.Text.Length > 0)
            {
                var Guardar = new Contexto();
                Guardar.PRODUCTOS.Add(new PRODUCTOS() { codigoBarra = txt_Codigo.Text, activo = ck_activo.Checked, descripcion = txt_Descripcion.Text,
                precio = int.Parse(txt_Precio.Text), costo = int.Parse(txt_Costo.Text),
                idCategoria = new Contexto().CATEGORIA.Where(st => st.descripcion == cb_Categoria.SelectedItem.ToString()).First().idCategoria,
                idDescuentos = new Contexto().DESCUENTOS.Where(st => st.descripcion == cb_Descuento.SelectedItem.ToString()).First().idDescuento
            });
                Guardar.SaveChanges();Close();
               
        }
        }
    }
}
