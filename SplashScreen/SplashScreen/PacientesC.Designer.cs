namespace SplashScreen
{
    partial class PacientesC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesC));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDNPacientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seguroDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipoSeguroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuevosPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicAppDataSet = new SplashScreen.MedicAppDataSet();
            this.Atras2 = new System.Windows.Forms.Button();
            this.nuevos_PacientesTableAdapter = new SplashScreen.MedicAppDataSetTableAdapters.Nuevos_PacientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevosPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNPacientesDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.consultaDataGridViewCheckBoxColumn,
            this.seguroDataGridViewCheckBoxColumn,
            this.tipoSeguroDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nuevosPacientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDNPacientesDataGridViewTextBoxColumn
            // 
            this.iDNPacientesDataGridViewTextBoxColumn.DataPropertyName = "ID_NPacientes";
            this.iDNPacientesDataGridViewTextBoxColumn.HeaderText = "ID_NPacientes";
            this.iDNPacientesDataGridViewTextBoxColumn.Name = "iDNPacientesDataGridViewTextBoxColumn";
            this.iDNPacientesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // consultaDataGridViewCheckBoxColumn
            // 
            this.consultaDataGridViewCheckBoxColumn.DataPropertyName = "Consulta";
            this.consultaDataGridViewCheckBoxColumn.HeaderText = "Consulta";
            this.consultaDataGridViewCheckBoxColumn.Name = "consultaDataGridViewCheckBoxColumn";
            // 
            // seguroDataGridViewCheckBoxColumn
            // 
            this.seguroDataGridViewCheckBoxColumn.DataPropertyName = "Seguro";
            this.seguroDataGridViewCheckBoxColumn.HeaderText = "Seguro";
            this.seguroDataGridViewCheckBoxColumn.Name = "seguroDataGridViewCheckBoxColumn";
            // 
            // tipoSeguroDataGridViewTextBoxColumn
            // 
            this.tipoSeguroDataGridViewTextBoxColumn.DataPropertyName = "TipoSeguro";
            this.tipoSeguroDataGridViewTextBoxColumn.HeaderText = "TipoSeguro";
            this.tipoSeguroDataGridViewTextBoxColumn.Name = "tipoSeguroDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // nuevosPacientesBindingSource
            // 
            this.nuevosPacientesBindingSource.DataMember = "Nuevos_Pacientes";
            this.nuevosPacientesBindingSource.DataSource = this.medicAppDataSet;
            // 
            // medicAppDataSet
            // 
            this.medicAppDataSet.DataSetName = "MedicAppDataSet";
            this.medicAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Atras2
            // 
            this.Atras2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Atras2.BackgroundImage")));
            this.Atras2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atras2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Atras2.Location = new System.Drawing.Point(501, 381);
            this.Atras2.Name = "Atras2";
            this.Atras2.Size = new System.Drawing.Size(53, 52);
            this.Atras2.TabIndex = 1;
            this.Atras2.UseVisualStyleBackColor = true;
            this.Atras2.Click += new System.EventHandler(this.button1_Click);
            // 
            // nuevos_PacientesTableAdapter
            // 
            this.nuevos_PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // PacientesC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 460);
            this.Controls.Add(this.Atras2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PacientesC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pacientes";
            this.Load += new System.EventHandler(this.PacientesC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevosPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicAppDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Atras2;
        private MedicAppDataSet medicAppDataSet;
        private System.Windows.Forms.BindingSource nuevosPacientesBindingSource;
        private MedicAppDataSetTableAdapters.Nuevos_PacientesTableAdapter nuevos_PacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNPacientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn consultaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seguroDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSeguroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}