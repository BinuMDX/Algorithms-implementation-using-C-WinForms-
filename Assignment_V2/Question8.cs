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
    public partial class Question8 : Form
    {
        public Question8()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            int firstNo = Convert.ToInt32(firstNoText.Text);
            int secondNo = Convert.ToInt32(secondNoText.Text);
            int thirdNo = Convert.ToInt32(thirdNoText.Text);

            if(firstNo > secondNo)
            {
                if (thirdNo > firstNo)
                {
                    ResultLabel.Text = $"The 3rd Number is the greatest among three";
                }
                else
                {
                    ResultLabel.Text = $"The 1st Number is the greatest among three";
                }
            }else
            {
                if (thirdNo > secondNo)
                {
                    ResultLabel.Text = $"The 3rd Number is the greatest among three";
                }
                else
                {
                    ResultLabel.Text = $"The 2nd Number is the greatest among three";
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int firstNo = Convert.ToInt32(firstNoText.Text);
            int secondNo = Convert.ToInt32(secondNoText.Text);
            int thirdNo = Convert.ToInt32(thirdNoText.Text);

            if (firstNo > secondNo)
            {
                if (thirdNo > firstNo)
                {
                    MessageBox.Show($"The 3rd Number is the greatest among three", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show($"The 1st Number is the greatest among three", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (thirdNo > secondNo)
                {
                    MessageBox.Show($"The 3rd Number is the greatest among three", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"The 2nd Number is the greatest among three", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
