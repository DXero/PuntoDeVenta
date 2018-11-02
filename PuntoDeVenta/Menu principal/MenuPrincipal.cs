using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Menu_principal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void registrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.cliente_form registrarCliente = new Clientes.cliente_form();
            registrarCliente.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.Principal_Usuarios usuario = new Usuarios.Principal_Usuarios();
            usuario.Show();
        }

        private void registrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.Principal_Proveedores proveedor = new Proveedores.Principal_Proveedores();
            proveedor.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos.Producto_Nuevo registrarProducto = new Productos.Producto_Nuevo();
            registrarProducto.Show();
        }

        private void modificarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos.Producto_Modificar modificarProduct = new Productos.Producto_Modificar(1);
            modificarProduct.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos.Productos_Ver Productos_Ver = new Productos.Productos_Ver();
            Productos_Ver.Show();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras.FormularioCompras compra = new Compras.FormularioCompras();
            compra.Show();
        }

        private void anularCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras.Anulado compraAnulada = new Compras.Anulado();
            compraAnulada.Show();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.Agregar_venta agregarVent = new Ventas.Agregar_venta();
            agregarVent.Show();
            
        }

        private void anularVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.Anular_venta agregarVent = new Ventas.Anular_venta();
            agregarVent.Show();
        }
    }
}
