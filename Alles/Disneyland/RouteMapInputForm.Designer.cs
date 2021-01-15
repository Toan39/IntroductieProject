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
            RidesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisneyLandPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RidesLabel
            // 
            RidesLabel.AutoSize = true;
            RidesLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RidesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            RidesLabel.Location = new System.Drawing.Point(52, 31);
            RidesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RidesLabel.Name = "RidesLabel";
            RidesLabel.Size = new System.Drawing.Size(123, 19);
            RidesLabel.TabIndex = 5;
            RidesLabel.Text = "Choose your rides:";
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.White;
            this.GoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Location = new System.Drawing.Point(302, 280);
            this.GoButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(231, 76);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "GO!";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // DisneyLandPictureBox
            // 
            this.DisneyLandPictureBox.Image = global::Disneyland.Properties.Resources.Daco_4620584;
            this.DisneyLandPictureBox.Location = new System.Drawing.Point(235, 50);
            this.DisneyLandPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.DisneyLandPictureBox.Name = "DisneyLandPictureBox";
            this.DisneyLandPictureBox.Size = new System.Drawing.Size(143, 209);
            this.DisneyLandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisneyLandPictureBox.TabIndex = 2;
            this.DisneyLandPictureBox.TabStop = false;
            // 
            // PriorityRidesCheckedListBox
            // 
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
            this.PriorityRidesCheckedListBox.Location = new System.Drawing.Point(9, 73);
            this.PriorityRidesCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityRidesCheckedListBox.Name = "PriorityRidesCheckedListBox";
            this.PriorityRidesCheckedListBox.Size = new System.Drawing.Size(218, 165);
            this.PriorityRidesCheckedListBox.TabIndex = 3;
            this.PriorityRidesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // PriorityRidesListBox
            // 
            this.PriorityRidesListBox.BackColor = System.Drawing.Color.White;
            this.PriorityRidesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriorityRidesListBox.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityRidesListBox.FormattingEnabled = true;
            this.PriorityRidesListBox.Location = new System.Drawing.Point(375, 104);
            this.PriorityRidesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityRidesListBox.Name = "PriorityRidesListBox";
            this.PriorityRidesListBox.Size = new System.Drawing.Size(208, 78);
            this.PriorityRidesListBox.TabIndex = 4;
            // 
            // SelectedRidesLabel
            // 
            this.SelectedRidesLabel.AutoSize = true;
            this.SelectedRidesLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRidesLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedRidesLabel.Location = new System.Drawing.Point(436, 73);
            this.SelectedRidesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedRidesLabel.Name = "SelectedRidesLabel";
            this.SelectedRidesLabel.Size = new System.Drawing.Size(97, 19);
            this.SelectedRidesLabel.TabIndex = 12;
            this.SelectedRidesLabel.Text = "Selected rides:";
            // 
            // InformationButton
            // 
            this.InformationButton.BackColor = System.Drawing.Color.White;
            this.InformationButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationButton.Location = new System.Drawing.Point(56, 280);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(2);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(242, 76);
            this.InformationButton.TabIndex = 14;
            this.InformationButton.Text = "Click to get information about the rides";
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.SelectedRidesLabel);
            this.Controls.Add(RidesLabel);
            this.Controls.Add(this.PriorityRidesListBox);
            this.Controls.Add(this.PriorityRidesCheckedListBox);
            this.Controls.Add(this.DisneyLandPictureBox);
            this.Controls.Add(this.GoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Disneyland";
            ((System.ComponentModel.ISupportInitialize)(this.DisneyLandPictureBox)).EndInit();
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
    }
}