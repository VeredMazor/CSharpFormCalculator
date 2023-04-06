using System;
using System.Windows.Forms;

namespace CalculatorFormProject
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Button 1
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e) //Button 2
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "2";
        }
        private void button4_Click(object sender, EventArgs e) //Button 3
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e) //Button 4
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "4";
        }
        private void button8_Click(object sender, EventArgs e) //Button 5
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e) //Button 6
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e) //Button 7
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e) //Button 8
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e) //Button 9
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "9";
        }
        private void button0_Click(object sender, EventArgs e) //Button 0
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "0";
        }

        private void button10_Click_1(object sender, EventArgs e) //Button  .
        {
            this.main_num_label1.Text = this.main_num_label1.Text + ".";
        }

        private void button19_Click(object sender, EventArgs e) //Button C
        {
            this.main_num_label1.ResetText();

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //Button +
        {
            this.operator_label.Text = "+";
            if (this.main_num_label1.Text != "")
                this.first_num_label.Text += this.main_num_label1.Text;
            this.main_num_label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e) //Button x
        {
            this.operator_label.Text = "x";
            if (this.main_num_label1.Text != "")
                this.first_num_label.Text += this.main_num_label1.Text;
            this.main_num_label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e) //Button -
        {
            this.operator_label.Text = "-";
            if (this.main_num_label1.Text != "")
                this.first_num_label.Text += this.main_num_label1.Text;
            this.main_num_label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e) //Button ÷
        {
            this.operator_label.Text = "÷";
            if (this.main_num_label1.Text != "")
                this.first_num_label.Text += this.main_num_label1.Text;
            this.main_num_label1.Text = "";
        }

        private void button11_Click_1(object sender, EventArgs e) //Button =
        {
            double fn;
            double sn;
            double r=0;
            double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.main_num_label1.Text, out sn);
            if (this.operator_label.Text == "+")
                r = fn + sn;
            if (this.operator_label.Text == "-")
                r = fn - sn;
            if (this.operator_label.Text == "x")
                r = fn * sn;
            if (this.operator_label.Text == "÷")
                r = fn / sn;
            this.main_num_label1.Text = r.ToString();
            this.operator_label.Text = "";
            this.first_num_label.Text = "";
        }


    }
}
