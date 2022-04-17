namespace SplashScreen
{
    partial class InicioSplash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSplash));
            this.LBPorcentaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProB = new System.Windows.Forms.ProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LBPorcentaje
            // 
            this.LBPorcentaje.AutoSize = true;
            this.LBPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.LBPorcentaje.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPorcentaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBPorcentaje.Location = new System.Drawing.Point(173, 158);
            this.LBPorcentaje.Name = "LBPorcentaje";
            this.LBPorcentaje.Size = new System.Drawing.Size(25, 16);
            this.LBPorcentaje.TabIndex = 5;
            this.LBPorcentaje.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gaban", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(114, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "MedicApp";
            // 
            // ProB
            // 
            this.ProB.Location = new System.Drawing.Point(66, 140);
            this.ProB.Name = "ProB";
            this.ProB.Size = new System.Drawing.Size(242, 15);
            this.ProB.TabIndex = 3;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 45;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // InicioSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 189);
            this.ControlBox = false;
            this.Controls.Add(this.LBPorcentaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSplash_FormClosing);
            this.Load += new System.EventHandler(this.InicioSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProB;
        private System.Windows.Forms.Timer Timer;
    }
}

