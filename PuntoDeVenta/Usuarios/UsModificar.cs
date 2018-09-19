using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Usuarios
{
    public partial class UsModificar : Form
    {
        public UsModificar()
        {
            InitializeComponent();

        }

        private void UsModificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet2.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.sistemaDataSet2.Usuarios);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextDui_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MostrarDatos(object sender, EventArgs e)
        {
            var context = new ModelDB.Contexto();
            var user = from Usuario in context.Usuarios select Usuario;

           
        }
    }
}
