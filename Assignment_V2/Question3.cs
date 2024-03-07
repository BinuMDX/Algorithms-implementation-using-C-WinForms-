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
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        

        private void display_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNo.Text);
            if (firstNumber > 0)
            {
                ResultLabel.Text = $"{firstNumber} is a positive number";
            }
            else
            {
                ResultLabel.Text = $"{ firstNumber} is a negative number";
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNo.Text);
            if (firstNumber > 0)
            {
                MessageBox.Show($"{firstNumber} is a positive number", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{firstNumber} is a negative number", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
