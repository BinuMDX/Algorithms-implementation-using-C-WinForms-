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
    public partial class Question9 : Form
    {
        public Question9()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            int maths = Convert.ToInt32(mathsText.Text);
            int physics = Convert.ToInt32(physicsText.Text);
            int chemistry = Convert.ToInt32(chemText.Text);

            int total = maths + physics + chemistry;

            if(total > 180)
            {
                if (maths < 65 || physics < 55 || chemistry < 50)
                {
                    totalLabel.ForeColor = Color.FromArgb(0xFF7E00);
                    totalLabel.Text = $"Total is: {total}";
                    ResultLabel.Text = $"The candidate is not eligible for admission";
                }
                else
                {
                    totalLabel.ForeColor = Color.Green;
                    totalLabel.Text = $"Total is: {total}";
                    ResultLabel.Text = $"The candidate is eligible for admission";
                }
            }
            else
            {
                totalLabel.ForeColor = Color.Red;
                totalLabel.Text = $"Total is: {total}";
                ResultLabel.Text = $"The candidate is not eligible for admission";
            }


            if(maths < 65)
            {
                mathsText.BackColor = Color.Red;
            }
            else
            {
                mathsText.BackColor = Color.LightGreen;
            }
            if (physics < 55)
            {
                physicsText.BackColor = Color.Red;
            }
            else
            {
                physicsText.BackColor = Color.LightGreen;
            }
            if (chemistry < 55)
            {
                chemText.BackColor = Color.Red;
            }
            else
            {
                chemText.BackColor = Color.LightGreen;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int maths = Convert.ToInt32(mathsText.Text);
            int physics = Convert.ToInt32(physicsText.Text);
            int chemistry = Convert.ToInt32(chemText.Text);

            int total = maths + physics + chemistry;

            if (total > 180)
            {
                if (maths < 65 || physics < 55 || chemistry < 50)
                {
                    totalLabel.ForeColor = Color.FromArgb(0xFF7E00);
                    totalLabel.Text = $"Total is: {total}";
                    MessageBox.Show($"The candidate is not eligible for admission");

                }
                else
                {
                    totalLabel.ForeColor = Color.Green;
                    totalLabel.Text = $"Total is: {total}";
                    MessageBox.Show($"The candidate is eligible for admission");
                }
            }
            else
            {
                totalLabel.ForeColor = Color.Red;
                totalLabel.Text = $"Total is: {total}";
                MessageBox.Show($"The candidate is not eligible for admission");
            }


            if (maths < 65)
            {
                mathsText.BackColor = Color.Red;
            }
            else
            {
                mathsText.BackColor = Color.LightGreen;
            }
            if (physics < 55)
            {
                physicsText.BackColor = Color.Red;
            }
            else
            {
                physicsText.BackColor = Color.LightGreen;
            }
            if (chemistry < 55)
            {
                chemText.BackColor = Color.Red;
            }
            else
            {
                chemText.BackColor = Color.LightGreen;
            }

        }
    }
}
