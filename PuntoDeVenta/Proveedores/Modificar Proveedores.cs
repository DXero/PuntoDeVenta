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

namespace PuntoDeVenta.Proveedores
{
    public partial class Modificar_Proveedores : Form
    {
        private PROVEEDORES Proveedor;
        private Contexto Modificar = new Contexto();
        public Modificar_Proveedores(int id)
        {
            InitializeComponent();
            Proveedor = new PROVEEDORES();
            Proveedor  = Modificar.PROVEEDORES.Where(st => st.id == id).First();
            txt_Correo.Text = Proveedor.correo.ToString();
            txt_Contacto.Text = Proveedor.contacto.ToString();
            txt_NomEmpresa.Text = Proveedor.nombreEmpresa.ToString();
            txt_Telefono.Text = Proveedor.telefono.ToString();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(txt_Contacto.Text != "" && txt_Correo.Text != "" && txt_Telefono.Text != "" && txt_NomEmpresa.Text != "")
            {
                Proveedor.activo = ckactivo.Checked;
                Proveedor.nombreEmpresa = txt_NomEmpresa.Text;
                Proveedor.telefono = int.Parse(txt_Telefono.Text);
                Proveedor.correo = txt_Correo.Text;
                Proveedor.contacto = txt_Contacto.Text;
                Modificar.SaveChanges();
                MessageBox.Show("Proveedor modificado");
                Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
