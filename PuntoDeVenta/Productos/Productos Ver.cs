﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PuntoDeVenta.ModelDB;

namespace PuntoDeVenta.Productos
{
    public partial class Productos_Ver : Form
    {
        public Productos_Ver()
        {
            InitializeComponent();

            using(var context = new ModelVista())
            {
                dataGridView2.DataSource = context.VistaProductos.ToList();
            }

        }

        private void Productos_Ver_Load(object sender, EventArgs e)
        {
            
        }


    }
}
