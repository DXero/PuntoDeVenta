using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;

namespace PuntoDeVenta.Usuarios
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void TextNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
                return;
            }

        }

        private void TextApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
               e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
                return;
            }
            
        }

        private void TextDui_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
                return;
            }
        }

        private void TextDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(TextCorreo.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Correo Invalido.");
            }
            else
            {
                if (TextNombre.Text != "" && TextApellido.Text != "" && TextDui.Text != "" && TextTelefono.Text != "")
                {
                    var add = new ModelDB.Contexto();
                    var us = new ModelDB.Usuarios();
                    us.Us_Usuario = TextUsuario.Text;
                    us.US_Password = Encriptar("0000");
                    us.Us_Nombre = TextNombre.Text;
                    us.Us_Apellido = TextApellido.Text;
                    us.Us_Correo = TextCorreo.Text;
                    us.Us_Telefono = Convert.ToInt32(TextTelefono.Text);
                    us.Us_DUI = Convert.ToInt32(TextDui.Text);
                    us.Us_Estado = true;
                    add.Usuarios.Add(us);
                    add.SaveChanges();
                    MessageBox.Show("Usuario guardado");

                }
                else MessageBox.Show("Faltan campos por llenar");
            }
        }

        private void TextNombre_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static string Encriptar(string texto)
        {
            try
            {
                string key = "qualityinfosolutions"; //llave para encriptar datos
                byte[] keyArray;
                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);
                //Se utilizan las clases de encriptación MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return texto;
        }
    }
   
}
