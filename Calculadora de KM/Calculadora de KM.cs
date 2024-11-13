using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_KM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BCal_Click(object sender, EventArgs e)
        {
            
            if (txtMin.Text == "" || txtMax.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Por favor, debe completar todos los campos.");
                return;
            }
            double consumoMin = Convert.ToDouble(txtMin.Text);
            double consumoMax = Convert.ToDouble(txtMax.Text);
            double precioPorGalon = Convert.ToDouble (txtPrecio.Text);

            dataGridView1.Rows.Clear();

            for (double ConsumoActual = consumoMin; ConsumoActual <= consumoMax;)
            {
                double costoporKM = (ConsumoActual / 100) * precioPorGalon;
                double kmporGalon = 100 / ConsumoActual;

                dataGridView1.Rows.Add(Math.Round(ConsumoActual, 1), Math.Round(costoporKM,2), Math.Round(kmporGalon, 2));
            }
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BBorra_Click(object sender, EventArgs e)
        {
            txtMin.Text = "";
            txtMax.Text = "";
            txtPrecio.Text = "";
            dataGridView1.Rows.Clear ();
        }
    }
}
