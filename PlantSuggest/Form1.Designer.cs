namespace PlantSuggest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkSouthFacing = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuggest = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.trkTemp = new System.Windows.Forms.TrackBar();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.lnkPlantInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSouthFacing
            // 
            this.chkSouthFacing.AutoSize = true;
            this.chkSouthFacing.Location = new System.Drawing.Point(21, 67);
            this.chkSouthFacing.Name = "chkSouthFacing";
            this.chkSouthFacing.Size = new System.Drawing.Size(267, 21);
            this.chkSouthFacing.TabIndex = 0;
            this.chkSouthFacing.Text = "Do you have a South-facing Window?";
            this.chkSouthFacing.UseVisualStyleBackColor = true;
            this.chkSouthFacing.CheckedChanged += new System.EventHandler(this.btnSuggest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "How warm is your Home?";
            // 
            // btnSuggest
            // 
            this.btnSuggest.Location = new System.Drawing.Point(39, 269);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(76, 31);
            this.btnSuggest.TabIndex = 2;
            this.btnSuggest.Text = "Suggest!";
            this.btnSuggest.UseVisualStyleBackColor = true;
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(391, 196);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(42, 17);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "50 °F";
            // 
            // trkTemp
            // 
            this.trkTemp.Location = new System.Drawing.Point(21, 185);
            this.trkTemp.Maximum = 90;
            this.trkTemp.Minimum = 50;
            this.trkTemp.Name = "trkTemp";
            this.trkTemp.Size = new System.Drawing.Size(364, 56);
            this.trkTemp.TabIndex = 4;
            this.trkTemp.Value = 50;
            this.trkTemp.Scroll += new System.EventHandler(this.trkTemp_Scroll);
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Location = new System.Drawing.Point(143, 276);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(146, 17);
            this.lblSuggestion.TabIndex = 5;
            this.lblSuggestion.Text = "Plant suggestion here";
            // 
            // lnkPlantInfo
            // 
            this.lnkPlantInfo.AutoSize = true;
            this.lnkPlantInfo.Location = new System.Drawing.Point(310, 319);
            this.lnkPlantInfo.Name = "lnkPlantInfo";
            this.lnkPlantInfo.Size = new System.Drawing.Size(132, 17);
            this.lnkPlantInfo.TabIndex = 6;
            this.lnkPlantInfo.TabStop = true;
            this.lnkPlantInfo.Text = "houseplant411.com";
            this.lnkPlantInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPlantInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 348);
            this.Controls.Add(this.lnkPlantInfo);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.trkTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSouthFacing);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSouthFacing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuggest;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TrackBar trkTemp;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.LinkLabel lnkPlantInfo;
    }
}

