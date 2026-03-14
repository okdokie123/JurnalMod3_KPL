using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Modul3_103022400007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                return;
            }

            if (!double.TryParse(textBox1.Text, out double nilaiAwal))
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }

            string satuanAwal = comboBox1.SelectedItem.ToString();
            string satuanAkhir = comboBox2.SelectedItem.ToString();
            double suhuCelcius = 0;
            double hasilAkhir = 0;

            switch (satuanAwal)
            {
                case "Celcius": suhuCelcius = nilaiAwal; break;
                case "Fahrenheit": suhuCelcius = (nilaiAwal - 32) * 5.0 / 9.0; break;
                case "Kelvin": suhuCelcius = nilaiAwal - 273.15; break;
                case "Reamur": suhuCelcius = nilaiAwal * 5.0 / 4.0; break;
            }

            switch (satuanAkhir)
            {
                case "Celcius": hasilAkhir = suhuCelcius; break;
                case "Fahrenheit": hasilAkhir = (suhuCelcius * 9.0 / 5.0) + 32; break;
                case "Kelvin": hasilAkhir = suhuCelcius + 273.15; break;
                case "Reamur": hasilAkhir = suhuCelcius * 4.0 / 5.0; break;
            }

            textBox2.Text = Math.Round(hasilAkhir, 2).ToString();
        } 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
