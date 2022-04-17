using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SplashScreen
{
    public partial class NuevoP : Form
    {
        public NuevoP()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    String img = OpenFile.FileName;
                    PictureB.Image = Image.FromFile(img);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es valido");
            }
        }

        private void NuevoP_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = Actualizar();

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
            SqlConnection conexion = new SqlConnection("Server=(local) ; database=MedicApp ; integrated security = true;");
            conexion.Open();
            string Nombres = TXBNom.Text;
            string Apellidos = TXBApe.Text;
            bool Consulta = CBoxC.Checked;
            bool Seguro = CBoxS.Checked;
            string TipoSeguro = ComboSegu.Text;
            string Correo = TXCorre.Text;
            string Telefono = TXTele.Text;
            string Direccion = TXDire.Text;
            string cadena = "INSERT INTO Nuevos_Pacientes (Nombres, Apellidos, Consulta, Seguro, TipoSeguro, Correo, Telefono, Direccion) VALUES ('" + Nombres + "', '" + Apellidos + "', '" + Consulta + "', '" + Seguro + "', '" + Correo + "', '" + TipoSeguro + "', '" + Telefono + "', '" + Direccion + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos Agregado");
            dataGridView1.DataSource = Actualizar();
            TXBNom.Clear();
            TXBApe.Clear();
            TXCorre.Clear();
            TXDire.Clear(); 
            TXTele.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=(local) ; database=MedicApp ; integrated security = true;");
            conexion.Open();
            string eliminar = "DELETE FROM Nuevos_Pacientes WHERE ID_NPacientes = @ID_NPacientes";
            SqlCommand eliminarcmd = new SqlCommand(eliminar, conexion);
            eliminarcmd.Parameters.AddWithValue("@ID_NPacientes", textBox1.Text);



            eliminarcmd.ExecuteNonQuery();

            MessageBox.Show("Datos Eliminados Correctamente");

            dataGridView1.DataSource = Actualizar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicApp MApp = new MedicApp();
            MApp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=(local) ; database=MedicApp ; integrated security = true;");
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nuevos_Pacientes WHERE  Nombres = @Nombres", conexion);
            cmd.Parameters.AddWithValue("Nombres", TXBNom.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

