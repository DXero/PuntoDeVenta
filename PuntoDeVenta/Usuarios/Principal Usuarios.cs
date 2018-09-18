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
    public partial class Principal_Usuarios : Form
    {
        public Principal_Usuarios()
        {
            InitializeComponent();
            
        }
        
        private void Principal_Usuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.TopLevel = false;
            us.Dock = DockStyle.Fill;
            us.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(us);
            us.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
