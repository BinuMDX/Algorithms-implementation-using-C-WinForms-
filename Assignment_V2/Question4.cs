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
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }

       

        private void checkButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(firstNo.Text);
            if (year % 4 == 0 )
            {
                if(year % 100 != 0)
                {
                    MessageBox.Show($"{year} is a leap year", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{year} is not a leap year", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show($"{year} is not a leap year", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(firstNo.Text);
            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    ResultLabel.Text = $"{year} is a leap year";
                   
                }
                else
                {
                    ResultLabel.Text = $"{year} is not a leap year";
                }

            }
            else
            {
                ResultLabel.Text = $"{year} is not a leap year";
            }
        }

       
    }
}
