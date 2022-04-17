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
    public partial class Soporte : Form
    {
        public Soporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicApp MApp = new MedicApp();
            MApp.Show();
            this.Hide();
        }

        private void Soporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'medicAppDataSet2.Soporte_Request' Puede moverla o quitarla según sea necesario.
            dataGridView1.DataSource = Actualizar();

        }
        public DataTable Actualizar()
        {
            SqlConnection conexion = new SqlConnection("Server=(local) ; database=MedicApp ; integrated security = true;");
            conexion.Open();
            DataTable dt = new DataTable();
            string con = "SELECT * FROM Soporte_Request";
            SqlCommand comando = new SqlCommand(con, conexion);
            comando.ExecuteNonQuery();
            SqlDataAdapter Ada = new SqlDataAdapter(comando);
            Ada.Fill(dt);
            return dt;
        }

        private void BTEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=(local) ; database=MedicApp ; integrated security = true;");
            conexion.Open();
            string NombreC = TBSopN.Text;
            string Correo = TBSopC.Text;    
            string Descrp = TBSopD.Text;
            string cadena = "INSERT INTO Soporte_Request(Nombre_Completo, Correo, Descripcion) VALUES ('" + NombreC + "', '" + Correo + "', '" + Descrp + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Reporte Enviado");
            dataGridView1.DataSource = Actualizar();
            TBSopN.Clear();
            TBSopC.Clear();
            TBSopD.Clear();
        }

        
    }
}
