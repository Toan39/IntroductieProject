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
            System.Windows.Forms.Label RidesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteMapInputForm));
            this.GoButton = new System.Windows.Forms.Button();
            this.DisneyLandPictureBox = new System.Windows.Forms.PictureBox();
            this.PriorityRidesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.PriorityRidesListBox = new System.Windows.Forms.ListBox();
            this.SelectedRidesLabel = new System.Windows.Forms.Label();
            this.InformationButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lunchbreak = new System.Windows.Forms.NumericUpDown();
            this.timetospare = new System.Windows.Forms.NumericUpDown();
            RidesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisneyLandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchbreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetospare)).BeginInit();
            this.SuspendLayout();
            // 
            // RidesLabel
            // 
            RidesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            RidesLabel.AutoSize = true;
            RidesLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RidesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            RidesLabel.Location = new System.Drawing.Point(32, 39);
            RidesLabel.Name = "RidesLabel";
            RidesLabel.Size = new System.Drawing.Size(236, 24);
            RidesLabel.TabIndex = 5;
            RidesLabel.Text = "Choose your rides (max 18):";
            // 
            // GoButton
            // 
            this.GoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoButton.BackColor = System.Drawing.Color.White;
            this.GoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Location = new System.Drawing.Point(403, 345);
            this.GoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(308, 94);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "GO!";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // DisneyLandPictureBox
            // 
            this.DisneyLandPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisneyLandPictureBox.Image = global::Disneyland.Properties.Resources.Daco_4620584;
            this.DisneyLandPictureBox.Location = new System.Drawing.Point(313, 62);
            this.DisneyLandPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisneyLandPictureBox.Name = "DisneyLandPictureBox";
            this.DisneyLandPictureBox.Size = new System.Drawing.Size(191, 257);
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
            this.PriorityRidesCheckedListBox.Location = new System.Drawing.Point(12, 90);
            this.PriorityRidesCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriorityRidesCheckedListBox.Name = "PriorityRidesCheckedListBox";
            this.PriorityRidesCheckedListBox.Size = new System.Drawing.Size(291, 198);
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
            this.PriorityRidesListBox.ItemHeight = 15;
            this.PriorityRidesListBox.Location = new System.Drawing.Point(500, 128);
            this.PriorityRidesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriorityRidesListBox.Name = "PriorityRidesListBox";
            this.PriorityRidesListBox.Size = new System.Drawing.Size(277, 90);
            this.PriorityRidesListBox.TabIndex = 4;
            // 
            // SelectedRidesLabel
            // 
            this.SelectedRidesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectedRidesLabel.AutoSize = true;
            this.SelectedRidesLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRidesLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedRidesLabel.Location = new System.Drawing.Point(581, 90);
            this.SelectedRidesLabel.Name = "SelectedRidesLabel";
            this.SelectedRidesLabel.Size = new System.Drawing.Size(119, 24);
            this.SelectedRidesLabel.TabIndex = 12;
            this.SelectedRidesLabel.Text = "Selected rides:";
            // 
            // InformationButton
            // 
            this.InformationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InformationButton.BackColor = System.Drawing.Color.White;
            this.InformationButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationButton.Location = new System.Drawing.Point(75, 345);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(323, 94);
            this.InformationButton.TabIndex = 14;
            this.InformationButton.Text = "Click to get information about the rides";
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeButton.Location = new System.Drawing.Point(13, 6);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(80, 30);
            this.HomeButton.TabIndex = 15;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lunchbreak:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Spare time:";
            // 
            // lunchbreak
            // 
            this.lunchbreak.Location = new System.Drawing.Point(657, 243);
            this.lunchbreak.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lunchbreak.Name = "lunchbreak";
            this.lunchbreak.ReadOnly = true;
            this.lunchbreak.Size = new System.Drawing.Size(120, 22);
            this.lunchbreak.TabIndex = 20;
            this.lunchbreak.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timetospare
            // 
            this.timetospare.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.timetospare.Location = new System.Drawing.Point(657, 289);
            this.timetospare.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.timetospare.Name = "timetospare";
            this.timetospare.ReadOnly = true;
            this.timetospare.Size = new System.Drawing.Size(120, 22);
            this.timetospare.TabIndex = 21;
            this.timetospare.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // RouteMapInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timetospare);
            this.Controls.Add(this.lunchbreak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.SelectedRidesLabel);
            this.Controls.Add(RidesLabel);
            this.Controls.Add(this.PriorityRidesListBox);
            this.Controls.Add(this.PriorityRidesCheckedListBox);
            this.Controls.Add(this.DisneyLandPictureBox);
            this.Controls.Add(this.GoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RouteMapInputForm";
            this.Text = "Disneyland";
            ((System.ComponentModel.ISupportInitialize)(this.DisneyLandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchbreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetospare)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lunchbreak;
        private System.Windows.Forms.NumericUpDown timetospare;
    }
}