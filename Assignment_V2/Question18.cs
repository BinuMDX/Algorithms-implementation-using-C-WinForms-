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
    public partial class Question18 : Form
    {
        public Question18()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            string letter = letterText.Text;
            string result = string.Empty;

            

            switch (letter)
            {
                case "E":
                    result = "Excellent.";
                    break;
                case "V":
                    result = "Very good.";
                    break;
                case "G":
                    result = "Good";
                    break;
                case "A":
                    result = "Average";
                    break;
                case "F":
                    result = "Fail";
                    break;
                default:
                    result = "Invalid Grade";
                    break;
            }

            ResultLabel.Text = $"You have chosen: {result}";
            
        }
    }
}
