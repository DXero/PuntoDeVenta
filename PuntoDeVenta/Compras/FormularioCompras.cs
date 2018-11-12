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
using System.Transactions;
namespace PuntoDeVenta.Compras
{
    public partial class FormularioCompras : Form
    {
        DataTable objeto = new DataTable();
        public FormularioCompras()
        {
            InitializeComponent();
            // aqui se definen las columnas que tendra el gribview 
            objeto.Columns.Add("codigo");
            objeto.Columns.Add("costo");
            objeto.Columns.Add("cantida");
            objeto.Columns.Add("descuento");
            objeto.Columns.Add("fechaVencimiento");
            // aqui se llenan los combobox  y se detalla que es lo que vera el usuario y lo que 
            //  se evaluara al seleccionar en el combobox
            //using (var datos = new sistemaDataSet3())
            //{

            //    cbxProveedor.DataSource = datos.PROVEEDORES.Select(c => new { c.id, c.nombreEmpresa }).ToList();
                
            //}
            //cbxProveedor.DisplayMember= "nombreEmpresa";
            //cbxProveedor.ValueMember = "id";

            using (var db = new ModelDB.Contexto())
            {
                cbxProveedor.DataSource = db.PROVEEDORES.Select(x => new { x.id, x.nombreEmpresa }).ToList();
                cbdescuento.DataSource = db.DESCUENTOS.Select(x => new { x.idDescuento, x.descuento }).ToList();
                cbcodigoProducto.DataSource = db.PRODUCTOS.Select(x => new { x.idProductos, x.codigoBarra }).ToList();

            }
            cbxProveedor.DisplayMember = "nombreEmpresa";
            cbxProveedor.ValueMember = "id";

            cbdescuento.DisplayMember = "descuento";
            cbdescuento.ValueMember = "idDescuento";

            cbcodigoProducto.DisplayMember = "codigoBarra";
            cbcodigoProducto.ValueMember = "idProductos";
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
                // utilizacion de una transacion para poder hacer el cambio en los diferentes tablas  de la base de datos
                 using (TransactionScope tr = new TransactionScope())
                 {

                    try
                    {                      
                        using (var db = new ModelDB.Contexto())
                        {
                            // se creo este objeto de compra para poder  hacer el insert en la tabla compras
                            ModelDB.COMPRAS compra = new ModelDB.COMPRAS();
                            compra.IdProveedor = int.Parse(cbxProveedor.SelectedValue.ToString());
                            compra.Fecha = Fecha.Value;
                            compra.Comentario = txtComentario.Text;
                            compra.IdUsuario = "Lrivas30";
                            compra.Anulado = false;
                            compra.Motivo = "";
                            db.COMPRAS.Add(compra);
                            db.SaveChanges();

                            int idproductoAcrtualizar;
                            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                            {
                              

                                // se hacer el insert en la tabla detalle de compra
                                ModelDB.DETALLE_COMPRA detalles = new ModelDB.DETALLE_COMPRA();
                                detalles.Costo = int.Parse(dataGridView1.Rows[i].Cells["costo"].Value.ToString());
                                detalles.Cantidad = int.Parse(dataGridView1.Rows[i].Cells["cantida"].Value.ToString());                               
                                detalles.Descuento = int.Parse(dataGridView1.Rows[i].Cells["descuento"].Value.ToString());
                                detalles.IdCompras = compra.IdCompra;
                                detalles.IdProducto = int.Parse(dataGridView1.Rows[i].Cells["codigo"].Value.ToString());
                                db.DETALLE_COMPRA.Add(detalles);
                                db.SaveChanges();
                                
                               
                                // aqui se hace el update la campo  existencia  del produto
                                ModelDB.PRODUCTOS product = new ModelDB.PRODUCTOS();
                                idproductoAcrtualizar = int.Parse(dataGridView1.Rows[i].Cells["codigo"].Value.ToString());
                                product = db.PRODUCTOS.Where(x => x.idProductos == idproductoAcrtualizar).Single(); 
                                product.existencia+= int.Parse(dataGridView1.Rows[i].Cells["cantida"].Value.ToString());                             
                                db.SaveChanges();

                                //  se hace el insert en la tabla vencimiento
                                ModelDB.VENCIMIENTOS vence = new ModelDB.VENCIMIENTOS();
                                vence.idProductos = int.Parse(dataGridView1.Rows[i].Cells["codigo"].Value.ToString());
                                vence.fecha = Convert.ToDateTime(dataGridView1.Rows[i].Cells["fechaVencimiento"].Value.ToString());
                                db.VENCIMIENTOS.Add(vence);
                                db.SaveChanges();
                                
                            };                       
                        }
                        tr.Complete();
                        MessageBox.Show("Transación exitosa");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la transación" + ex.Message);
                       
                    }


                }//fin transactions
               

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
           
            if (txtCosto.Text == "") { MessageBox.Show("el campo 'Costo' es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
            if (txtCantidad.Text == "") { MessageBox.Show("el campo 'Cantidad' es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); validacion = false; }
            //Termina Validacion de campos solos
            if (validacion != false)
            {
                objeto.Rows.Add(cbcodigoProducto.SelectedValue.ToString(), txtCosto.Text, txtCantidad.Text,cbdescuento.SelectedValue.ToString(),FechaFin.Text);
                dataGridView1.DataSource = objeto;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCosto.Text ="";
            txtCantidad.Text = "";
            txtComentario.Text = "";
        }
    }
}
