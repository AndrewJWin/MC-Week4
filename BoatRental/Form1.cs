using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatRental
{
    public partial class Form1 : Form
    {
        int Adults = 0;
        int Children = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxBoat.Items.Add("Canoe");
            cbxBoat.Items.Add("Kayak");
            cbxBoat.Items.Add("Paddleboat");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool validInputs = validateInput(txtAdults.Text, txtChildren.Text);

            if (!validInputs)
            {
                MessageBox.Show("Please verify the number of Adults or Children provided.", "Invalid Input");
            } else
            {
                switch (cbxBoat.SelectedItem)
                {
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
                    default:
                        {
                            MessageBox.Show("Please select a boat from the dropdown list.", "Error");
                            btnReserve.Enabled = false;
                            break;
                        }
                }
            }
        }


        private bool validateInput(string adults, string children)
        {
            bool adultsValid = int.TryParse(adults, out int Adults);
            bool childrenValid = int.TryParse(children, out int Children);
            if (!adultsValid | !childrenValid) { this.Adults = Adults; this.Children = Children; return false; } else { return true; }
        }

        private bool checkCanoe(int Adults, int Children)
        {
            if (Adults > 1 || Children > 0)
            {
                lblValid.Text = "Invalid data";
                MessageBox.Show("Only 1 Adult is allowed per Canoe, please verify provided inputs.", "Invalid Input");
                return false;
            }
            else
            {
                lblValid.Text = "Valid data";
                btnReserve.Enabled = true;
                return true;
            }
        }

        private bool checkKayak(int Adults, int Children)
        {
            if (Adults > 2 || Children > 2 || Adults > 1 & Children > 1)
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

        private bool checkPaddleboat(int Adults, int Children)
        {
            if (Adults >= 2 || Children >= 2 || Adults < 1 & Children < 1)
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

        private void btnReserve_Click(object sender, EventArgs e)
        {
            reserveBoat(cbxBoat.Text, Adults, Children);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblValid.Text = "Not Checked";
            txtAdults.Text = "";
            txtChildren.Text = "";
            btnReserve.Enabled = false;
        }
    }
}
