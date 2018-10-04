namespace PuntoDeVenta.Productos
{
    partial class Productos_Ver
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
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.sistemaDataSet41 = new PuntoDeVenta.sistemaDataSet4();
            this.cPRODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPRODTableAdapter = new PuntoDeVenta.sistemaDataSet4TableAdapters.CPRODTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPRODBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(367, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.codigoBarraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cPRODBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 349);
            this.dataGridView1.TabIndex = 3;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "existencia";
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            // 
            // codigoBarraDataGridViewTextBoxColumn
            // 
            this.codigoBarraDataGridViewTextBoxColumn.DataPropertyName = "codigoBarra";
            this.codigoBarraDataGridViewTextBoxColumn.HeaderText = "codigoBarra";
            this.codigoBarraDataGridViewTextBoxColumn.Name = "codigoBarraDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(790, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Actualizar tabla";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // sistemaDataSet41
            // 
            this.sistemaDataSet41.DataSetName = "sistemaDataSet4";
            this.sistemaDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cPRODBindingSource
            // 
            this.cPRODBindingSource.DataMember = "CPROD";
            this.cPRODBindingSource.DataSource = this.sistemaDataSet41;
            // 
            // cPRODTableAdapter
            // 
            this.cPRODTableAdapter.ClearBeforeFill = true;
            // 
            // Productos_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 396);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Productos_Ver";
            this.Text = "Productos_Ver";
            this.Load += new System.EventHandler(this.Productos_Ver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPRODBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarraDataGridViewTextBoxColumn;
        private sistemaDataSet4 sistemaDataSet41;
        private System.Windows.Forms.BindingSource cPRODBindingSource;
        private sistemaDataSet4TableAdapters.CPRODTableAdapter cPRODTableAdapter;
    }
}