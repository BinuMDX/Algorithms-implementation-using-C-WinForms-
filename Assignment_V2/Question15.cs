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
    public partial class Question15 : Form
    {
        public Question15()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            int dayNumber = Convert.ToInt32(firstNo.Text);
            string dayName = GetDayName(dayNumber);

            ResultLabel.Text = $"{dayName}";
        }
        private string GetDayName(int dayNumber)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                return days[dayNumber - 1];
            }
            else
            {
                return "Invalid day number!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dayNumber = Convert.ToInt32(firstNo.Text);
            string dayName = GetDayName(dayNumber);

            MessageBox.Show($"{dayName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
