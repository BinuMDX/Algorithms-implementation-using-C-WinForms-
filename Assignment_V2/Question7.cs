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
    public partial class Question7 : Form
    {
        public Question7()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(numberText.Text);

          
            if (height >= 180)
            {
                ResultLabel.Text = $"The person is Tall"; ;
            }
            else if (height <= 179 && height >= 160)
            {
                ResultLabel.Text = $"The person is Average";
            }
            else if(height <= 159)
            {
                ResultLabel.Text = $"The person is Short";
            }

            
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(numberText.Text);


            if (height >= 180)
            {
                MessageBox.Show($"The person is Tall", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else if (height <= 179 && height >= 160)
            {
                MessageBox.Show($"The person is Average", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (height <= 159)
            {
                MessageBox.Show($"The person is Short", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

