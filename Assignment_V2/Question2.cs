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
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNo.Text);
            if (firstNumber % 2 == 0)
            {
                // label3.Text = $"{firstNumber} is an even number";
                MessageBox.Show($"{firstNumber} is an even number.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // label3.Text = $"{firstNumber} is an odd number";
                MessageBox.Show($"{firstNumber} is an odd number.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void display_Click(object sender, EventArgs e)
        {

            
        }

        private void display_Click_1(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNo.Text);
            if (firstNumber % 2 == 0)
            {
                ResultLabel.Text = $"{firstNumber} is an even number";

            }
            else
            {
                ResultLabel.Text = $"{firstNumber} is an odd number";

            }
        }

        
    }
}
