using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class InicioSplash : Form
    {
        public InicioSplash()
        {
            InitializeComponent();
        }

        private void InicioSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProB.Increment(1);
            LBPorcentaje.Text = ProB.Value.ToString() + "%";

            if (ProB.Value == ProB.Maximum)
            {
                Timer.Stop();
                this.Hide();
                Login Login = new Login();
                Login.ShowDialog();
            }
        }

        private void InicioSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
