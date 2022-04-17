namespace SplashScreen
{
    partial class Soporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soporte));
            this.Atras5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBSopN = new System.Windows.Forms.TextBox();
            this.TBSopC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBSopD = new System.Windows.Forms.TextBox();
            this.BTEnviar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSoporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soporteRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicAppDataSet2 = new SplashScreen.MedicAppDataSet2();
            this.soporte_RequestTableAdapter = new SplashScreen.MedicAppDataSet2TableAdapters.Soporte_RequestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soporteRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicAppDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Atras5
            // 
            this.Atras5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Atras5.BackgroundImage")));
            this.Atras5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atras5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Atras5.Location = new System.Drawing.Point(399, 10);
            this.Atras5.Name = "Atras5";
            this.Atras5.Size = new System.Drawing.Size(37, 30);
            this.Atras5.TabIndex = 2;
            this.Atras5.UseVisualStyleBackColor = true;
            this.Atras5.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo";
            // 
            // TBSopN
            // 
            this.TBSopN.Location = new System.Drawing.Point(25, 36);
            this.TBSopN.Name = "TBSopN";
            this.TBSopN.Size = new System.Drawing.Size(242, 20);
            this.TBSopN.TabIndex = 5;
            // 
            // TBSopC
            // 
            this.TBSopC.Location = new System.Drawing.Point(25, 94);
            this.TBSopC.Name = "TBSopC";
            this.TBSopC.Size = new System.Drawing.Size(242, 20);
            this.TBSopC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripción";
            // 
            // TBSopD
            // 
            this.TBSopD.Location = new System.Drawing.Point(25, 153);
            this.TBSopD.Multiline = true;
            this.TBSopD.Name = "TBSopD";
            this.TBSopD.Size = new System.Drawing.Size(333, 183);
            this.TBSopD.TabIndex = 8;
            // 
            // BTEnviar
            // 
            this.BTEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTEnviar.BackgroundImage")));
            this.BTEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTEnviar.Location = new System.Drawing.Point(374, 276);
            this.BTEnviar.Name = "BTEnviar";
            this.BTEnviar.Size = new System.Drawing.Size(62, 60);
            this.BTEnviar.TabIndex = 9;
            this.BTEnviar.UseVisualStyleBackColor = true;
            this.BTEnviar.Click += new System.EventHandler(this.BTEnviar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSoporteDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.soporteRequestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(333, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(90, 53);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // iDSoporteDataGridViewTextBoxColumn
            // 
            this.iDSoporteDataGridViewTextBoxColumn.DataPropertyName = "ID_Soporte";
            this.iDSoporteDataGridViewTextBoxColumn.HeaderText = "ID_Soporte";
            this.iDSoporteDataGridViewTextBoxColumn.Name = "iDSoporteDataGridViewTextBoxColumn";
            this.iDSoporteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre_Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // soporteRequestBindingSource
            // 
            this.soporteRequestBindingSource.DataMember = "Soporte_Request";
            this.soporteRequestBindingSource.DataSource = this.medicAppDataSet2;
            // 
            // medicAppDataSet2
            // 
            this.medicAppDataSet2.DataSetName = "MedicAppDataSet2";
            this.medicAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soporte_RequestTableAdapter
            // 
            this.soporte_RequestTableAdapter.ClearBeforeFill = true;
            // 
            // Soporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 349);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTEnviar);
            this.Controls.Add(this.TBSopD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBSopC);
            this.Controls.Add(this.TBSopN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Atras5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Soporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soporte";
            this.Load += new System.EventHandler(this.Soporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soporteRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicAppDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Atras5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBSopN;
        private System.Windows.Forms.TextBox TBSopC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBSopD;
        private System.Windows.Forms.Button BTEnviar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MedicAppDataSet2 medicAppDataSet2;
        private System.Windows.Forms.BindingSource soporteRequestBindingSource;
        private MedicAppDataSet2TableAdapters.Soporte_RequestTableAdapter soporte_RequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSoporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}