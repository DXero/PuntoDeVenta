namespace PuntoDeVenta.Compras
{
    partial class FormularioCompras
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
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // Fecha
            // 
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.Location = new System.Drawing.Point(75, 31);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(175, 20);
            this.Fecha.TabIndex = 2;
            this.Fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fecha_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(75, 71);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(175, 20);
            this.txtComentario.TabIndex = 4;
            this.txtComentario.TextChanged += new System.EventHandler(this.txtComentario_TextChanged);
            this.txtComentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxProveedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(25, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 163);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(75, 110);
            this.cbxProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(175, 21);
            this.cbxProveedor.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Proveedor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(530, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 84);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(307, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(207, 84);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(25, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 263);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de compra";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo del producto:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(306, 243);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(126, 20);
            this.txtCodProducto.TabIndex = 16;
            this.txtCodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProducto_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha de vencimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Costo:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FechaFin
            // 
            this.FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaFin.Location = new System.Drawing.Point(306, 201);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(126, 20);
            this.FechaFin.TabIndex = 20;
            this.FechaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FechaFin_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(306, 286);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(126, 20);
            this.txtCosto.TabIndex = 21;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(464, 241);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 26);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(306, 328);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(126, 20);
            this.txtCantidad.TabIndex = 24;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(306, 365);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(126, 20);
            this.txtDescuento.TabIndex = 26;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // FormularioCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 587);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodProducto);
            this.Name = "FormularioCompras";
            this.Text = "Formulario de Compras";
            this.Load += new System.EventHandler(this.FormularioCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.DateTimePicker FechaFin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescuento;
    }
}