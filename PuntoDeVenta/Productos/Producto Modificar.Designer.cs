namespace PuntoDeVenta.Productos
{
    partial class Producto_Modificar
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
            this.label2 = new System.Windows.Forms.Label();
            this.ck_activo = new System.Windows.Forms.CheckBox();
            this.cb_Descuento = new System.Windows.Forms.ComboBox();
            this.txt_Costo = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.cb_Categoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Activo:";
            // 
            // ck_activo
            // 
            this.ck_activo.AutoSize = true;
            this.ck_activo.Location = new System.Drawing.Point(92, 169);
            this.ck_activo.Name = "ck_activo";
            this.ck_activo.Size = new System.Drawing.Size(35, 17);
            this.ck_activo.TabIndex = 42;
            this.ck_activo.Text = "Si";
            this.ck_activo.UseVisualStyleBackColor = true;
            // 
            // cb_Descuento
            // 
            this.cb_Descuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Descuento.FormattingEnabled = true;
            this.cb_Descuento.Location = new System.Drawing.Point(92, 142);
            this.cb_Descuento.Name = "cb_Descuento";
            this.cb_Descuento.Size = new System.Drawing.Size(77, 21);
            this.cb_Descuento.TabIndex = 40;
            // 
            // txt_Costo
            // 
            this.txt_Costo.Location = new System.Drawing.Point(92, 119);
            this.txt_Costo.MaxLength = 8;
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.Size = new System.Drawing.Size(77, 20);
            this.txt_Costo.TabIndex = 39;
            this.txt_Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Costo_KeyPress);
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(92, 95);
            this.txt_Precio.MaxLength = 8;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(77, 20);
            this.txt_Precio.TabIndex = 38;
            this.txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Precio_KeyPress);
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.Location = new System.Drawing.Point(92, 69);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.Size = new System.Drawing.Size(150, 21);
            this.cb_Categoria.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Costo:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(92, 41);
            this.txt_Descripcion.MaxLength = 100;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(212, 20);
            this.txt_Descripcion.TabIndex = 34;
            this.txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descripcion_KeyPress);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(92, 17);
            this.txt_Codigo.MaxLength = 40;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(212, 20);
            this.txt_Codigo.TabIndex = 33;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(326, 123);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(152, 77);
            this.btn_Cancelar.TabIndex = 32;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(326, 18);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(152, 79);
            this.btn_Guardar.TabIndex = 31;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Codigo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descuento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Descripción:";
            // 
            // Producto_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ck_activo);
            this.Controls.Add(this.cb_Descuento);
            this.Controls.Add(this.txt_Costo);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.cb_Categoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Producto_Modificar";
            this.Text = "Producto_Modificar";
            this.Load += new System.EventHandler(this.Producto_Modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ck_activo;
        private System.Windows.Forms.ComboBox cb_Descuento;
        private System.Windows.Forms.TextBox txt_Costo;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.ComboBox cb_Categoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}