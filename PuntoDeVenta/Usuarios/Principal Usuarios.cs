﻿using System;
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
            // TODO: esta línea de código carga datos en la tabla 'tablaUs.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.tablaUs.Usuarios);
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {       
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                StaticValue.us = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                UsModificar us = new UsModificar();
                us.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                StaticValue.us = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                DeshabilitarUs us = new DeshabilitarUs();
                us.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.tablaUs.Usuarios);
        }
    }
}
