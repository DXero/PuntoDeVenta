using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using System.Drawing.Imaging;

namespace PuntoDeVenta.Codig_de_barra
{
    public partial class Codigo_de_Barra : Form
    {
        public Codigo_de_Barra()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panelResultado.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White, 400, 100);
            btnGuardar.Enabled = true;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)panelResultado.BackgroundImage.Clone();
            SaveFileDialog CajaDeDialogoGuardar = new SaveFileDialog();
            CajaDeDialogoGuardar.AddExtension = true;
            CajaDeDialogoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDeDialogoGuardar.ShowDialog();
            if(!string.IsNullOrEmpty(CajaDeDialogoGuardar.FileName))
            {
                imgFinal.Save(CajaDeDialogoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }
    }
}
