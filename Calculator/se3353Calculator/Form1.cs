using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace se3353Calculator
{
    // Created by Ryan Hawkins for SE3353b Calculator Assignment
    // Due March 5th, 2018 at 3:00pm
    //
    // In RPN mode, the EQUALS(=) button has no function
    // In INFIX mode, the ENTER button has no function
    // Press CLR after switching modes to avoid bugs
    // RPN mode must follow the order: NUMBER(S) -> ENTER -> NUMBER(S) -> OPERATOR -> [NUMBER(S) -> OPERATOR]*
    // INFIX mode must follow the order: NUMBER(S) -> OPERATOR -> NUMBER(S) -> [OPERATOR -> NUMBER(S)]* -> EQUALS(=))
    // The []* notation means that whatever is in the bracket can be repeated 0 or more times

    public partial class Form1 : Form
    {

        string input = string.Empty;
        double ans = 0;
        int count;
        string op;
        bool RPN = false;
        string stored1 = string.Empty;
        string stored2 = string.Empty;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            input += 1;
            textBox1.Text += input;

            if(RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 2;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 3;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 4;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 5;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 6;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 7;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 8;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 9;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += 0;
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input += ".";
            textBox1.Text += input;

            if (RPN && stored1 != string.Empty)
            {
                stored2 = textBox1.Text;
            }
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input = string.Empty;
            stored1 = string.Empty;
            stored2 = string.Empty;
            ans = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (RPN == false)
            {

                if (ans == 0)
                {
                    ans = double.Parse(input);
                    textBox1.Clear();
                    textBox1.Focus();
                    input = string.Empty;
                }
                else
                {

                    if (op == "+")
                    {
                        ans = ans + double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "-")
                    {
                        ans = ans - double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "*")
                    {
                        ans = ans * double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "/")
                    {
                        ans = ans / double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }

                    input = string.Empty;
                }
                count = 1;
                op = "+";
            }

            else
            {
                if (stored1 != string.Empty && stored2 != string.Empty)
                {
                    ans = double.Parse(stored1) + double.Parse(stored2);
                    textBox1.Text = ans.ToString();
                    stored1 = ans.ToString();
                    input = string.Empty;
                }

            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (RPN == false)
            {
                if (ans == 0)
                {
                    ans = double.Parse(input);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {

                    if (op == "+")
                    {
                        ans = ans + double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "-")
                    {
                        ans = ans - double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "*")
                    {
                        ans = ans * double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "/")
                    {
                        ans = ans / double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }

                    input = string.Empty;
                }
                count = 2;
                op = "-";
            }

            else
            {
                if (stored1 != string.Empty && stored2 != string.Empty)
                {
                    ans = double.Parse(stored1) - double.Parse(stored2);
                    textBox1.Text = ans.ToString();
                    stored1 = ans.ToString();
                    input = string.Empty;
                }

            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (RPN == false)
            {
                if (ans == 0)
                {
                    ans = double.Parse(input);
                    input = string.Empty;
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    if (op == "+")
                    {
                        ans = ans + double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "-")
                    {
                        ans = ans - double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "*")
                    {
                        ans = ans * double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "/")
                    {
                        ans = ans / double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }

                    input = string.Empty;
                }
                count = 3;
                op = "*";
            }

            else
            {
                if (stored1 != string.Empty && stored2 != string.Empty)
                {
                    ans = double.Parse(stored1) * double.Parse(stored2);
                    textBox1.Text = ans.ToString();
                    stored1 = ans.ToString();
                    input = string.Empty;
                }

            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (RPN == false)
            {
                if (ans == 0)
                {
                    ans = double.Parse(input);
                    input = System.String.Empty;
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    if (op == "+")
                    {
                        ans = ans + double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "-")
                    {
                        ans = ans - double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "*")
                    {
                        ans = ans * double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }
                    else if (op == "/")
                    {
                        ans = ans / double.Parse(input);
                        textBox1.Text = ans.ToString();
                    }

                    input = string.Empty;
                }
                count = 4;
                op = "/";
            }

            else
            {
                if (stored1 != string.Empty && stored2 != string.Empty)
                {
                    ans = double.Parse(stored1) / double.Parse(stored2);
                    textBox1.Text = ans.ToString();
                    stored1 = ans.ToString();
                    input = string.Empty;
                }

            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (RPN == false)
            {
                operate();
            }
        }

        private void buttonRPN_Click(object sender, EventArgs e)
        {
            RPN = true;
            label1.Text = "RPN";
        }

        private void buttonINFIX_Click(object sender, EventArgs e)
        {
            RPN = false;
            label1.Text = "INFIX";
        }

        public void operate()
        {
            switch (count)
            {
                case 1:
                    ans = ans + double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    input = textBox1.Text;
                    break;

                case 2:
                    ans = ans - double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    input = textBox1.Text;
                    break;

                case 3:
                    ans = ans * double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    input = textBox1.Text;
                    break;

                case 4:
                    ans = ans / double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    input = textBox1.Text;
                    break;

                default:
                    break;
            }
            ans = 0;
        }

        private void buttonENTER_Click(object sender, EventArgs e)
        {
            if (RPN && stored1 == string.Empty)
            {
                stored1 = textBox1.Text;
                textBox1.Clear();
                input = string.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
