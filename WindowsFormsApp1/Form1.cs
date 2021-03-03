using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formTaschenrechner : Form
    {
        public formTaschenrechner()
        {
            InitializeComponent();
        }

        private void btnBigButton_Click(object sender, EventArgs e)
        {
            double ergebnis;

            bool check1 = false;
            bool check2 = false;
            bool check3 = true;

            check1 = Int32.TryParse(textBox_Zahl1.Text, out int zahl1);
            label5.Visible = !check1;
            if (check1 == false)
            {
                label5.Text = "Muss eine Zahl sein!";
            }
            check2 = Int32.TryParse(textBox_Zahl2.Text, out int zahl2);
            label6.Visible = !check2;
            if (check2 == false)
            {
                label6.Text = "Muss eine Zahl sein!";
                
            }
            string rechenop = textBox_Operator.Text;
            
            if (rechenop != "+" && rechenop != "-" && rechenop != "/" && rechenop != "*")
            {
                label7.Text = "Muss sich um einen der folgenden Operatoren handeln: + - / *";
                check3 = false;
            }
            label7.Visible = !check3;
            switch (rechenop)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    textBox_Ergebnis.Text = Convert.ToString(ergebnis);
                    break;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    textBox_Ergebnis.Text = Convert.ToString(ergebnis);
                    break;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    textBox_Ergebnis.Text = Convert.ToString(ergebnis);
                    break;
                case "/":
                    ergebnis = zahl1 / zahl2;
                    textBox_Ergebnis.Text = Convert.ToString(ergebnis);
                    break;
            }

        }

        private void textBox_Operator_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Ergebnis.AppendText("2");
            
        }

        private void textBox_Ergebnis_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Ergebnis.AppendText("+");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Ergebnis.AppendText("3");
        }

        private void textBox_Zahl2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
