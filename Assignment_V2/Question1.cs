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
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();

            //clear all the text boxes
            firstNo.Text = "";
            secondNo.Text = "";
        }


        //show the result as a message
        private void checkButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNo.Text);
            int secondNumber = Convert.ToInt32(secondNo.Text);

            if (firstNumber == secondNumber)
            {
               
                MessageBox.Show($"{firstNumber} and {secondNumber} are equal.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(firstNumber > secondNumber)
                {
                    MessageBox.Show($"{firstNumber} and {secondNumber} are not equal and {firstNumber} is greater than {secondNumber} ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{firstNumber} and {secondNumber} are not equal and {secondNumber} is greater than {firstNumber} ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        //show the result as a text
        private void display_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNo.Text);
            int secondNumber = Convert.ToInt32(secondNo.Text);

            if (firstNumber == secondNumber)
            {
                ResultLabel.Text = $"{firstNumber} and {secondNumber} are equal.";
               
            }
            else
            {
                if (firstNumber > secondNumber)
                {
                    ResultLabel.Text = $"{firstNumber} and {secondNumber} are not equal. and {firstNumber} is greater than {secondNumber} ";
                }
                else
                {
                    ResultLabel.Text = $"{firstNumber} and {secondNumber} are not equal. and {secondNumber} is greater than {firstNumber} ";
                }

            }
        }

        
    }
}
