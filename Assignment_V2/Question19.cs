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
    public partial class Question19 : Form
    {
        public Question19()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            int monthNo = Convert.ToInt32(monthText.Text);

            string month = string.Empty;

            switch (monthNo)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                default:
                    month = "Invalid Number";
                    break;
            }

            ResultLabel.Text = $"{month:F2}\n";

            switch (monthNo)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ResultLabel.Text += "Month have 31 days";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ResultLabel.Text += "Month have 30 days";
                    break;
                case 2:
                    ResultLabel.Text += "If leap year, month have 29 days. Otherwise month have 28 days";
                    break;
                default:
                    month = "Invalid Number";
                    break;
            }

        }
    }
}
