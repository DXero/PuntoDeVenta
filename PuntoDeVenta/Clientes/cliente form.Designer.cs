﻿namespace PuntoDeVenta.Clientes
{
    partial class cliente_form
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDui = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(203, 68);
            this.textNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNombre.MaxLength = 50;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(108, 22);
            this.textNombre.TabIndex = 1;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(203, 132);
            this.textApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textApellidos.MaxLength = 50;
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(108, 22);
            this.textApellidos.TabIndex = 3;
            this.textApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(203, 274);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTelefono.MaxLength = 8;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(108, 22);
            this.textTelefono.TabIndex = 10;
            this.textTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged);
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(469, 68);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCorreo.MaxLength = 50;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(121, 22);
            this.textCorreo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correo";
            // 
            // textDui
            // 
            this.textDui.Location = new System.Drawing.Point(469, 132);
            this.textDui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDui.MaxLength = 9;
            this.textDui.Name = "textDui";
            this.textDui.Size = new System.Drawing.Size(121, 22);
            this.textDui.TabIndex = 14;
            this.textDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDui_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "DUI";
            // 
            // textNit
            // 
            this.textNit.Location = new System.Drawing.Point(469, 198);
            this.textNit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNit.MaxLength = 14;
            this.textNit.Name = "textNit";
            this.textNit.Size = new System.Drawing.Size(121, 22);
            this.textNit.TabIndex = 16;
            this.textNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNit_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo de Usuario";
            // 
            // comboTipoUsuario
            // 
            this.comboTipoUsuario.FormattingEnabled = true;
            this.comboTipoUsuario.Items.AddRange(new object[] {
            "Credito fiscal",
            "Consumidor final"});
            this.comboTipoUsuario.Location = new System.Drawing.Point(469, 274);
            this.comboTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTipoUsuario.Name = "comboTipoUsuario";
            this.comboTipoUsuario.Size = new System.Drawing.Size(121, 24);
            this.comboTipoUsuario.TabIndex = 18;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(203, 361);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(132, 50);
            this.buttonAceptar.TabIndex = 19;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(469, 361);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(133, 50);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimiento.Location = new System.Drawing.Point(205, 198);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(122, 22);
            this.fechaNacimiento.TabIndex = 20;
            // 
            // cliente_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboTipoUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textNit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textDui);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cliente_form";
            this.Text = "cliente_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTipoUsuario;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
    }
}