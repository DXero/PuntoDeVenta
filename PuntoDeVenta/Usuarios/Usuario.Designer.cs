namespace PuntoDeVenta.Usuarios
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
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
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
            this.label3.Location = new System.Drawing.Point(338, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DUI:";
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(104, 36);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextNombre.MaxLength = 50;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(151, 20);
            this.TextNombre.TabIndex = 5;
            this.TextNombre.TextChanged += new System.EventHandler(this.TextNombre_TextChanged);
            this.TextNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextNombre_KeyDown);
            this.TextNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNombre_KeyPress);
            // 
            // TextApellido
            // 
            this.TextApellido.Location = new System.Drawing.Point(388, 36);
            this.TextApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextApellido.MaxLength = 50;
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(151, 20);
            this.TextApellido.TabIndex = 6;
            this.TextApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextApellido_KeyPress);
            // 
            // TextCorreo
            // 
            this.TextCorreo.Location = new System.Drawing.Point(388, 118);
            this.TextCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextCorreo.MaxLength = 50;
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.Size = new System.Drawing.Size(151, 20);
            this.TextCorreo.TabIndex = 7;
            // 
            // TextTelefono
            // 
            this.TextTelefono.Location = new System.Drawing.Point(104, 194);
            this.TextTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTelefono.MaxLength = 8;
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(146, 20);
            this.TextTelefono.TabIndex = 8;
            this.TextTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTelefono_KeyPress);
            // 
            // TextDui
            // 
            this.TextDui.Location = new System.Drawing.Point(388, 194);
            this.TextDui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextDui.MaxLength = 9;
            this.TextDui.Name = "TextDui";
            this.TextDui.Size = new System.Drawing.Size(151, 20);
            this.TextDui.TabIndex = 9;
            this.TextDui.TextChanged += new System.EventHandler(this.TextDui_TextChanged);
            this.TextDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextDui_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuario: ";
            // 
            // TextUsuario
            // 
            this.TextUsuario.Location = new System.Drawing.Point(104, 118);
            this.TextUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TextUsuario.MaxLength = 50;
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(151, 20);
            this.TextUsuario.TabIndex = 13;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TextUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
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
            this.Text = "Agregar Usuarios";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextUsuario;
    }
}