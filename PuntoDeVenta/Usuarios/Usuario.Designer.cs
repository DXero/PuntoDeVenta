﻿namespace PuntoDeVenta.Usuarios
{
    partial class Usuario
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
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextApellido = new System.Windows.Forms.TextBox();
            this.TextCorreo = new System.Windows.Forms.TextBox();
            this.TextTelefono = new System.Windows.Forms.TextBox();
            this.TextDui = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DUI:";
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(99, 36);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(151, 20);
            this.TextNombre.TabIndex = 5;
            // 
            // TextApellido
            // 
            this.TextApellido.Location = new System.Drawing.Point(388, 36);
            this.TextApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(151, 20);
            this.TextApellido.TabIndex = 6;
            // 
            // TextCorreo
            // 
            this.TextCorreo.Location = new System.Drawing.Point(99, 122);
            this.TextCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.Size = new System.Drawing.Size(151, 20);
            this.TextCorreo.TabIndex = 7;
            // 
            // TextTelefono
            // 
            this.TextTelefono.Location = new System.Drawing.Point(388, 124);
            this.TextTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(146, 20);
            this.TextTelefono.TabIndex = 8;
            // 
            // TextDui
            // 
            this.TextDui.Location = new System.Drawing.Point(99, 197);
            this.TextDui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextDui.Name = "TextDui";
            this.TextDui.Size = new System.Drawing.Size(151, 20);
            this.TextDui.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextDui);
            this.Controls.Add(this.TextTelefono);
            this.Controls.Add(this.TextCorreo);
            this.Controls.Add(this.TextApellido);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Usuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextApellido;
        private System.Windows.Forms.TextBox TextCorreo;
        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.TextBox TextDui;
        private System.Windows.Forms.Button button1;
    }
}