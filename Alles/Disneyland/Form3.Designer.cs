namespace Disneyland
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.GoButton = new System.Windows.Forms.Button();
            this.DisneyLandPictureBox = new System.Windows.Forms.PictureBox();
            this.PriorityRidesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.PriorityRidesListBox = new System.Windows.Forms.ListBox();
            this.FreeTimeLabel = new System.Windows.Forms.Label();
            this.HoursSpendComboBox = new System.Windows.Forms.ComboBox();
            this.HoursSpendLabel = new System.Windows.Forms.Label();
            this.SelectedRidesLabel = new System.Windows.Forms.Label();
            this.FreeTimeComboBox = new System.Windows.Forms.ComboBox();
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
            "\'it\'s a small world\'",
            "Adventure Isle",
            "Alice\'s Curious Labyrinth ",
            "Autopia",
            "Big Thunder Mountain",
            "Blanche-Neige et les Sept Nains",
            "Buzz Lightyear Laser Blast",
            "Casey Jr. - le Petit Train du Cirque ",
            "Discovery Arcade",
            "Disneyland Railroad",
            "Dumbo the Flying Elephant",
            "Frontierland Playground",
            "Horse-Drawn Streetcars ",
            "Indiana Jones and the Temple of Peril",
            "La Cabane des Robinson",
            "La Carrousel de Lancelot",
            "Le Passage Enchanté",
            "Le Pays des Contes de Fées",
            "Les Mystères du Nautilus",
            "Les Voyages de Pinocchio",
            "Liberty Arcade ",
            "Mad Hatter’s Tea Cups ",
            "Main Street Vehicles",
            "Meet Mickey Mouse",
            "Mickey’s PhilharMagic",
            "Orbitron",
            "Peter Pan’s Flight ",
            "Phantom Manor ",
            "Pirate Galleon",
            "Pirates of the Caribbean",
            "Pirates’ Beach",
            "Princess Pavilion",
            "Rustler Roundup Shootin’ Gallery",
            "Sleeping Beauty Castle",
            "Star Tours: The Adventure Continue",
            "Star Wars Hyperspace Mountain",
            "Thunder Mesa Riverboat Landing"});
            this.PriorityRidesCheckedListBox.Location = new System.Drawing.Point(9, 73);
            this.PriorityRidesCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityRidesCheckedListBox.Name = "PriorityRidesCheckedListBox";
            this.PriorityRidesCheckedListBox.Size = new System.Drawing.Size(218, 165);
            this.PriorityRidesCheckedListBox.TabIndex = 3;
            this.PriorityRidesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.PriorityRidesCheckedListBox_SelectedIndexChanged);
            // 
            // PriorityRidesListBox
            // 
            this.PriorityRidesListBox.BackColor = System.Drawing.Color.White;
            this.PriorityRidesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriorityRidesListBox.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityRidesListBox.FormattingEnabled = true;
            this.PriorityRidesListBox.Location = new System.Drawing.Point(382, 166);
            this.PriorityRidesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityRidesListBox.Name = "PriorityRidesListBox";
            this.PriorityRidesListBox.Size = new System.Drawing.Size(208, 78);
            this.PriorityRidesListBox.TabIndex = 4;
            // 
            // FreeTimeLabel
            // 
            this.FreeTimeLabel.AutoSize = true;
            this.FreeTimeLabel.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeTimeLabel.ForeColor = System.Drawing.Color.White;
            this.FreeTimeLabel.Location = new System.Drawing.Point(347, 73);
            this.FreeTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FreeTimeLabel.Name = "FreeTimeLabel";
            this.FreeTimeLabel.Size = new System.Drawing.Size(241, 17);
            this.FreeTimeLabel.TabIndex = 7;
            this.FreeTimeLabel.Text = "How many hours of free time do you need";
            // 
            // HoursSpendComboBox
            // 
            this.HoursSpendComboBox.DisplayMember = "1";
            this.HoursSpendComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursSpendComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoursSpendComboBox.FormattingEnabled = true;
            this.HoursSpendComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.HoursSpendComboBox.Location = new System.Drawing.Point(446, 33);
            this.HoursSpendComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.HoursSpendComboBox.Name = "HoursSpendComboBox";
            this.HoursSpendComboBox.Size = new System.Drawing.Size(60, 21);
            this.HoursSpendComboBox.TabIndex = 8;
            // 
            // HoursSpendLabel
            // 
            this.HoursSpendLabel.AutoSize = true;
            this.HoursSpendLabel.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursSpendLabel.ForeColor = System.Drawing.Color.White;
            this.HoursSpendLabel.Location = new System.Drawing.Point(347, 15);
            this.HoursSpendLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HoursSpendLabel.Name = "HoursSpendLabel";
            this.HoursSpendLabel.Size = new System.Drawing.Size(257, 17);
            this.HoursSpendLabel.TabIndex = 10;
            this.HoursSpendLabel.Text = "How many hours will you spend in the park";
            // 
            // SelectedRidesLabel
            // 
            this.SelectedRidesLabel.AutoSize = true;
            this.SelectedRidesLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRidesLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedRidesLabel.Location = new System.Drawing.Point(443, 135);
            this.SelectedRidesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedRidesLabel.Name = "SelectedRidesLabel";
            this.SelectedRidesLabel.Size = new System.Drawing.Size(97, 19);
            this.SelectedRidesLabel.TabIndex = 12;
            this.SelectedRidesLabel.Text = "Selected rides:";
            // 
            // FreeTimeComboBox
            // 
            this.FreeTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FreeTimeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FreeTimeComboBox.FormattingEnabled = true;
            this.FreeTimeComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.FreeTimeComboBox.Location = new System.Drawing.Point(446, 101);
            this.FreeTimeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FreeTimeComboBox.Name = "FreeTimeComboBox";
            this.FreeTimeComboBox.Size = new System.Drawing.Size(60, 21);
            this.FreeTimeComboBox.TabIndex = 13;
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
            this.Controls.Add(this.FreeTimeComboBox);
            this.Controls.Add(this.SelectedRidesLabel);
            this.Controls.Add(this.HoursSpendLabel);
            this.Controls.Add(this.HoursSpendComboBox);
            this.Controls.Add(this.FreeTimeLabel);
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
        private System.Windows.Forms.Label FreeTimeLabel;
        private System.Windows.Forms.ComboBox HoursSpendComboBox;
        private System.Windows.Forms.Label HoursSpendLabel;
        private System.Windows.Forms.Label SelectedRidesLabel;
        private System.Windows.Forms.ComboBox FreeTimeComboBox;
        private System.Windows.Forms.Button InformationButton;
    }
}