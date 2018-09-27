﻿namespace PuntoDeVenta.Usuarios
{
    partial class Principal_Usuarios
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tablaUs = new PuntoDeVenta.TablaUs();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new PuntoDeVenta.TablaUsTableAdapters.UsuariosTableAdapter();
            this.usUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usCorreoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usDUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usEstadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usUsuarioDataGridViewTextBoxColumn,
            this.usNombreDataGridViewTextBoxColumn,
            this.usApellidoDataGridViewTextBoxColumn,
            this.usCorreoDataGridViewTextBoxColumn,
            this.usTelefonoDataGridViewTextBoxColumn,
            this.usDUIDataGridViewTextBoxColumn,
            this.usEstadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 361);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tablaUs
            // 
            this.tablaUs.DataSetName = "TablaUs";
            this.tablaUs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.tablaUs;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usUsuarioDataGridViewTextBoxColumn
            // 
            this.usUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Us_Usuario";
            this.usUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usUsuarioDataGridViewTextBoxColumn.Name = "usUsuarioDataGridViewTextBoxColumn";
            // 
            // usNombreDataGridViewTextBoxColumn
            // 
            this.usNombreDataGridViewTextBoxColumn.DataPropertyName = "Us_Nombre";
            this.usNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.usNombreDataGridViewTextBoxColumn.Name = "usNombreDataGridViewTextBoxColumn";
            // 
            // usApellidoDataGridViewTextBoxColumn
            // 
            this.usApellidoDataGridViewTextBoxColumn.DataPropertyName = "Us_Apellido";
            this.usApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.usApellidoDataGridViewTextBoxColumn.Name = "usApellidoDataGridViewTextBoxColumn";
            // 
            // usCorreoDataGridViewTextBoxColumn
            // 
            this.usCorreoDataGridViewTextBoxColumn.DataPropertyName = "Us_Correo";
            this.usCorreoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.usCorreoDataGridViewTextBoxColumn.Name = "usCorreoDataGridViewTextBoxColumn";
            // 
            // usTelefonoDataGridViewTextBoxColumn
            // 
            this.usTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Us_Telefono";
            this.usTelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.usTelefonoDataGridViewTextBoxColumn.Name = "usTelefonoDataGridViewTextBoxColumn";
            // 
            // usDUIDataGridViewTextBoxColumn
            // 
            this.usDUIDataGridViewTextBoxColumn.DataPropertyName = "Us_DUI";
            this.usDUIDataGridViewTextBoxColumn.HeaderText = "DUI";
            this.usDUIDataGridViewTextBoxColumn.Name = "usDUIDataGridViewTextBoxColumn";
            // 
            // usEstadoDataGridViewCheckBoxColumn
            // 
            this.usEstadoDataGridViewCheckBoxColumn.DataPropertyName = "Us_Estado";
            this.usEstadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.usEstadoDataGridViewCheckBoxColumn.Name = "usEstadoDataGridViewCheckBoxColumn";
            // 
            // Principal_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 452);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal_Usuarios";
            this.Text = "Principal_Usuarios";
            this.Load += new System.EventHandler(this.Principal_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TablaUs tablaUs;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private TablaUsTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usCorreoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usDUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usEstadoDataGridViewCheckBoxColumn;
    }
}