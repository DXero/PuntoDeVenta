using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new ModelDB.ModeloDB()) {
                var dato = context.Configuracion.SqlQuery("SELECT * FROM Configuracion").First<ModelDB.Configuracion>();

                MessageBox.Show(dato.NombreEmpresa);
            }
        }

        private void Form1_Load(object sender, EventArgs e) //Git hub, Punto de venta.
        {

        }
    }
}
