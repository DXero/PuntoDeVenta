namespace PuntoDeVenta.Reportes
{
    partial class Poca_Existencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_PocaExistencia = new System.Windows.Forms.Panel();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_PocaExistencia
            // 
            this.pnl_PocaExistencia.Location = new System.Drawing.Point(12, 140);
            this.pnl_PocaExistencia.Name = "pnl_PocaExistencia";
            this.pnl_PocaExistencia.Size = new System.Drawing.Size(853, 503);
            this.pnl_PocaExistencia.TabIndex = 0;
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Location = new System.Drawing.Point(99, 59);
            this.txt_IdProducto.Multiline = true;
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(160, 28);
            this.txt_IdProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Producto:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(312, 59);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(102, 28);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Poca_Existencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 655);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.pnl_PocaExistencia);
            this.Name = "Poca_Existencia";
            this.Text = "Poca_Existencia";
            this.Load += new System.EventHandler(this.Poca_Existencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_PocaExistencia;
        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
    }
}