using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double firstnumber;
        string rechenop;
        double secondnumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void nmb1_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
                ausgabeZahl.AppendText("1");
        }

        private void nmb2_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("2");
        }

        private void nmb3_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("3");
        }

        private void nmb4_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("4");
        }

        private void nmb5_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("5");
        }

        private void nmb6_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("6");
        }

        private void nmb7_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("7");
        }

        private void nmb8_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("8");
        }

        private void nmb9_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("9");
        }

        private void nmb0_Click(object sender, EventArgs e)
        {
            while (ausgabeZahl.Text == "+" || ausgabeZahl.Text == "-" || ausgabeZahl.Text == "/" || ausgabeZahl.Text == "*")
            {
                ausgabeZahl.Clear();
            }
            ausgabeZahl.AppendText("0");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToInt32(ausgabeZahl.Text);
            ausgabeZahl.Clear();
            rechenop = "+";
            ausgabeZahl.Text = "+";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToInt32(ausgabeZahl.Text);
            ausgabeZahl.Clear();
            rechenop = "*";
            ausgabeZahl.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToInt32(ausgabeZahl.Text);
            ausgabeZahl.Clear();
            rechenop = "/";
            ausgabeZahl.Text = "/";

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToInt32(ausgabeZahl.Text);
            ausgabeZahl.Clear();
            rechenop = "-";
        }

        private void btnErgebnis_Click(object sender, EventArgs e)
        {
            secondnumber = Convert.ToInt32(ausgabeZahl.Text);
            ausgabeZahl.Clear();
            switch (rechenop)
            {
                case "+":
                    double ergebnisplus = firstnumber + secondnumber;
                    ausgabeZahl.Text = Convert.ToString(ergebnisplus);
                    break;
                case "-":
                    double ergebnismunus = firstnumber - secondnumber;
                    ausgabeZahl.Text = Convert.ToString(ergebnismunus);
                    break;
                case "/":
                    double ergebnisdiv = firstnumber / secondnumber;
                    ausgabeZahl.Text = Convert.ToString(ergebnisdiv);
                    break;
                case "*":
                    double ergebnismult = firstnumber * secondnumber;
                    ausgabeZahl.Text = Convert.ToString(ergebnismult);
                    break;
            }
        }

        private void ausgabeZahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ausgabeZahl.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
