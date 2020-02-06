using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantSuggest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new System.EventHandler(this.btnSuggest_Click);
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            int homeTemp = trkTemp.Value;
            bool southLight = chkSouthFacing.Checked;

            // Call method
            string SuggestedPlant = SuggestHouseplant(homeTemp, southLight);

            lblSuggestion.Text = SuggestedPlant;
        }

        private string SuggestHouseplant(int temp, bool southFacing)
        {
            //TODO
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

        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            lblTemp.Text = trkTemp.Value.ToString("# °F");
        }

        private void lnkPlantInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSuggestion.Text == "Plant suggestion here")
            {
                ShowWebPage();
            }
            else
            {
                ShowWebPage(lblSuggestion.Text);
            }
        }

        private void ShowWebPage(string plantName = null)
        {
            string url = "https://www.houseplant411.com/";

            if (plantName != null)
            {
                url = url + "houseplant?hpq=" + plantName;
            }
            System.Diagnostics.Process.Start(url);
        }
    }
}
