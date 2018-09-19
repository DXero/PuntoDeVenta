namespace PuntoDeVenta.Usuarios
{
    partial class UsModificar
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextDui = new System.Windows.Forms.TextBox();
            this.TextTelefono = new System.Windows.Forms.TextBox();
            this.TextCorreo = new System.Windows.Forms.TextBox();
            this.TextApellido = new System.Windows.Forms.TextBox();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sistemaDataSet2 = new PuntoDeVenta.sistemaDataSet2();
            this.sistemaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new PuntoDeVenta.sistemaDataSet2TableAdapters.UsuariosTableAdapter();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 49);
            this.button2.TabIndex = 35;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 34;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextDui
            // 
            this.TextDui.Location = new System.Drawing.Point(410, 211);
            this.TextDui.Margin = new System.Windows.Forms.Padding(2);
            this.TextDui.MaxLength = 9;
            this.TextDui.Name = "TextDui";
            this.TextDui.Size = new System.Drawing.Size(151, 20);
            this.TextDui.TabIndex = 33;
            this.TextDui.TextChanged += new System.EventHandler(this.TextDui_TextChanged);
            // 
            // TextTelefono
            // 
            this.TextTelefono.Location = new System.Drawing.Point(410, 137);
            this.TextTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.TextTelefono.MaxLength = 8;
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(146, 20);
            this.TextTelefono.TabIndex = 32;
            // 
            // TextCorreo
            // 
            this.TextCorreo.Location = new System.Drawing.Point(115, 211);
            this.TextCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TextCorreo.MaxLength = 50;
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.Size = new System.Drawing.Size(151, 20);
            this.TextCorreo.TabIndex = 31;
            // 
            // TextApellido
            // 
            this.TextApellido.Location = new System.Drawing.Point(115, 137);
            this.TextApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TextApellido.MaxLength = 50;
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(151, 20);
            this.TextApellido.TabIndex = 30;
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(410, 50);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TextNombre.MaxLength = 50;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(151, 20);
            this.TextNombre.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "DUI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Usuario: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "Us_Usuario", true));
            this.comboBox1.DataSource = this.usuariosBindingSource1;
            this.comboBox1.DisplayMember = "Us_Usuario";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.ValueMember = "Us_Usuario";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.MostrarDatos);
            // 
            // sistemaDataSet2
            // 
            this.sistemaDataSet2.DataSetName = "sistemaDataSet2";
            this.sistemaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaDataSet2BindingSource
            // 
            this.sistemaDataSet2BindingSource.DataSource = this.sistemaDataSet2;
            this.sistemaDataSet2BindingSource.Position = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaDataSet2;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.sistemaDataSet2BindingSource;
            // 
            // UsModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
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
            this.Name = "UsModificar";
            this.Text = "Editar usuario";
            this.Load += new System.EventHandler(this.UsModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextDui;
        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.TextBox TextCorreo;
        private System.Windows.Forms.TextBox TextApellido;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sistemaDataSet2BindingSource;
        private sistemaDataSet2 sistemaDataSet2;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private sistemaDataSet2TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
    }
}