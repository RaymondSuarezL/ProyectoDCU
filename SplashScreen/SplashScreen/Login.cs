using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Server=(local) ; database=MedicApp ; integrated security = true;");

        private void button1_Click(object sender, EventArgs e)
        {
           conexion.Open();
           SqlCommand cmd = new SqlCommand("SELECT Usuario, Password FROM Usuarios WHERE Usuario = @User AND Password = @Pass", conexion);
            cmd.Parameters.AddWithValue("@User", TBUser.Text);
            cmd.Parameters.AddWithValue("@Pass", TBPass.Text);
          
            SqlDataReader lect = cmd.ExecuteReader();

            if (lect.Read()) 
            {
                conexion.Close();
                MedicApp MedA = new MedicApp();
                MedA.Show();
                this.Hide();
                TBUser.Clear();
                TBPass.Clear();
                
            }
            else 
            {
             
                MessageBox.Show("Usuario y/o Contraseña Incorrectas");
                TBUser.Clear();
                TBPass.Clear();
            }

            conexion.Close();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
