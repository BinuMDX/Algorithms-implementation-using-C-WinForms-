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
    public partial class Question17 : Form
    {
        public Question17()
        {
            InitializeComponent();
        }

       

   

        private void display_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string id = idText.Text;
            int unit = Convert.ToInt32(unitText.Text);
            double total = 0;
            double surcharge, netTotal;

            /*The charge are as follow :
                    Unit                                Charge/unit
                    upto 199                             @1.20
                    200 and above but less than 400      @1.50
                    400 and above but less than 600      @1.80
                    600 and above                        @2.00 */

            if(unit >= 600)
            {
                total = unit * 2.00;
            }
            else if( unit < 600 && unit >= 400)
            {
                total = unit * 1.80;
            }
            else if (unit < 400 && unit >= 200)
            {
                total = unit * 1.50;
            }
            else
            {
                total = unit * 1.20;
            }

            ResultLabel.Text = $"Customer IDNO: {id}\n" +
                              $"Customer Name: {name}\n" +
                              $"unit Consumed: {unit}\n" +
                              $"Amount Charges @Rs. {total/ unit:F2} per unit : {total:F2}\n";


            if (total > 400)
            {
                surcharge = (total * 15) / 100;
                netTotal = total + surcharge;
                ResultLabel.Text += $"Surcharge Amount: {surcharge:F2}\n";
                ResultLabel.Text += $"Net Amount Paid By the Customer: {netTotal:F2}";
            }

            if (total < 100)
            {
                total = 100;
                ResultLabel.Text += $"Net Amount Paid By the Customer: {total:F2}";
            }

        }

    }
}
