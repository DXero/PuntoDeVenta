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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "DUI:";
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(132, 44);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextNombre.MaxLength = 50;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(200, 22);
            this.TextNombre.TabIndex = 5;
            this.TextNombre.TextChanged += new System.EventHandler(this.TextNombre_TextChanged);
            this.TextNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextNombre_KeyDown);
            this.TextNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNombre_KeyPress);
            // 
            // TextApellido
            // 
            this.TextApellido.Location = new System.Drawing.Point(517, 44);
            this.TextApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextApellido.MaxLength = 50;
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(200, 22);
            this.TextApellido.TabIndex = 6;
            this.TextApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextApellido_KeyPress);
            // 
            // TextCorreo
            // 
            this.TextCorreo.Location = new System.Drawing.Point(132, 150);
            this.TextCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextCorreo.MaxLength = 50;
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.Size = new System.Drawing.Size(200, 22);
            this.TextCorreo.TabIndex = 7;
            // 
            // TextTelefono
            // 
            this.TextTelefono.Location = new System.Drawing.Point(517, 153);
            this.TextTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextTelefono.MaxLength = 8;
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(193, 22);
            this.TextTelefono.TabIndex = 8;
            this.TextTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTelefono_KeyPress);
            // 
            // TextDui
            // 
            this.TextDui.Location = new System.Drawing.Point(132, 242);
            this.TextDui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextDui.MaxLength = 9;
            this.TextDui.Name = "TextDui";
            this.TextDui.Size = new System.Drawing.Size(200, 22);
            this.TextDui.TabIndex = 9;
            this.TextDui.TextChanged += new System.EventHandler(this.TextDui_TextChanged);
            this.TextDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextDui_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 335);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button2;
    }
}