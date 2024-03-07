using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_V2
{
    public partial class Question16 : Form
    {
        public Question16()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            int digit = Convert.ToInt32(firstNo.Text);
            string word = "";

            switch (digit)
            {
                case 0:
                    word = "Zero";
                    break;
                case 1:
                    word = "One";
                    break;
                case 2:
                    word = "Two";
                    break;
                case 3:
                    word = "Three";
                    break;
                case 4:
                    word = "Four";
                    break;
                case 5:
                    word = "Five";
                    break;
                case 6:
                    word = "Six";
                    break;
                case 7:
                    word = "Seven";
                    break;
                case 8:
                    word = "Eight";
                    break;
                case 9:
                    word = "Nine";
                    break;
                default:
                    word = "Invalid digit";
                    break;
            }
            ResultLabel.Text = $"{word}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textBoxValue = firstNo.Text;

            // Try to convert the input to an integer
            try
            {
                int digit = Convert.ToInt32(textBoxValue);
                MessageBox.Show("The input is a number: " + digit);
                string word = "";
                switch (digit)
                {
                    case 0:
                        word = "Zero";
                        break;
                    case 1:
                        word = "One";
                        break;
                    case 2:
                        word = "Two";
                        break;
                    case 3:
                        word = "Three";
                        break;
                    case 4:
                        word = "Four";
                        break;
                    case 5:
                        word = "Five";
                        break;
                    case 6:
                        word = "Six";
                        break;
                    case 7:
                        word = "Seven";
                        break;
                    case 8:
                        word = "Eight";
                        break;
                    case 9:
                        word = "Nine";
                        break;
                    default:
                        word = "Invalid digit";
                        break;
                }
                MessageBox.Show($"{word}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("The input is not a number.");
            }
        }

        private void checkButton2_Click(object sender, EventArgs e)
        {
            string textBoxValue = integerText.Text;

            // Try to convert the input to an integer
            try
            {
                int digit = Convert.ToInt32(textBoxValue);
                displayLabel.Text = $"The input is a number/n";

                string text = digit.ToString();
                displayLabel.Text += $"{text}";
            }
            catch (FormatException)
            {
                MessageBox.Show("The input is not a number.");
            }
        }

       
    }
}
