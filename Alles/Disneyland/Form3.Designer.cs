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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Go_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectRidesListBox = new System.Windows.Forms.CheckedListBox();
            this.SelectedRidesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Information_Button = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(52, 31);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 19);
            label1.TabIndex = 5;
            label1.Text = "Choose your rides:";
            // 
            // Go_button
            // 
            this.Go_button.BackColor = System.Drawing.Color.White;
            this.Go_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Go_button.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_button.Location = new System.Drawing.Point(302, 280);
            this.Go_button.Margin = new System.Windows.Forms.Padding(2);
            this.Go_button.Name = "Go_button";
            this.Go_button.Size = new System.Drawing.Size(231, 76);
            this.Go_button.TabIndex = 1;
            this.Go_button.Text = "GO!";
            this.Go_button.UseVisualStyleBackColor = false;
            this.Go_button.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Disneyland.Properties.Resources.Daco_4620584;
            this.pictureBox1.Location = new System.Drawing.Point(235, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SelectRidesListBox
            // 
            this.SelectRidesListBox.BackColor = System.Drawing.Color.White;
            this.SelectRidesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectRidesListBox.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRidesListBox.FormattingEnabled = true;
            this.SelectRidesListBox.Items.AddRange(new object[] {
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
            this.SelectRidesListBox.Location = new System.Drawing.Point(9, 73);
            this.SelectRidesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectRidesListBox.Name = "SelectRidesListBox";
            this.SelectRidesListBox.Size = new System.Drawing.Size(218, 180);
            this.SelectRidesListBox.TabIndex = 3;
            this.SelectRidesListBox.SelectedIndexChanged += new System.EventHandler(this.SelectRidesListBox_SelectedIndexChanged);
            // 
            // SelectedRidesListBox
            // 
            this.SelectedRidesListBox.BackColor = System.Drawing.Color.White;
            this.SelectedRidesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedRidesListBox.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRidesListBox.FormattingEnabled = true;
            this.SelectedRidesListBox.Location = new System.Drawing.Point(382, 166);
            this.SelectedRidesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedRidesListBox.Name = "SelectedRidesListBox";
            this.SelectedRidesListBox.Size = new System.Drawing.Size(208, 91);
            this.SelectedRidesListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(347, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "How many hours of free time do you need";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(446, 33);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "How many hours will you spend in the park";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(443, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected rides:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(446, 101);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // Information_Button
            // 
            this.Information_Button.BackColor = System.Drawing.Color.White;
            this.Information_Button.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information_Button.Location = new System.Drawing.Point(56, 280);
            this.Information_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Information_Button.Name = "Information_Button";
            this.Information_Button.Size = new System.Drawing.Size(242, 76);
            this.Information_Button.TabIndex = 14;
            this.Information_Button.Text = "Click to get information about the rides";
            this.Information_Button.UseVisualStyleBackColor = false;
            this.Information_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Information_Button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.SelectedRidesListBox);
            this.Controls.Add(this.SelectRidesListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Go_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Disneyland";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Go_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox SelectRidesListBox;
        private System.Windows.Forms.ListBox SelectedRidesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Information_Button;
    }
}