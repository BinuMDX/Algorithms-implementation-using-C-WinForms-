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
    public partial class Question12 : Form
    {
        string status;
        public Question12()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            checkTriangle();
            ResultLabel.Text = $"{status}";
        }

        private string checkTriangle()
        {
            int firstAngle = Convert.ToInt32(firstNo.Text);
            int secondAngle = Convert.ToInt32(secondNo.Text);
            int thirdAngle = Convert.ToInt32(thirdNo.Text);

            int total = firstAngle + secondAngle + thirdAngle;

            if(total == 180 )
            {
                status = "The triangle is valid";
            }
            else
            {
                status = "The triangle is not valid";
            }

            return status;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            checkTriangle();
            MessageBox.Show($"{status}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
