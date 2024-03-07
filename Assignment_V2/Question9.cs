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
                ResultLabel.Text = $"The candidate is eligible for admission";
            }
            else
            {
                ResultLabel.Text = $"The candidate is not eligible for admission";
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
                if(maths >= 55 )
                MessageBox.Show($"The candidate is eligible for admission", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"The candidate is not eligible for admission", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
