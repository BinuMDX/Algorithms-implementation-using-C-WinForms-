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
    public partial class Question20 : Form
    {
        public Question20()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            int firstNo = Convert.ToInt32(firstNoText.Text);
            int secondNo = Convert.ToInt32(secondNoText.Text);
            int choice = Convert.ToInt32(thirdNoText.Text);
            

            /*Here are the options :
                1-Addition.
                2-Substraction.
                3-Multiplication.
                4-Division.
                5-Exit.*/

            switch (choice)
            {
                case 1:
                    ResultLabel.Text = $"The Addition of {firstNo} and {secondNo} is: { firstNo + secondNo}";
                    break;
                case 2:
                    ResultLabel.Text = $"The Substraction of {firstNo} and {secondNo} is: { firstNo - secondNo}";
                    break;
                case 3:
                    ResultLabel.Text = $"The Multiplication of {firstNo} and {secondNo} is: { firstNo * secondNo}";
                    break;
                case 4:
                    if(secondNo == 0)
                    {
                        ResultLabel.Text = "Cannot divide by zero.";
                    }
                    else
                    {
                        ResultLabel.Text = $"The Addition of {firstNo} and {secondNo} is: { firstNo + (double)secondNo}";
                    }
                    break;
                case 5:
                    ResultLabel.Text = "Exiting...";
                    break;
                default:
                    ResultLabel.Text = "Invalid choice";
                    break;

            } 

           

        }
    }
}
