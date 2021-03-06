﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Clientes
{
    public partial class cliente_form : Form
    {
        public cliente_form()
        {
            InitializeComponent();   
        }
        bool validacion = true;
        //**********************Validacion solo letras************************
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        //**********************Validacion solo numeros************************
        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void textDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
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

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            validacion = true;
            String msj = "";
            //***********
            if (textNombre.Text == "" || textApellidos.Text == "") { msj += "Los campos 'Nombres' y 'Apellidos' son obligatorios\n"; validacion = false; }
            if (textTelefono.Text == "" || textTelefono.Text.Length != 8) { msj += "el campo 'Telefono' esta vacio o no contiene 8 digitos\n"; validacion = false; }
            if (textNit.Text == "" || textNit.Text.Length != 14) { msj += "el campo 'NIT' debe contener 14 digitos\n"; validacion = false; }
            if (textDui.Text == "" || textDui.Text.Length != 9) { msj += "el campo 'DUI' debe contener 9 digitos\n"; validacion = false; }
            
            


            //***********
            if (validacion != false)
            {
                ModelDB.Contexto db = new ModelDB.Contexto();
                ModelDB. CLIENTES cli = new ModelDB.CLIENTES();
                cli.telefono = Convert.ToInt32(textTelefono.Text);
                cli.nombres = textNombre.Text;
                cli.fechaNacimiento = fechaNacimiento.Value;
                cli.nit = Convert.ToInt64(textNit.Text);
                cli.apellidos = textApellidos.Text;
                cli.dui = Convert.ToInt32(textDui.Text);
                cli.correo = textCorreo.Text;
                cli.tipoCliente = comboTipoUsuario.Text;
                db.CLIENTES.Add(cli);

                if (db.SaveChanges() > 0 )
                {
                    MessageBox.Show("Cliente agregado exitosamente");
                }
                else
                {
                    MessageBox.Show("Fallo conexión");
                }
            }
            else
            {
                MessageBox.Show(msj, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
       
    
}
