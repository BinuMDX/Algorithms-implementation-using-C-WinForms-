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
    public partial class Question6 : Form
    {
        public Question6()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int M = Convert.ToInt32(numberText.Text);

            string N;

            if (M > 0)
            {
                N = "Positive";
            }
            else if (M == 0)
            {
                N = "0";
            }
            else
            {
                N = "Negative";
            }

            MessageBox.Show($"The value of N = {N}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void display_Click(object sender, EventArgs e)
        {

            int M = Convert.ToInt32(numberText.Text);

            string N;

            if (M > 0)
            {
                N = "Positive";
            }
            else if (M == 0)
            {
                N = "0";
            }
            else
            {
                N = "Negative";
            }

            ResultLabel.Text = $"The value of N = {N}";
        }
    }
    }

