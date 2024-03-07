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
    public partial class Question13 : Form
    {
        public Question13()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            string letter = letterText.Text;

            if (string.IsNullOrWhiteSpace(letter) || letter.Length != 1 || !char.IsLetter(letter[0]))
            {
                MessageBox.Show("Please enter a single alphabet letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char ch = char.ToLower(letter[0]);

            string result = string.Empty;
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    result = "The alphabet is a vowel.";
                    break;
                default:
                    result = "The alphabet is a consonant.";
                    break;
            }

            ResultLabel.Text = result;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string letter = letterText.Text;

            if (string.IsNullOrWhiteSpace(letter) || letter.Length != 1 || !char.IsLetter(letter[0]))
            {
                MessageBox.Show("Please enter a single alphabet letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char ch = char.ToLower(letter[0]);

            string result = string.Empty;
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    result = "The alphabet is a vowel.";
                    break;
                default:
                    result = "The alphabet is a consonant.";
                    break;
            }

            MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}

