namespace SplashScreen
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BTLog = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.LBUser = new System.Windows.Forms.Label();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.LBPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTLog
            // 
            this.BTLog.BackColor = System.Drawing.Color.Transparent;
            this.BTLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTLog.BackgroundImage")));
            this.BTLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTLog.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTLog.Location = new System.Drawing.Point(272, 180);
            this.BTLog.Name = "BTLog";
            this.BTLog.Size = new System.Drawing.Size(106, 42);
            this.BTLog.TabIndex = 0;
            this.BTLog.Text = "Iniciar Sesión";
            this.BTLog.UseVisualStyleBackColor = false;
            this.BTLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // BExit
            // 
            this.BExit.BackColor = System.Drawing.Color.Transparent;
            this.BExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BExit.BackgroundImage")));
            this.BExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExit.Location = new System.Drawing.Point(1, 0);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(36, 34);
            this.BExit.TabIndex = 1;
            this.BExit.UseVisualStyleBackColor = false;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.BackColor = System.Drawing.Color.Transparent;
            this.LBUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBUser.Location = new System.Drawing.Point(230, 52);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(62, 16);
            this.LBUser.TabIndex = 2;
            this.LBUser.Text = "Usuario";
            // 
            // TBUser
            // 
            this.TBUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.Location = new System.Drawing.Point(233, 71);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(179, 26);
            this.TBUser.TabIndex = 3;
            // 
            // TBPass
            // 
            this.TBPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPass.Location = new System.Drawing.Point(233, 127);
            this.TBPass.Name = "TBPass";
            this.TBPass.PasswordChar = '*';
            this.TBPass.Size = new System.Drawing.Size(179, 26);
            this.TBPass.TabIndex = 5;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.BackColor = System.Drawing.Color.Transparent;
            this.LBPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBPass.Location = new System.Drawing.Point(230, 108);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(88, 16);
            this.LBPass.TabIndex = 4;
            this.LBPass.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gaban", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(41, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "MedicApp";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 245);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.LBUser);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BTLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTLog;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Label LBPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}