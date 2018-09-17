using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Proveedores
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void txt_NomEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NomEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
                return;
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
                return;
            }
        }

        private void txt_Contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
                return;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_NomEmpresa.Text != "" && txt_Telefono.Text != "" && txt_Contacto.Text != "" && txt_Correo.Text != "")
            {
                try
                {
                    var add = new ModelDB.Contexto();
                    var proveedores = new ModelDB.PROVEEDORES() { nombreEmpresa = txt_NomEmpresa.Text , correo = txt_Correo.Text 
                        , telefono = int.Parse(txt_Telefono.Text), contacto = txt_Contacto.Text};
                if (rb_No.Checked == true)  proveedores.activo = false; else proveedores.activo = true;
                add.PROVEEDORES.Add(proveedores);
                add.SaveChanges(); MessageBox.Show("Proveedor guardado");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Algo salio mal, Codigo del error: " + ex.ErrorCode);
                }
            }
            else MessageBox.Show("Faltan campos por llenar");

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
