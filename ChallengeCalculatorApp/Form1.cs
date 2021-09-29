using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNilaiA.Text);
            double b = double.Parse(txtNilaiB.Text);


            int idx = comboBoxOperasi.SelectedIndex;
            maskedTextBoxHasil.Clear();
            if (idx == 0) maskedTextBoxHasil.AppendText(Penambahan(a,b).ToString());
            if (idx == 1) maskedTextBoxHasil.AppendText(Pengurangan(a,b).ToString());
            if (idx == 2) maskedTextBoxHasil.AppendText(Perkalian(a,b).ToString());
            if (idx == 3) maskedTextBoxHasil.AppendText(Pembagian(a,b).ToString());
        }
    }
}
