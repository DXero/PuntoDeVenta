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
    public partial class Principal_Proveedores : Form
    {
        public Principal_Proveedores()
        {
            InitializeComponent();
        }

        private void Principal_Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet3.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            ActualizarTabla();

        }

        private void ActualizarTabla()
        {
            this.pROVEEDORESTableAdapter.Fill(this.sistemaDataSet3.PROVEEDORES);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new Proveedores().ShowDialog();
            ActualizarTabla();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          DialogResult result = MessageBox.Show("¿Esta seguro que desea borrar el registro selecionado?","ALERTA",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                foreach (DataGridViewRow row in Tabla.SelectedRows)
                {
                    var eliminar = new Contexto();
                    var aux = new PROVEEDORES() { id = int.Parse(row.Cells[0].Value.ToString()) };
                    eliminar.PROVEEDORES.Attach(aux);
                    eliminar.PROVEEDORES.Remove(aux);
                    eliminar.SaveChanges();
                    MessageBox.Show("eliminado"); ActualizarTabla(); 
                } else MessageBox.Show("Eliminacion cancelada");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Tabla.SelectedRows)
                new Modificar_Proveedores(int.Parse(row.Cells[0].Value.ToString())).ShowDialog();
            ActualizarTabla();
        }
    }
}
