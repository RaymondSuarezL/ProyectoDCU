namespace SplashScreen
{
    partial class Medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamentos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDMedDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentosDispBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicAppDataSet1 = new SplashScreen.MedicAppDataSet1();
            this.Atras4 = new System.Windows.Forms.Button();
            this.medicamentosDispTableAdapter = new SplashScreen.MedicAppDataSet1TableAdapters.MedicamentosDispTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosDispBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicAppDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMedDDataGridViewTextBoxColumn,
            this.nombreMedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamentosDispBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDMedDDataGridViewTextBoxColumn
            // 
            this.iDMedDDataGridViewTextBoxColumn.DataPropertyName = "ID_MedD";
            this.iDMedDDataGridViewTextBoxColumn.HeaderText = "ID_MedD";
            this.iDMedDDataGridViewTextBoxColumn.Name = "iDMedDDataGridViewTextBoxColumn";
            this.iDMedDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMedDataGridViewTextBoxColumn
            // 
            this.nombreMedDataGridViewTextBoxColumn.DataPropertyName = "NombreMed";
            this.nombreMedDataGridViewTextBoxColumn.HeaderText = "NombreMed";
            this.nombreMedDataGridViewTextBoxColumn.Name = "nombreMedDataGridViewTextBoxColumn";
            // 
            // medicamentosDispBindingSource
            // 
            this.medicamentosDispBindingSource.DataMember = "MedicamentosDisp";
            this.medicamentosDispBindingSource.DataSource = this.medicAppDataSet1;
            // 
            // medicAppDataSet1
            // 
            this.medicAppDataSet1.DataSetName = "MedicAppDataSet1";
            this.medicAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Atras4
            // 
            this.Atras4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Atras4.BackgroundImage")));
            this.Atras4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atras4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Atras4.Location = new System.Drawing.Point(298, 389);
            this.Atras4.Name = "Atras4";
            this.Atras4.Size = new System.Drawing.Size(49, 46);
            this.Atras4.TabIndex = 2;
            this.Atras4.UseVisualStyleBackColor = true;
            this.Atras4.Click += new System.EventHandler(this.button1_Click);
            // 
            // medicamentosDispTableAdapter
            // 
            this.medicamentosDispTableAdapter.ClearBeforeFill = true;
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 460);
            this.Controls.Add(this.Atras4);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosDispBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicAppDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Atras4;
        private MedicAppDataSet1 medicAppDataSet1;
        private System.Windows.Forms.BindingSource medicamentosDispBindingSource;
        private MedicAppDataSet1TableAdapters.MedicamentosDispTableAdapter medicamentosDispTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMedDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMedDataGridViewTextBoxColumn;
    }
}