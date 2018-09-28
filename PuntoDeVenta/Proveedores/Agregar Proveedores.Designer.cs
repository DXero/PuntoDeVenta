namespace PuntoDeVenta.Proveedores
{
    partial class Proveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NomEmpresa = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Contacto = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.ckactivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Activo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contacto:";
            // 
            // txt_NomEmpresa
            // 
            this.txt_NomEmpresa.Location = new System.Drawing.Point(151, 27);
            this.txt_NomEmpresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NomEmpresa.MaxLength = 100;
            this.txt_NomEmpresa.Name = "txt_NomEmpresa";
            this.txt_NomEmpresa.Size = new System.Drawing.Size(141, 20);
            this.txt_NomEmpresa.TabIndex = 7;
            this.txt_NomEmpresa.TextChanged += new System.EventHandler(this.txt_NomEmpresa_TextChanged);
            this.txt_NomEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomEmpresa_KeyPress);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(151, 75);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Telefono.MaxLength = 8;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(128, 20);
            this.txt_Telefono.TabIndex = 8;
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_KeyPress);
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(151, 51);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Correo.MaxLength = 50;
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(285, 20);
            this.txt_Correo.TabIndex = 9;
            this.txt_Correo.TextChanged += new System.EventHandler(this.txt_Correo_TextChanged);
            // 
            // txt_Contacto
            // 
            this.txt_Contacto.Location = new System.Drawing.Point(151, 100);
            this.txt_Contacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Contacto.MaxLength = 50;
            this.txt_Contacto.Name = "txt_Contacto";
            this.txt_Contacto.Size = new System.Drawing.Size(128, 20);
            this.txt_Contacto.TabIndex = 10;
            this.txt_Contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contacto_KeyPress);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(241, 140);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(153, 49);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(55, 140);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(145, 49);
            this.btn_Guardar.TabIndex = 12;
            this.btn_Guardar.Text = "Agregar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // ckactivo
            // 
            this.ckactivo.AutoSize = true;
            this.ckactivo.Location = new System.Drawing.Point(365, 29);
            this.ckactivo.Name = "ckactivo";
            this.ckactivo.Size = new System.Drawing.Size(35, 17);
            this.ckactivo.TabIndex = 14;
            this.ckactivo.Text = "Si";
            this.ckactivo.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 210);
            this.Controls.Add(this.ckactivo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Contacto);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_NomEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Proveedores";
            this.Text = "Agregar Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NomEmpresa;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Contacto;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.CheckBox ckactivo;
    }
}