namespace PuntoDeVenta.Clientes
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
            this.textoFechaDia = new System.Windows.Forms.TextBox();
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
            this.textFechaMes = new System.Windows.Forms.TextBox();
            this.textoFechaYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(152, 55);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.MaxLength = 50;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(82, 20);
            this.textNombre.TabIndex = 1;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(152, 107);
            this.textApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.textApellidos.MaxLength = 50;
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(82, 20);
            this.textApellidos.TabIndex = 3;
            this.textApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // textoFechaDia
            // 
            this.textoFechaDia.Location = new System.Drawing.Point(152, 161);
            this.textoFechaDia.Margin = new System.Windows.Forms.Padding(2);
            this.textoFechaDia.MaxLength = 2;
            this.textoFechaDia.Name = "textoFechaDia";
            this.textoFechaDia.Size = new System.Drawing.Size(20, 20);
            this.textoFechaDia.TabIndex = 5;
            this.textoFechaDia.TextChanged += new System.EventHandler(this.textoFechaDia_TextChanged);
            this.textoFechaDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoFechaDia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(152, 223);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textTelefono.MaxLength = 8;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(82, 20);
            this.textTelefono.TabIndex = 10;
            this.textTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged);
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(352, 55);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.textCorreo.MaxLength = 50;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(92, 20);
            this.textCorreo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correo";
            // 
            // textDui
            // 
            this.textDui.Location = new System.Drawing.Point(352, 107);
            this.textDui.Margin = new System.Windows.Forms.Padding(2);
            this.textDui.MaxLength = 9;
            this.textDui.Name = "textDui";
            this.textDui.Size = new System.Drawing.Size(92, 20);
            this.textDui.TabIndex = 14;
            this.textDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDui_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DUI";
            // 
            // textNit
            // 
            this.textNit.Location = new System.Drawing.Point(352, 161);
            this.textNit.Margin = new System.Windows.Forms.Padding(2);
            this.textNit.MaxLength = 14;
            this.textNit.Name = "textNit";
            this.textNit.Size = new System.Drawing.Size(92, 20);
            this.textNit.TabIndex = 16;
            this.textNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNit_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo de Usuario";
            // 
            // comboTipoUsuario
            // 
            this.comboTipoUsuario.FormattingEnabled = true;
            this.comboTipoUsuario.Location = new System.Drawing.Point(352, 223);
            this.comboTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.comboTipoUsuario.Name = "comboTipoUsuario";
            this.comboTipoUsuario.Size = new System.Drawing.Size(92, 21);
            this.comboTipoUsuario.TabIndex = 18;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(152, 293);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(99, 41);
            this.buttonAceptar.TabIndex = 19;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(352, 293);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 41);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textFechaMes
            // 
            this.textFechaMes.Location = new System.Drawing.Point(174, 161);
            this.textFechaMes.Margin = new System.Windows.Forms.Padding(2);
            this.textFechaMes.MaxLength = 2;
            this.textFechaMes.Name = "textFechaMes";
            this.textFechaMes.Size = new System.Drawing.Size(20, 20);
            this.textFechaMes.TabIndex = 7;
            this.textFechaMes.TextChanged += new System.EventHandler(this.textFechaMes_TextChanged);
            this.textFechaMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFechaMes_KeyPress);
            // 
            // textoFechaYear
            // 
            this.textoFechaYear.Location = new System.Drawing.Point(197, 161);
            this.textoFechaYear.Margin = new System.Windows.Forms.Padding(2);
            this.textoFechaYear.MaxLength = 4;
            this.textoFechaYear.Name = "textoFechaYear";
            this.textoFechaYear.Size = new System.Drawing.Size(38, 20);
            this.textoFechaYear.TabIndex = 8;
            this.textoFechaYear.TextChanged += new System.EventHandler(this.textoFechaYear_TextChanged);
            this.textoFechaYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoFechaYear_KeyPress);
            // 
            // cliente_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Controls.Add(this.textoFechaYear);
            this.Controls.Add(this.textFechaMes);
            this.Controls.Add(this.textoFechaDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textoFechaDia;
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
        private System.Windows.Forms.TextBox textFechaMes;
        private System.Windows.Forms.TextBox textoFechaYear;
    }
}