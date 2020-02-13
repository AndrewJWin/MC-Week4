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

namespace PlantSuggest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Adding a new handler to the trackbar Scroll event, this simply re-runs the "Suggest" Method when the user changes the temp.
            this.trkTemp.Scroll += new System.EventHandler(this.btnSuggest_Click);
        }

        // Suggest button Method, gathers the values of each adjustable set and uses the SuggestHouseplant Method to get an answer.
        private void btnSuggest_Click(object sender, EventArgs e)
        {
            int homeTemp = trkTemp.Value;
            bool southLight = chkSouthFacing.Checked;

            string SuggestedPlant = SuggestHouseplant(homeTemp, southLight);

            // Using the SuggestedPlant return as the value for what plant would do well.
            lblSuggestion.Text = SuggestedPlant;
        }

        // SuggestHouseplant Method, takes in the temperature and if the room has a south facing window.
        private string SuggestHouseplant(int temp, bool southFacing)
        {
            // If the room has a south facing window the suggested plants are different, so this is required.
            if (southFacing)
            {
                if (temp > 65)
                {
                    return "Peace Lilly";
                } else
                {
                    return "Spider Plant";
                }
            } else
            {
                if (temp > 65)
                {
                    return "Dragon Tree";
                } else
                {
                    return "Ivy";
                }
            }

        }

        // Numeric response to the value of the Trackbar, updates the temperature label with the temperature.
        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            lblTemp.Text = trkTemp.Value.ToString("# °F");
        }

        // Plant Info link Click Method, takes the User to a specific webpage about the suggested houseplant.
        private void lnkPlantInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Default Case in the event that the user has not recieved a suggestion, or clicks before interacting with the model.
            if (lblSuggestion.Text == "Plant suggestion here")
            {
                // Show the default webpage.
                ShowWebPage();
            }
            else
            {
                // Elsewise show the webpage for the suggested houseplant.
                ShowWebPage(lblSuggestion.Text);
            }
        }

        // ShowWebPage Method, takes in a plantName for a requested plant information - Otherwise show the default homepage.
        private void ShowWebPage(string plantName = null)
        {
            string url = "https://www.houseplant411.com/";

            if (plantName != null)
            {
                url = url + "houseplant?hpq=" + plantName;
            }
            // Uses the system Processes to start the default browser with the requested Webpage.
            System.Diagnostics.Process.Start(url);
        }
    }
}
