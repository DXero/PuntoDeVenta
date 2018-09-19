namespace PuntoDeVenta.Usuarios
{
    partial class DeshabilitarUs
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSet1 = new PuntoDeVenta.sistemaDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new PuntoDeVenta.sistemaDataSet1TableAdapters.UsuariosTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sistemaDataSet2 = new PuntoDeVenta.sistemaDataSet2();
            this.usuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter1 = new PuntoDeVenta.sistemaDataSet2TableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource2, "Us_Usuario", true));
            this.comboBox1.DataSource = this.usuariosBindingSource2;
            this.comboBox1.DisplayMember = "Us_Usuario";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Us_Usuario";
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.sistemaDataSet1;
            // 
            // sistemaDataSet1
            // 
            this.sistemaDataSet1.DataSetName = "sistemaDataSet1";
            this.sistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Deshabilitar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaDataSet1;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(392, 26);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(44, 23);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // sistemaDataSet2
            // 
            this.sistemaDataSet2.DataSetName = "sistemaDataSet2";
            this.sistemaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource2
            // 
            this.usuariosBindingSource2.DataMember = "Usuarios";
            this.usuariosBindingSource2.DataSource = this.sistemaDataSet2;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // DeshabilitarUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 219);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "DeshabilitarUs";
            this.Text = "DeshabilitarUs";
            this.Load += new System.EventHandler(this.DeshabilitarUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private sistemaDataSet1 sistemaDataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private sistemaDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private sistemaDataSet2 sistemaDataSet2;
        private System.Windows.Forms.BindingSource usuariosBindingSource2;
        private sistemaDataSet2TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
    }
}