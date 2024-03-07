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
    public partial class Question14 : Form
    {
        string status;
        public Question14()
        {
            InitializeComponent();
        }

   

        private void display_Click(object sender, EventArgs e)
        {
            int profit = Convert.ToInt32(profitText.Text);
            int loss = Convert.ToInt32(lossText.Text);

            int result = profit - loss;

            if (result > 0)
            {
                ResultLabel.Text = $"Total profit amount : {result}";
            }else if(result == 0)
            {
                ResultLabel.Text = "There is no any profit or loss";
            }
            else
            {
                ResultLabel.Text = $"Total loss amount : {result}";
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            int profit = Convert.ToInt32(profitText.Text);
            int loss = Convert.ToInt32(lossText.Text);

            int result = profit - loss;

            if (result > 0)
            {
                MessageBox.Show($"Total profit amount : {result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 0)
            {
                MessageBox.Show("There is no any profit or loss", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Total loss amount : {result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
