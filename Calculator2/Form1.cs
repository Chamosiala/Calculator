using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    
    public partial class Form1 : Form
    {
        //Checks and applies the last operation
        public void CheckPreviousOperation()
        {

            if (addition)
                currentNum += Convert.ToDecimal(calculatorScreen.Text);
            else if (subtraction)
                currentNum -= Convert.ToDecimal(calculatorScreen.Text);
            else if (multiplication)
                currentNum *= Convert.ToDecimal(calculatorScreen.Text);
            else if (division)
                currentNum /= Convert.ToDecimal(calculatorScreen.Text);

            addition = false; subtraction = false; multiplication = false; division = false;
        }
        
        //Checks if the current shown number is the result of a previous operation
        public void CheckEqual(char sign)
        {
            if (equaled == false)
                calculatorHistory.Text += $" {calculatorScreen.Text} {sign}";
            else
            {
                calculatorHistory.Text = $"{currentNum} {sign}";
                equaled = false;
            }
        }
        
        //Stack<long> history = new Stack<long>();
        decimal currentNum = 0;
        static bool addition = false,  subtraction = false, equaled = false, multiplication = false, division = false;
        static bool previouslyOperated = false;
        
        public Form1()
        {
            InitializeComponent();
            
            // calculatorScreen.Text = currentNum.ToString();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }

            calculatorScreen.Text += "1";
            //currentNum *= 10;
            //currentNum += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            calculatorScreen.Text += "2";
            //currentNum *= 10;
            //currentNum += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            calculatorScreen.Text += "3";
            //currentNum *= 10;
            //currentNum += 3;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            calculatorScreen.Text += "4";
            //currentNum *= 10;
            //currentNum += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            calculatorScreen.Text += "5";
            //currentNum *= 10;
            //currentNum += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            calculatorScreen.Text += "6";
            //currentNum *= 10;
            //currentNum += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            calculatorScreen.Text += "7";
            //currentNum *= 10;
            //currentNum += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            calculatorScreen.Text += "8";
            //currentNum *= 10;
            //currentNum += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            calculatorScreen.Text += "9";
            //currentNum *= 10;
            //currentNum += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (equaled)
            {
                calculatorScreen.Text = "";
                calculatorHistory.Text = "";
                equaled = false;
            }
            if (calculatorScreen.Text != "0")
                calculatorScreen.Text += "0";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "")
                calculatorScreen.Text = "0";


            if (previouslyOperated)
                CheckPreviousOperation();
            else
                try
                {
                    currentNum += Convert.ToDecimal(calculatorScreen.Text);
                }
                catch (FormatException)
                {
                    calculatorScreen.Text = "0";
                    currentNum += Convert.ToDecimal(calculatorScreen.Text);
                }

            CheckEqual('+');

            calculatorScreen.Text = "";
            addition = true;
            previouslyOperated = true;
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "")
                calculatorScreen.Text = "0";

            if (currentNum == 0)
                currentNum = Convert.ToDecimal(calculatorScreen.Text);
            else if (previouslyOperated)
                CheckPreviousOperation();
            else
                try
                {
                    currentNum -= Convert.ToDecimal(calculatorScreen.Text);
                }
                catch (FormatException)
                {
                    calculatorScreen.Text = "0";
                    currentNum -= Convert.ToDecimal(calculatorScreen.Text);
                }

            CheckEqual('-');

            calculatorScreen.Text = "";
            subtraction = true;
            previouslyOperated = true;
        }

        private void calculatorScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearExpressionButton_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "";
        }


        private void clearAllButton_Click(object sender, EventArgs e)
        {
            currentNum = 0;
            calculatorHistory.Text = "";
            calculatorScreen.Text = "";
            addition = false; subtraction = false; equaled = false;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "")
                calculatorScreen.Text = "0";
            else if ((calculatorHistory.Text == "" || equaled) && calculatorScreen.Text != "Cannot divide by zero")
                currentNum = Convert.ToDecimal(calculatorScreen.Text);
            else if (previouslyOperated)
                CheckPreviousOperation();
            else
                try
                {
                    currentNum *= Convert.ToDecimal(calculatorScreen.Text);
                }
                catch (FormatException)
                {
                    calculatorScreen.Text = "0";
                    currentNum *= Convert.ToDecimal(calculatorScreen.Text);
                }

            CheckEqual('x');


            calculatorScreen.Text = "";
            multiplication = true;
            previouslyOperated = true;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "")
                calculatorScreen.Text = "0";
            else if ((calculatorHistory.Text == "" || equaled) && calculatorScreen.Text != "Cannot divide by zero")
                currentNum = Convert.ToDecimal(calculatorScreen.Text);
            else if (previouslyOperated)
                CheckPreviousOperation();
            else
                try
                {
                    currentNum /= Convert.ToDecimal(calculatorScreen.Text);
                }
                catch (DivideByZeroException)
                {
                    calculatorScreen.Text = "Cannot divide by zero";
                    equaled = true;
                    currentNum = 0;
                    previouslyOperated = false; addition = false; subtraction = false; multiplication = false; division = false;
                }
                catch (FormatException)
                {
                    calculatorScreen.Text = "0";
                }

            CheckEqual('÷');


            calculatorScreen.Text = "";
            division = true;
            previouslyOperated = true;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            calculatorHistory.Text += $" {calculatorScreen.Text} =";
            equaled = true;

            if (addition)
                calculatorScreen.Text = (currentNum + Convert.ToDecimal(calculatorScreen.Text)).ToString();
            else if (subtraction)
                calculatorScreen.Text = (currentNum - Convert.ToDecimal(calculatorScreen.Text)).ToString();
            else if (multiplication)
                calculatorScreen.Text = (currentNum * Convert.ToDecimal(calculatorScreen.Text)).ToString();
            else if (division)
            {
                try
                {
                    calculatorScreen.Text = (currentNum / Convert.ToDecimal(calculatorScreen.Text)).ToString();
                }
                catch (DivideByZeroException)
                {
                    calculatorScreen.Text = "Cannot divide by zero";
                }
            }
            previouslyOperated = false; addition = false; subtraction = false; multiplication = false; division = false;
            currentNum = 0;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
                case Keys.NumPad0:
                    button0.PerformClick();
                    break;
                case Keys.Subtract:
                    subtractionButton.PerformClick();
                    break;
                case Keys.Add:
                    additionButton.PerformClick();
                    break;
                default:
                    break;
            }    
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
