namespace SplashScreen
{
    partial class NuevoP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoP));
            this.TXBNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXBApe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboSegu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTele = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXCorre = new System.Windows.Forms.TextBox();
            this.TXDire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTAdd = new System.Windows.Forms.Button();
            this.BTDel = new System.Windows.Forms.Button();
            this.BTSear = new System.Windows.Forms.Button();
            this.Atras1 = new System.Windows.Forms.Button();
            this.AddIma = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.PictureB = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBoxC = new System.Windows.Forms.CheckBox();
            this.CBoxS = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PictureB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXBNom
            // 
            this.TXBNom.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBNom.Location = new System.Drawing.Point(41, 151);
            this.TXBNom.Multiline = true;
            this.TXBNom.Name = "TXBNom";
            this.TXBNom.Size = new System.Drawing.Size(203, 18);
            this.TXBNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            // 
            // TXBApe
            // 
            this.TXBApe.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBApe.Location = new System.Drawing.Point(41, 212);
            this.TXBApe.Multiline = true;
            this.TXBApe.Name = "TXBApe";
            this.TXBApe.Size = new System.Drawing.Size(203, 18);
            this.TXBApe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(105, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consulta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(326, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Seguro:";
            // 
            // ComboSegu
            // 
            this.ComboSegu.FormattingEnabled = true;
            this.ComboSegu.Items.AddRange(new object[] {
            "Primera ARS de Humano",
            "Mapfre Salud ARS",
            "ARS Universal",
            "ARS SIMAG",
            "ARS Yunen ",
            "ARS Monumental"});
            this.ComboSegu.Location = new System.Drawing.Point(329, 307);
            this.ComboSegu.Name = "ComboSegu";
            this.ComboSegu.Size = new System.Drawing.Size(121, 21);
            this.ComboSegu.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(240, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seguro:";
            // 
            // TXTele
            // 
            this.TXTele.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTele.Location = new System.Drawing.Point(283, 212);
            this.TXTele.Multiline = true;
            this.TXTele.Name = "TXTele";
            this.TXTele.Size = new System.Drawing.Size(203, 18);
            this.TXTele.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(286, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(286, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Correo:";
            // 
            // TXCorre
            // 
            this.TXCorre.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXCorre.Location = new System.Drawing.Point(283, 151);
            this.TXCorre.Multiline = true;
            this.TXCorre.Name = "TXCorre";
            this.TXCorre.Size = new System.Drawing.Size(203, 18);
            this.TXCorre.TabIndex = 12;
            // 
            // TXDire
            // 
            this.TXDire.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXDire.Location = new System.Drawing.Point(172, 262);
            this.TXDire.Multiline = true;
            this.TXDire.Name = "TXDire";
            this.TXDire.Size = new System.Drawing.Size(203, 18);
            this.TXDire.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(175, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dirección:";
            // 
            // BTAdd
            // 
            this.BTAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTAdd.BackgroundImage")));
            this.BTAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTAdd.Location = new System.Drawing.Point(15, 542);
            this.BTAdd.Name = "BTAdd";
            this.BTAdd.Size = new System.Drawing.Size(79, 73);
            this.BTAdd.TabIndex = 18;
            this.BTAdd.UseVisualStyleBackColor = true;
            this.BTAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTDel
            // 
            this.BTDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTDel.BackgroundImage")));
            this.BTDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTDel.Location = new System.Drawing.Point(164, 542);
            this.BTDel.Name = "BTDel";
            this.BTDel.Size = new System.Drawing.Size(79, 73);
            this.BTDel.TabIndex = 20;
            this.BTDel.UseVisualStyleBackColor = true;
            this.BTDel.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTSear
            // 
            this.BTSear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTSear.BackgroundImage")));
            this.BTSear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTSear.Location = new System.Drawing.Point(306, 542);
            this.BTSear.Name = "BTSear";
            this.BTSear.Size = new System.Drawing.Size(79, 73);
            this.BTSear.TabIndex = 21;
            this.BTSear.UseVisualStyleBackColor = true;
            this.BTSear.Click += new System.EventHandler(this.button4_Click);
            // 
            // Atras1
            // 
            this.Atras1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Atras1.BackgroundImage")));
            this.Atras1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atras1.Location = new System.Drawing.Point(442, 542);
            this.Atras1.Name = "Atras1";
            this.Atras1.Size = new System.Drawing.Size(79, 73);
            this.Atras1.TabIndex = 22;
            this.Atras1.UseVisualStyleBackColor = true;
            this.Atras1.Click += new System.EventHandler(this.button5_Click);
            // 
            // AddIma
            // 
            this.AddIma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddIma.BackgroundImage")));
            this.AddIma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddIma.Location = new System.Drawing.Point(342, 58);
            this.AddIma.Name = "AddIma";
            this.AddIma.Size = new System.Drawing.Size(33, 32);
            this.AddIma.TabIndex = 25;
            this.AddIma.UseVisualStyleBackColor = true;
            this.AddIma.Click += new System.EventHandler(this.button6_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // PictureB
            // 
            this.PictureB.BackColor = System.Drawing.Color.White;
            this.PictureB.Location = new System.Drawing.Point(201, 23);
            this.PictureB.Name = "PictureB";
            this.PictureB.Size = new System.Drawing.Size(129, 109);
            this.PictureB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureB.TabIndex = 26;
            this.PictureB.TabStop = false;
            this.PictureB.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(207, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Adjuntar Imagen";
            // 
            // CBoxC
            // 
            this.CBoxC.AutoSize = true;
            this.CBoxC.BackColor = System.Drawing.Color.Transparent;
            this.CBoxC.Location = new System.Drawing.Point(135, 310);
            this.CBoxC.Name = "CBoxC";
            this.CBoxC.Size = new System.Drawing.Size(15, 14);
            this.CBoxC.TabIndex = 29;
            this.CBoxC.UseVisualStyleBackColor = false;
            // 
            // CBoxS
            // 
            this.CBoxS.AutoSize = true;
            this.CBoxS.BackColor = System.Drawing.Color.Transparent;
            this.CBoxS.Location = new System.Drawing.Point(257, 310);
            this.CBoxS.Name = "CBoxS";
            this.CBoxS.Size = new System.Drawing.Size(15, 14);
            this.CBoxS.TabIndex = 30;
            this.CBoxS.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 18);
            this.textBox1.TabIndex = 31;
            this.textBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 175);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NuevoP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CBoxS);
            this.Controls.Add(this.CBoxC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddIma);
            this.Controls.Add(this.PictureB);
            this.Controls.Add(this.Atras1);
            this.Controls.Add(this.BTSear);
            this.Controls.Add(this.BTDel);
            this.Controls.Add(this.BTAdd);
            this.Controls.Add(this.TXDire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXCorre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboSegu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXBApe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXBNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoP";
            this.Load += new System.EventHandler(this.NuevoP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXBApe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboSegu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXCorre;
        private System.Windows.Forms.TextBox TXDire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTAdd;
        private System.Windows.Forms.Button BTDel;
        private System.Windows.Forms.Button BTSear;
        private System.Windows.Forms.Button Atras1;
        private System.Windows.Forms.Button AddIma;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.PictureBox PictureB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CBoxC;
        private System.Windows.Forms.CheckBox CBoxS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}