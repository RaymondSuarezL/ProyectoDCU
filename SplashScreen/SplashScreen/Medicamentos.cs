﻿using System;
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
    public partial class Medicamentos : Form
    {
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicApp MApp = new MedicApp();
            MApp.Show();
            this.Hide();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'medicAppDataSet1.MedicamentosDisp' Puede moverla o quitarla según sea necesario.
            this.medicamentosDispTableAdapter.Fill(this.medicAppDataSet1.MedicamentosDisp);

        }
    }
}
