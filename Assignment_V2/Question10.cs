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
    public partial class Question10 : Form
    {
        public Question10()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            string admissionNo = admissionText.Text;
            string name = nameText.Text;
            int maths = Convert.ToInt32(mathsText.Text);
            int physics = Convert.ToInt32(physicsText.Text);
            int chemistry = Convert.ToInt32(chemText.Text);

            int total = maths + chemistry + physics;
            double percentage = (double)total / 3;

            ResultLabel.Text = string.Format(
                "Admission No: {0}\n" +
                "Name of Student: {1}\n" +
                "Marks in Physics: {2}\n" +
                "Marks in Chemistry: {3}\n" +
                "Marks in IT: {4}\n" +
                "Total Marks = {5}\n" +
                "Percentage = {6:0.00}\n" +
                "Division: {7}",
                admissionNo, name, physics, chemistry, maths, total, percentage,
                GetDivision(percentage));
        }

        private string GetDivision(double percentage)
        {
            if (percentage >= 60)
                return "First";
            else if (percentage >= 45)
                return "Second";
            else if (percentage >= 33)
                return "Third";
            else
                return "Fail";
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string admissionNo = admissionText.Text;
            string name = nameText.Text;
            int maths = Convert.ToInt32(mathsText.Text);
            int physics = Convert.ToInt32(physicsText.Text);
            int chemistry = Convert.ToInt32(chemText.Text);

            int total = maths + chemistry + physics;
            double percentage = (double)total / 3;

            string message = string.Format(
                "Admission No: {0}\n" +
                "Name of Student: {1}\n" +
                "Marks in Physics: {2}\n" +
                "Marks in Chemistry: {3}\n" +
                "Marks in IT: {4}\n" +
                "Total Marks = {5}\n" +
                "Percentage = {6:0.00}\n" +
                "Division: {7}",
                admissionNo, name, physics, chemistry, maths, total, percentage,
                GetDivision(percentage));

            MessageBox.Show(message, "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      
    }
 }
 

