using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            button1.Height = panel1.Height / 6;
            button2.Height = panel1.Height / 6;
            button3.Height = panel1.Height / 6;
            button4.Height = panel1.Height / 6;
            button5.Height = panel1.Height / 6;
            button6.Height = panel1.Height / 6;
            button7.Height = panel1.Height / 6;
            button8.Height = panel1.Height / 6;
            button9.Height = panel1.Height / 6;
            button10.Height = panel1.Height / 6;
            button11.Height = panel1.Height / 6;
            button12.Height = panel1.Height / 6;
            button13.Height = panel1.Height / 6;
            button14.Height = panel1.Height / 6;
            button15.Height = panel1.Height / 6;
            button16.Height = panel1.Height / 6;
            button17.Height = panel1.Height / 6;
            button18.Height = panel1.Height / 6;
            button19.Height = panel1.Height / 6;
            button20.Height = panel1.Height / 6;
            button21.Height = panel1.Height / 6;
            button22.Height = panel1.Height / 6;
            button23.Height = panel1.Height / 6;
            button24.Height = panel1.Height / 6;

            button1.Width = panel1.Width / 4;
            button2.Width = panel1.Width / 4;
            button3.Width = panel1.Width / 4;
            button4.Width = panel1.Width / 4;
            button5.Width = panel1.Width / 4;
            button6.Width = panel1.Width / 4;
            button7.Width = panel1.Width / 4;
            button8.Width = panel1.Width / 4;
            button9.Width = panel1.Width / 4;
            button10.Width = panel1.Width / 4;
            button11.Width = panel1.Width / 4;
            button12.Width = panel1.Width / 4;
            button13.Width = panel1.Width / 4;
            button14.Width = panel1.Width / 4;
            button15.Width = panel1.Width / 4;
            button16.Width = panel1.Width / 4;
            button17.Width = panel1.Width / 4;
            button18.Width = panel1.Width / 4;
            button19.Width = panel1.Width / 4;
            button20.Width = panel1.Width / 4;
            button22.Width = panel1.Width / 4;
            button22.Width = panel1.Width / 4;
            button23.Width = panel1.Width / 4;
            button24.Width = panel1.Width / 4;

            button1.Top = 0;
            button2.Top = 0;
            button3.Top = 0;
            button4.Top = 0;

            button5.Top = panel1.Height/6;
            button6.Top = panel1.Height/6;
            button7.Top = panel1.Height / 6;
            button8.Top = panel1.Height / 6;

            button9.Top = 2*panel1.Height / 6;
            button10.Top = 2 * panel1.Height / 6;
            button11.Top = 2 * panel1.Height / 6;
            button12.Top = 2 * panel1.Height / 6;

            button13.Top = 3 * panel1.Height / 6;
            button14.Top = 3 * panel1.Height / 6;
            button15.Top = 3 * panel1.Height / 6;
            button16.Top = 3 * panel1.Height / 6;

            button17.Top = 4 * panel1.Height / 6;
            button18.Top = 4 * panel1.Height / 6;
            button19.Top = 4 * panel1.Height / 6;
            button20.Top = 4 * panel1.Height / 6;

            button21.Top = 5 * panel1.Height / 6;
            button22.Top = 5 * panel1.Height / 6;
            button23.Top = 5 * panel1.Height / 6;
            button24.Top = 5 * panel1.Height / 6;

            button1.Left = 0;
            button8.Left = 0;
            button12.Left = 0;
            button16.Left = 0;
            button20.Left = 0;
            button24.Left = 0;

            button2.Left = panel1.Width / 4;
            button7.Left = panel1.Width / 4;
            button11.Left = panel1.Width / 4;
            button15.Left = panel1.Width / 4;
            button19.Left = panel1.Width / 4;
            button23.Left = panel1.Width / 4;

            button3.Left = 2* panel1.Width / 4;
            button6.Left = 2* panel1.Width / 4;
            button10.Left = 2 * panel1.Width / 4;
            button14.Left = 2 * panel1.Width / 4;
            button18.Left = 2 * panel1.Width / 4;
            button22.Left = 2 * panel1.Width / 4;

            button4.Left = 3 * panel1.Width / 4;
            button5.Left = 3 * panel1.Width / 4;
            button9.Left = 3 * panel1.Width / 4;
            button13.Left = 3 * panel1.Width / 4;
            button17.Left = 3 * panel1.Width / 4;
            button21.Left = 3 * panel1.Width / 4;



        }


        private void button22_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if ((textBox1.Text == "0" && b.Text != ",") || textBox1.Text == "∞" || char.IsLetter(textBox1.Text[0]))
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.IndexOf(",") > 0 && b.Text == ",")
            {
                return;
            }
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (char.IsLetter(textBox1.Text[0]))
            {
                textBox1.Text = "0";
            }
            else if (textBox1.Text.Length - 1 == 0) textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        String action;
        String number1;
        private void button17_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            action = b.Text;
            number1 = textBox1.Text;
            textBox1.Text = "0";


        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (action == "+")
            {
                textBox1.Text = MathOp.plus(textBox1.Text, number1);

            }
            if (action == "-")
            {
                textBox1.Text = MathOp.minus(textBox1.Text, number1);
            }
            if (action == "*")
            {
                textBox1.Text = MathOp.multiplication(textBox1.Text, number1);
            }
            if (action == "/")
            {
                textBox1.Text = MathOp.division(textBox1.Text, number1);
            }
            if (action == "%")
            {
                textBox1.Text = MathOp.percent(textBox1.Text, number1);  
            }

            action = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = MathOp.oneDivisionX(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = MathOp.squareX(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = MathOp.sqrtX(textBox1.Text);
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = MathOp.plusMinusA(textBox1.Text);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            action = "%";
            number1 = textBox1.Text;
            textBox1.Text = "0";
        }
    }
}
