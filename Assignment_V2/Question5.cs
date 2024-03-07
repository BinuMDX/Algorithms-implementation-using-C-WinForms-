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
    public partial class Question5 : Form
    {
        public Question5()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(ageText.Text);
            if (age >= 18)
            {
                MessageBox.Show($"Congratulation! You are eligible for casting your vote.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show($"Oops! You are not eligible to casting your vote", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(ageText.Text);
            if (age >= 18)
            {
                ResultLabel.Text = $"Congratulation! You are eligible for casting your vote.";
            }
            else
            {
                ResultLabel.Text = $"Oops! You are not eligible to casting your vote";
            }
        }
    }
    
    
}
