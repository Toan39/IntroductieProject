namespace Disneyland
{
    partial class RouteMapInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteMapInputForm));
            this.GoButton = new System.Windows.Forms.Button();
            this.DisneyLandPictureBox = new System.Windows.Forms.PictureBox();
            this.PriorityRidesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.PriorityRidesListBox = new System.Windows.Forms.ListBox();
            this.SelectedRidesLabel = new System.Windows.Forms.Label();
            this.InformationButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.RidesLabel = new System.Windows.Forms.Label();
            this.LunchBreakLabel = new System.Windows.Forms.Label();
            this.SpareTimeLabel = new System.Windows.Forms.Label();
            this.LunchBreakNumeric = new System.Windows.Forms.NumericUpDown();
            this.SpareTimeNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DisneyLandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunchBreakNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpareTimeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GoButton.BackColor = System.Drawing.Color.White;
            this.GoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Location = new System.Drawing.Point(310, 285);
            this.GoButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(240, 76);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "GO!";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // DisneyLandPictureBox
            // 
            this.DisneyLandPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisneyLandPictureBox.Image = global::Disneyland.Properties.Resources.Daco_4620584;
            this.DisneyLandPictureBox.Location = new System.Drawing.Point(235, 52);
            this.DisneyLandPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.DisneyLandPictureBox.Name = "DisneyLandPictureBox";
            this.DisneyLandPictureBox.Size = new System.Drawing.Size(145, 210);
            this.DisneyLandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisneyLandPictureBox.TabIndex = 2;
            this.DisneyLandPictureBox.TabStop = false;
            // 
            // PriorityRidesCheckedListBox
            // 
            this.PriorityRidesCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriorityRidesCheckedListBox.BackColor = System.Drawing.Color.White;
            this.PriorityRidesCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriorityRidesCheckedListBox.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityRidesCheckedListBox.FormattingEnabled = true;
            this.PriorityRidesCheckedListBox.Items.AddRange(new object[] {
            "It\'s a Small World",
            "Autopia",
            "Big Thunder Mountain",
            "Snow White and the Seven Dwarfs",
            "Buzz Lightyear Laser Blast",
            "Casey Jr. - The Little Circus Train",
            "Disneyland Railroad",
            "Dumbo the Flying Elephant",
            "Indiana Jones and the Temple of Peril",
            "The Lancelot Carousel",
            "Le Pays des Contes de Fées",
            "Les Mystères du Nautilus",
            "Pinocchio\'s Daring Journey",
            "Mad Hatter\'s Tea Cups",
            "Main Street Vehicles",
            "Rencontre avec Mickey",
            "Mickey\'s PhilharMagic",
            "Peter Pan Flight",
            "Phantom Manor",
            "Pirates of the Caribbean",
            "Pavillon des Princesses",
            "Star Tours: The Adventures Continue",
            "Space Mountain: Mission 2",
            "Thunder Mesa Riverboat Landing",
            "Tomorrowland-caroussels",
            "Starport"});
            this.PriorityRidesCheckedListBox.Location = new System.Drawing.Point(10, 75);
            this.PriorityRidesCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityRidesCheckedListBox.Name = "PriorityRidesCheckedListBox";
            this.PriorityRidesCheckedListBox.Size = new System.Drawing.Size(220, 165);
            this.PriorityRidesCheckedListBox.TabIndex = 3;
            this.PriorityRidesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // PriorityRidesListBox
            // 
            this.PriorityRidesListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriorityRidesListBox.BackColor = System.Drawing.Color.White;
            this.PriorityRidesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriorityRidesListBox.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityRidesListBox.FormattingEnabled = true;
            this.PriorityRidesListBox.Location = new System.Drawing.Point(385, 75);
            this.PriorityRidesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityRidesListBox.Name = "PriorityRidesListBox";
            this.PriorityRidesListBox.Size = new System.Drawing.Size(210, 104);
            this.PriorityRidesListBox.TabIndex = 4;
            // 
            // SelectedRidesLabel
            // 
            this.SelectedRidesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectedRidesLabel.AutoSize = true;
            this.SelectedRidesLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRidesLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedRidesLabel.Location = new System.Drawing.Point(440, 41);
            this.SelectedRidesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedRidesLabel.Name = "SelectedRidesLabel";
            this.SelectedRidesLabel.Size = new System.Drawing.Size(97, 19);
            this.SelectedRidesLabel.TabIndex = 12;
            this.SelectedRidesLabel.Text = "Selected rides:";
            // 
            // InformationButton
            // 
            this.InformationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InformationButton.BackColor = System.Drawing.Color.White;
            this.InformationButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationButton.Location = new System.Drawing.Point(60, 285);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(2);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(240, 76);
            this.InformationButton.TabIndex = 14;
            this.InformationButton.Text = "Click to get information about the rides";
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(10, 5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(80, 30);
            this.HomeButton.TabIndex = 15;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // RidesLabel
            // 
            this.RidesLabel.AutoSize = true;
            this.RidesLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.RidesLabel.ForeColor = System.Drawing.Color.White;
            this.RidesLabel.Location = new System.Drawing.Point(25, 41);
            this.RidesLabel.Name = "RidesLabel";
            this.RidesLabel.Size = new System.Drawing.Size(190, 19);
            this.RidesLabel.TabIndex = 16;
            this.RidesLabel.Text = "Choose your rides (max 18):";
            // 
            // LunchBreakLabel
            // 
            this.LunchBreakLabel.AutoSize = true;
            this.LunchBreakLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.LunchBreakLabel.ForeColor = System.Drawing.Color.White;
            this.LunchBreakLabel.Location = new System.Drawing.Point(412, 198);
            this.LunchBreakLabel.Name = "LunchBreakLabel";
            this.LunchBreakLabel.Size = new System.Drawing.Size(94, 19);
            this.LunchBreakLabel.TabIndex = 17;
            this.LunchBreakLabel.Text = "Lunchbreaks:";
            // 
            // SpareTimeLabel
            // 
            this.SpareTimeLabel.AutoSize = true;
            this.SpareTimeLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.SpareTimeLabel.ForeColor = System.Drawing.Color.White;
            this.SpareTimeLabel.Location = new System.Drawing.Point(381, 240);
            this.SpareTimeLabel.Name = "SpareTimeLabel";
            this.SpareTimeLabel.Size = new System.Drawing.Size(125, 19);
            this.SpareTimeLabel.TabIndex = 18;
            this.SpareTimeLabel.Text = "Spare time: (min)";
            // 
            // LunchBreakNumeric
            // 
            this.LunchBreakNumeric.Location = new System.Drawing.Point(530, 197);
            this.LunchBreakNumeric.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.LunchBreakNumeric.Name = "LunchBreakNumeric";
            this.LunchBreakNumeric.ReadOnly = true;
            this.LunchBreakNumeric.Size = new System.Drawing.Size(62, 20);
            this.LunchBreakNumeric.TabIndex = 20;
            this.LunchBreakNumeric.ValueChanged += new System.EventHandler(this.LunchBreakNumeric_ValueChanged);
            // 
            // SpareTimeNumeric
            // 
            this.SpareTimeNumeric.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SpareTimeNumeric.Location = new System.Drawing.Point(530, 239);
            this.SpareTimeNumeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SpareTimeNumeric.Name = "SpareTimeNumeric";
            this.SpareTimeNumeric.ReadOnly = true;
            this.SpareTimeNumeric.Size = new System.Drawing.Size(62, 20);
            this.SpareTimeNumeric.TabIndex = 21;
            this.SpareTimeNumeric.ValueChanged += new System.EventHandler(this.SpareTimeNumeric_ValueChanged);
            // 
            // RouteMapInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(604, 371);
            this.Controls.Add(this.RidesLabel);
            this.Controls.Add(this.SpareTimeNumeric);
            this.Controls.Add(this.LunchBreakNumeric);
            this.Controls.Add(this.SpareTimeLabel);
            this.Controls.Add(this.LunchBreakLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.SelectedRidesLabel);
            this.Controls.Add(this.PriorityRidesListBox);
            this.Controls.Add(this.PriorityRidesCheckedListBox);
            this.Controls.Add(this.DisneyLandPictureBox);
            this.Controls.Add(this.GoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RouteMapInputForm";
            this.Text = "Disneyland";
            this.SizeChanged += new System.EventHandler(this.RouteMapInputForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DisneyLandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunchBreakNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpareTimeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.PictureBox DisneyLandPictureBox;
        private System.Windows.Forms.CheckedListBox PriorityRidesCheckedListBox;
        private System.Windows.Forms.ListBox PriorityRidesListBox;
        private System.Windows.Forms.Label SelectedRidesLabel;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label RidesLabel;
        private System.Windows.Forms.Label LunchBreakLabel;
        private System.Windows.Forms.Label SpareTimeLabel;
        private System.Windows.Forms.NumericUpDown LunchBreakNumeric;
        private System.Windows.Forms.NumericUpDown SpareTimeNumeric;
    }
}