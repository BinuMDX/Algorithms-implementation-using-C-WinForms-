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
    public partial class Question11 : Form
    {
        string status;
        public Question11()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            checkStatus();
            ResultLabel.Text = $"Its {status}";
           
        }

        private string checkStatus()
        {
            int temperature = Convert.ToInt32(tempText.Text);
            

            if (temperature >= 40)
            {
                status = "Very Hot";
            }
            else if (temperature < 40 && temperature >= 30)
            {
                status = "Hot";
            }
            else if (temperature < 30 && temperature >= 20)
            {
                status = "Normal";
            }
            else if (temperature < 20 && temperature >= 10)
            {
                status = "Cold weather";
            }
            else if (temperature < 10 && temperature >= 0)
            {
                status = "Very Cold weather";
            }
            else
            {
                status = "Freezing weather";
            }

            return status;
            

        }
    

        private void checkButton_Click(object sender, EventArgs e)
        {
            checkStatus();
            MessageBox.Show($" its {status}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
    }
}
