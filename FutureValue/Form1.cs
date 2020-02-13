using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************\
*                                  *
* Andrew Terwilliger 2/5/2020      *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         *"Calculate" button function, takes the provided values for the monthlyInvestment, yearlyInterestRate 
         * and Years and runs them through the CalculateFutureValue function - Simplifying the code significantly.
        */

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Convert the provided values to a form that the program can use.
            decimal monthlyInvestment = Convert.ToDecimal(txtInvest.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterest.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = this.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
            txtFuture.Text = futureValue.ToString("c");
            txtInvest.Focus();
        }


        // CalculateFutureValue function, takes monthlyInvestment, monthlyInterestRate and months to return the futureValue.
        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            // Initializing the futureValue as 0.
            decimal futureValue = 0m;
            
            // for loop, going through every month calculating the interest rate - and adding it to the futureValue.
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                              * (1 + monthlyInterestRate);
            }

            // Returning the futureValue to be used.
            return futureValue;
        }

        // Exit button function.
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ClearFutureValue event function, if the user changes any provide values, clear the future value box.
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFuture.Text = "";
        }
    }
}
