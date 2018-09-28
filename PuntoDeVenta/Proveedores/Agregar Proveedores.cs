using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txt_Correo.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Correo Invalido.");
            }
            else { 
            if (txt_NomEmpresa.Text != "" && txt_Telefono.Text != "" && txt_Contacto.Text != "" && txt_Correo.Text != "")
            {
                try
                {
                    var add = new ModelDB.Contexto();
                    var proveedores = new ModelDB.PROVEEDORES() { nombreEmpresa = txt_NomEmpresa.Text , correo = txt_Correo.Text 
                        , telefono = int.Parse(txt_Telefono.Text), contacto = txt_Contacto.Text};
                proveedores.activo = ckactivo.Checked;
                add.PROVEEDORES.Add(proveedores);
                add.SaveChanges(); MessageBox.Show("Proveedor guardado"); Close();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Algo salio mal, Codigo del error: " + ex.ErrorCode);
                }
            }
            else MessageBox.Show("Faltan campos por llenar");

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Correo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
