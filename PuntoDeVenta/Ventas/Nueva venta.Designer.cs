namespace PuntoDeVenta.Ventas
{
    partial class Agregar_venta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtExistencias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAgregarDetalle = new System.Windows.Forms.Button();
            this.CmbCliente = new System.Windows.Forms.ComboBox();
            this.SpCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecioProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TablaDetallle = new System.Windows.Forms.DataGridView();
            this.Comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDetallle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtExistencias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnAgregarDetalle);
            this.groupBox1.Controls.Add(this.CmbCliente);
            this.groupBox1.Controls.Add(this.SpCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtPrecioProd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva venta";
            // 
            // TxtExistencias
            // 
            this.TxtExistencias.Location = new System.Drawing.Point(212, 55);
            this.TxtExistencias.MaxLength = 7;
            this.TxtExistencias.Name = "TxtExistencias";
            this.TxtExistencias.ReadOnly = true;
            this.TxtExistencias.Size = new System.Drawing.Size(53, 20);
            this.TxtExistencias.TabIndex = 13;
            this.TxtExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Disponibles:";
            // 
            // BtnAgregarDetalle
            // 
            this.BtnAgregarDetalle.Location = new System.Drawing.Point(283, 29);
            this.BtnAgregarDetalle.Name = "BtnAgregarDetalle";
            this.BtnAgregarDetalle.Size = new System.Drawing.Size(177, 94);
            this.BtnAgregarDetalle.TabIndex = 6;
            this.BtnAgregarDetalle.Text = "Agregar al detalle";
            this.BtnAgregarDetalle.UseVisualStyleBackColor = true;
            this.BtnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);
            // 
            // CmbCliente
            // 
            this.CmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCliente.FormattingEnabled = true;
            this.CmbCliente.Location = new System.Drawing.Point(83, 81);
            this.CmbCliente.Name = "CmbCliente";
            this.CmbCliente.Size = new System.Drawing.Size(182, 21);
            this.CmbCliente.TabIndex = 4;
            // 
            // SpCantidad
            // 
            this.SpCantidad.Location = new System.Drawing.Point(195, 108);
            this.SpCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpCantidad.Name = "SpCantidad";
            this.SpCantidad.ReadOnly = true;
            this.SpCantidad.Size = new System.Drawing.Size(53, 20);
            this.SpCantidad.TabIndex = 11;
            this.SpCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpCantidad.ValueChanged += new System.EventHandler(this.SpCantidad_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Comprador: ";
            // 
            // TxtPrecioProd
            // 
            this.TxtPrecioProd.Location = new System.Drawing.Point(83, 55);
            this.TxtPrecioProd.MaxLength = 7;
            this.TxtPrecioProd.Name = "TxtPrecioProd";
            this.TxtPrecioProd.ReadOnly = true;
            this.TxtPrecioProd.Size = new System.Drawing.Size(53, 20);
            this.TxtPrecioProd.TabIndex = 5;
            this.TxtPrecioProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPrecioProd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.TxtPrecioProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad a vender: ";
            // 
            // CmbProducto
            // 
            this.CmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProducto.FormattingEnabled = true;
            this.CmbProducto.Location = new System.Drawing.Point(83, 29);
            this.CmbProducto.Name = "CmbProducto";
            this.CmbProducto.Size = new System.Drawing.Size(182, 21);
            this.CmbProducto.TabIndex = 1;
            this.CmbProducto.SelectedIndexChanged += new System.EventHandler(this.CmbProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto: ";
            // 
            // TablaDetallle
            // 
            this.TablaDetallle.AllowUserToAddRows = false;
            this.TablaDetallle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDetallle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comprador,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.TablaDetallle.Location = new System.Drawing.Point(13, 169);
            this.TablaDetallle.MultiSelect = false;
            this.TablaDetallle.Name = "TablaDetallle";
            this.TablaDetallle.ReadOnly = true;
            this.TablaDetallle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaDetallle.Size = new System.Drawing.Size(731, 286);
            this.TablaDetallle.TabIndex = 1;
            // 
            // Comprador
            // 
            this.Comprador.HeaderText = "Comprador";
            this.Comprador.Name = "Comprador";
            this.Comprador.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(484, 22);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(260, 56);
            this.BtnRegistrar.TabIndex = 2;
            this.BtnRegistrar.Text = "Registar venta";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(484, 93);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(260, 59);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(12, 461);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(732, 24);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar Detalle";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Agregar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 487);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TablaDetallle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Agregar_venta";
            this.Text = "Agregar_venta";
            this.Load += new System.EventHandler(this.Agregar_venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDetallle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregarDetalle;
        private System.Windows.Forms.TextBox TxtPrecioProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SpCantidad;
        private System.Windows.Forms.DataGridView TablaDetallle;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbCliente;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtExistencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button BtnEliminar;
    }
}