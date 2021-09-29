using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double Penambahan(double a, double b)
        {
            return a + b;
        }
        private double Pengurangan(double a, double b)
        {
            return a - b;
        }
        private double Perkalian(double a, double b)
        {
            return a * b;
        }
        private double Pembagian(double a, double b)
        {
            return a / b;
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNilaiA.Text);
            double b = Convert.ToDouble(txtNilaiB.Text);

            lstHasil.Items.Clear();

            lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} x {1} = {2}", a, b, Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b)));
        }
    }
}
