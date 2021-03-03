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
    public partial class Taschenrechner : Form
    {
        private bool HasBeenClicked = false;

        public Taschenrechner()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void nmb1_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("1");
            btnMult.Enabled = true;
        }

        private void nmb2_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("2");
        }

        private void nmb3_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("3");
        }

        private void nmb4_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("4");
        }

        private void nmb5_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("5");
        }

        private void nmb6_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("6");
        }

        private void nmb7_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("7");
        }

        private void nmb8_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("8");
        }

        private void nmb9_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("9");
        }

        private void nmb0_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("0");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("+");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (ausgabeZahl.TextLength >= 1)
            {
                ausgabeZahl.AppendText("*");
                btnMult.Enabled = false;
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("/");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("-");
        }

        private void btnErgebnis_Click(object sender, EventArgs e)
        {
            //List<string> result = ausgabeZahl.Text.Split(oper).ToList();
            //List<char> chars = ausgabeZahl.Text.Split().ToList();
            string math = ausgabeZahl.Text;
            string value = new DataTable().Compute(math, null).ToString();
            ausgabeZahl.Text = value;

        }

        private void ausgabeZahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ausgabeZahl.Clear();

        }

        private void btnKlammerauf_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText("(");
        }

        private void btnKlammerzu_Click(object sender, EventArgs e)
        {
            ausgabeZahl.AppendText(")");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
