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
    public partial class MedicApp : Form
    {

        public MedicApp()
        {
            InitializeComponent();
        }

        private void BTNuevo_Click(object sender, EventArgs e)
        {
            NuevoP NP = new NuevoP();
            NP.Show();
            this.Hide();
        }

        private void BTPaC_Click(object sender, EventArgs e)
        {
            PacientesC PaC = new PacientesC();
            PaC.Show();
            this.Hide();
        }

        private void BTPaS_Click(object sender, EventArgs e)
        {
            Soporte PaS = new Soporte();
            PaS.Show();
            this.Hide();
        }

        private void BTMedi_Click(object sender, EventArgs e)
        {
            Medicamentos Med = new Medicamentos();
            Med.Show();
            this.Hide();
        }

        private void BTFact_Click(object sender, EventArgs e)
        {
            Creadores Cre = new Creadores();
            Cre.Show();
            this.Hide();
        }

        private void BTCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Seguro que quieres cerrar la sesión?", "Cerrar Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(Opcion == DialogResult.OK) 
            {
                Login Log = new Login();
                Log.Show();
                this.Hide();
            }
        }
    }
}
