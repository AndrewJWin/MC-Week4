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
* Andrew Terwilliger 2/7/2020      *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace BoatRental
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Loading Method, add the offered boats to the ComboBox
        private void Form1_Load(object sender, EventArgs e)
        {
            cbxBoat.Items.Add("Canoe");
            cbxBoat.Items.Add("Kayak");
            cbxBoat.Items.Add("Paddleboat");
        }

        // General Exit Method, enables the Exit button to function.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Check button Method, validates the input provided against numeral validation and boat size validation.
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Bool validation for text input.
            bool validInputs = validateInput(txtAdults.Text, txtChildren.Text, out int Adults, out int Children);

            if (!validInputs)
            {
                MessageBox.Show("Please verify the number of Adults or Children provided.", "Invalid Input");
            } else
            {
                // Switch case for the selected Boat in the ComboBox
                switch (cbxBoat.SelectedItem)
                {
                    // Each case going to their specific check Method.
                    case "Canoe":
                        {
                            checkCanoe(Adults, Children);
                            break;
                        }
                    case "Kayak":
                        {
                            checkKayak(Adults, Children);
                            break;
                        }
                    case "Paddleboat":
                        {
                            checkPaddleboat(Adults, Children);
                            break;
                        }
                    // Default case in the event the user does not select a boat from the ComboBox.
                    default:
                        {
                            MessageBox.Show("Please select a boat from the dropdown list.", "Error");
                            btnReserve.Enabled = false;
                            break;
                        }
                }
            }
        }

        // Input Validation Method, returns as a bool value.
        private bool validateInput(string adults, string children, out int NumAdults, out int NumChildren)
        {
            // Quickly validating if the provided input can be parsed into an int value.
            bool adultsValid = int.TryParse(adults, out int Adults);
            bool childrenValid = int.TryParse(children, out int Children);
            NumAdults = Adults;
            NumChildren = Children;
            if (!adultsValid || !childrenValid) { return false; } else { return true; }
        }

        // Canoe validation Method, validates the maximum occupancy of the boat against the provided values.
        private bool checkCanoe(int Adults, int Children)
        {
            if (Adults > 1 || Children > 0)
            {
                lblValid.Text = "Invalid data";
                MessageBox.Show("Only 1 Adult is allowed per Canoe, please verify provided inputs.", "Invalid Input");
                btnReserve.Enabled = false;
                return false;
            }
            else
            {
                lblValid.Text = "Valid data";
                btnReserve.Enabled = true;
                return true;
            }
        }

        // Kayak validation Method, validates the maximum occupancy of the boat against the provided values.
        private bool checkKayak(int Adults, int Children)
        {
            if (Adults > 2 || Adults == 1 && Children > 1 || Children > 0 && Adults == 0)
            {
                lblValid.Text = "Invalid data";
                MessageBox.Show("Only 2 Adults, or 1 Adult and Child allowed per Kayak, please verify provided inputs.", "Invalid Input");
                return false;
            }
            else
            {
                lblValid.Text = "Valid data";
                btnReserve.Enabled = true;
                return true;
            }
        }

        // Paddleboat validation Method, validates the maximum occupancy of the boat against the provided values.
        private bool checkPaddleboat(int Adults, int Children)
        {
            if (Adults > 1 || Children > 1)
            {
                lblValid.Text = "Invalid data";
                MessageBox.Show("Only 1 Adult, or 1 Adult and Child allowed per Paddleboat, please verify provided inputs.", "Invalid Input");
                return false;
            }
            else
            {
                lblValid.Text = "Valid data";
                btnReserve.Enabled = true;
                return true;
            }
        }

        // Finalization of the Reservation Method, combines the provided values and builds a statement based on provided values.
        private void reserveBoat(string boatType, int Adults, int Children)
        {
            string message = "You've reserved a ";
            message += boatType + " ";
            if (Adults > 1)
            {
                message += "with 2 Adults and ";
            }
            else
            {
                message += "with 1 Adult and ";
            }
            if (Children > 0)
            {
                message += "1 Child.";
            } else
            {
                message += "no Children.";
            }
            MessageBox.Show(message, "Reservation Complete");
        }

        // Reserve Boat button Method, only availible after validating input previously.
        private void btnReserve_Click(object sender, EventArgs e)
        {
            validateInput(txtAdults.Text, txtChildren.Text, out int Adults, out int Children);
            reserveBoat(cbxBoat.Text, Adults, Children);
        }

        // Reset button Method, is also used when the User changes their selection in the ComboBox.
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblValid.Text = "Not Checked";
            txtAdults.Text = "";
            txtChildren.Text = "";
            btnReserve.Enabled = false;
        }
    }
}
