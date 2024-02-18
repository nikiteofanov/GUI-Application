using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrencyConverter converter = new CurrencyConverter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox1.Text);
            double bgntoeur = amount * 0.51;
            textBox2.Text = bgntoeur.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double amount2 = Convert.ToDouble(textBox4.Text);
            double eurtobgn = amount2 * 1.96;
            textBox3.Text = eurtobgn.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class CurrencyConverter
    {
        public void Run()
        {

        }

        private void ConvertBgnToEur()
        {
            double amount = Convert.ToDouble(Console.ReadLine());
            double bgntoeur = amount * 0.51;
            Console.WriteLine($"{amount} in Euros is {bgntoeur}");
        }

        private void ConvertEurToBgn()
        {
            Console.WriteLine("Enter the amount in EUR you want to convert: ");
            double amount2 = Convert.ToDouble(Console.ReadLine());
            double eurtobgn = amount2 * 1.96;
            Console.WriteLine($"{amount2} in Euros is {eurtobgn}");
        }
    }

}
