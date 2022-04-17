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
    public partial class PacientesC : Form
    {
        public PacientesC()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public DataTable Actualizar()
        {
            SqlConnection conexion = new SqlConnection("Server=(local) ; database=MedicApp ; integrated security = true;");
            conexion.Open();
            DataTable dt = new DataTable();
            string con = "SELECT * FROM Nuevos_Pacientes";
            SqlCommand comando = new SqlCommand(con, conexion);
            comando.ExecuteNonQuery();
            SqlDataAdapter Ada = new SqlDataAdapter(comando);
            Ada.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicApp MApp = new MedicApp();
            MApp.Show();
            this.Hide();
        }

        private void PacientesC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Actualizar();
        }
    }
}
