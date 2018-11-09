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
    public partial class Agregar_venta : Form
    {
        private int SPvalue = 1;
        private double descuento = 0;

        private List<int> ListaExistencias = new List<int>(); 
        private List<string[]> ListaVentas = new List<string[]>();
        private List<CLIENTES> ListaClientes = new List<CLIENTES>();
        private List<PRODUCTOS> ListaProductos = new List<PRODUCTOS>();
        private int indexcmb = 0;
        public Agregar_venta()
        {
            InitializeComponent();
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
            //if (no.Checked == true)
            //{
            //    Si.Checked = false;
            //    comboBox2.Enabled = false;
            //}
        }

        private void Si_CheckedChanged(object sender, EventArgs e)
        {
            //if (Si.Checked == true)
            //{
            //    no.Checked = false;
            //    comboBox2.Enabled = true;
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!TxtPrecioProd.Text.Contains(".")))
            {
                
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
            }
        }
        private void ProductoDetalle()
        {
            var producto = new Contexto().PRODUCTOS.Where(st => st.descripcion == CmbProducto.SelectedItem.ToString()).First();
            if (producto.DESCUENTOS.descuento > 0)
                descuento = Convert.ToDouble(producto.precio) * (Convert.ToDouble(producto.DESCUENTOS.descuento) / 100);
            TxtPrecioProd.Text = (producto.precio - descuento).ToString();
            ListaExistencias[CmbProducto.SelectedIndex] = Convert.ToInt32(producto.existencia);
            TxtExistencias.Text = ListaExistencias[CmbProducto.SelectedIndex].ToString();
            SpCantidad.Maximum = Convert.ToDecimal(ListaExistencias[CmbProducto.SelectedIndex]); SPvalue = 0; SpCantidad.Value = 1;
        }

    
        private void Agregar_venta_Load(object sender, EventArgs e)
        {
            foreach (var producto in new Contexto().PRODUCTOS.Where(st => st.existencia > 1).ToList())
            {
                ListaProductos.Add(producto); ListaExistencias.Add((int)producto.existencia);
                CmbProducto.Items.Add(producto.descripcion);
            }
            foreach (var cliente in new Contexto().CLIENTES.ToList())
            {
                ListaClientes.Add(cliente);
                CmbCliente.Items.Add(cliente.nombres + " " + cliente.apellidos);
            }
            CmbProducto.SelectedIndex = 0; ProductoDetalle();     
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbProducto.SelectedIndex != indexcmb) { ProductoDetalle(); }
            indexcmb = CmbProducto.SelectedIndex;
        }

        private void SpCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (SpCantidad.Value < SPvalue)
                SPvalue--;
            else SPvalue++;
            TxtExistencias.Text = (ListaExistencias[CmbProducto.SelectedIndex] - SpCantidad.Value).ToString();
        }

        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbProducto.Text != "")
                {
                    if (CmbCliente.Text != "")
                    {
                        if (ListaExistencias[CmbProducto.SelectedIndex] > 0 && SpCantidad.Value > 0 && SpCantidad.Value <= ListaExistencias[CmbProducto.SelectedIndex])
                        {
                        bool Existe = false;
                        TablaDetallle.Rows.Clear();
                        string[] Venta = { CmbCliente.SelectedItem.ToString(), CmbProducto.SelectedItem.ToString(), SpCantidad.Value.ToString(), TxtPrecioProd.Text, (Convert.ToDouble(SpCantidad.Value) * double.Parse(TxtPrecioProd.Text)).ToString() };
                            foreach (var detalle in ListaVentas)
                            if (Venta[0] == detalle[0] && Venta[1] == detalle[1])
                                {
                                   detalle[2] = (int.Parse(detalle[2]) + int.Parse(Venta[2])).ToString();
                                   detalle[4]  = (double.Parse(detalle[2])  * double.Parse(TxtPrecioProd.Text)).ToString(); Existe = true;
                                }
                            if(Existe == false) ListaVentas.Add(Venta);
                        foreach (var item in ListaVentas)
                         TablaDetallle.Rows.Add(item);
                        ListaExistencias[CmbProducto.SelectedIndex] = ListaExistencias[CmbProducto.SelectedIndex] - SPvalue;
                        TxtExistencias.Text = ListaExistencias[CmbProducto.SelectedIndex].ToString();
                         SpCantidad.Value = 1; SPvalue = 1;
                        SpCantidad.Maximum = Convert.ToDecimal(ListaExistencias[CmbProducto.SelectedIndex]);
                        }else MessageBox.Show("ya no quedan existencias de este producto, o quiza no esta asiganado una cantidad correcta");
                    }
                    else MessageBox.Show("Debe seleccionar un Cliente/Comprador para realizar esta accion");
                }
                else MessageBox.Show("Debe seleccionar un producto para realizar esta accion");
            }catch(Exception ex)
            {
                MessageBox.Show("Faltan campos que llenar");
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TablaDetallle.Rows.Count > 0)
            {
                TablaDetallle.Sort(TablaDetallle.Columns[0], ListSortDirection.Ascending);
                VENTA aux = new VENTA();
                var Registrar = new Contexto();
                var Comprador = TablaDetallle.Rows[0].Cells[0].Value.ToString();
                aux = new VENTA() { idUsuario = Usuarios.StaticValue.us, fecha = DateTime.Now.ToString("dd/MM/yyyy"), hora = DateTime.Now.ToString("hh:mm:ss"), idCliente = int.Parse(ListaClientes[CmbCliente.Items.IndexOf(TablaDetallle.Rows[0].Cells[0].Value)].id.ToString()), motivo = "" };
                Registrar.VENTAS.Add(aux);
                foreach (DataGridViewRow row in TablaDetallle.Rows)
                {
                    if (Comprador != row.Cells[0].Value.ToString())
                    {
                        aux = new VENTA() { idUsuario = Usuarios.StaticValue.us, fecha = DateTime.Now.ToString("dd/MM/yyyy"), hora = DateTime.Now.ToString("hh:mm:ss"), idCliente = int.Parse(ListaClientes[CmbCliente.Items.IndexOf(row.Cells[0].Value)].id.ToString()), motivo = "" };
                        Registrar.VENTAS.Add(aux);
                        Comprador = row.Cells[0].Value.ToString();
                    }
                    var prod = row.Cells[1].Value.ToString();
                    Registrar.DETALLEVENTAS.Add(new DETALLEVENTA()
                    {
                        VENTA = aux,// Cambio
                        Cantidad = int.Parse(row.Cells[2].Value.ToString()),
                        idProducto = Convert.ToInt32(new Contexto().PRODUCTOS.Where(st => st.descripcion == prod).First().idProductos.ToString()),
                        precio = float.Parse(row.Cells[3].Value.ToString()),
                        IdDescuento = Convert.ToInt32(new Contexto().PRODUCTOS.Where(st => st.descripcion == prod).First().idDescuentos.ToString())
                    });
                    var RestarExistencia = Registrar.PRODUCTOS.Where(st => st.descripcion == prod).First();
                    RestarExistencia.existencia -= int.Parse(row.Cells[2].Value.ToString());
                    // Cambio
                    ProductoDetalle();
                }
                if(Registrar.SaveChanges() > 0)// Cambio
                    MessageBox.Show("Las ventas fueron registradas");// Cambio
                else// Cambio
                    MessageBox.Show("Hubo un problema");// Cambio
            }
            else MessageBox.Show("No hay ventas por registrar");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaDetallle.SelectedRows.Count > 0)
            {
                var index = TablaDetallle.SelectedRows[0].Index;
                ListaExistencias[CmbProducto.Items.IndexOf(TablaDetallle.SelectedRows[0].Cells[1].Value.ToString())] += int.Parse(TablaDetallle.SelectedRows[0].Cells[2].Value.ToString());
                SpCantidad.Maximum = Convert.ToDecimal(ListaExistencias[CmbProducto.SelectedIndex]); TxtExistencias.Text = ListaExistencias[CmbProducto.SelectedIndex].ToString();
                TablaDetallle.Rows.RemoveAt(index); ListaVentas.RemoveAt(index); SPvalue = Convert.ToInt32(SpCantidad.Value);
            }else if(TablaDetallle.Rows.Count == 0)
                MessageBox.Show("no hay detalles de venta por borrar");
            else
                MessageBox.Show("no a seleccionado ningun detalle de venta para borrar");
        }
    }
}
