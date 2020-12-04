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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.btnGetItem = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(72, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 17);
            label1.TabIndex = 5;
            label1.Text = "Choose your rides:";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(559, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Disneyland.Properties.Resources.Daco_4620584;
            this.pictureBox1.Location = new System.Drawing.Point(313, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
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
            this.checkedListBox.Location = new System.Drawing.Point(12, 61);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(295, 259);
            this.checkedListBox.TabIndex = 3;
            // 
            // listBoxItem
            // 
            this.listBoxItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 16;
            this.listBoxItem.Location = new System.Drawing.Point(544, 61);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(244, 260);
            this.listBoxItem.TabIndex = 4;
            // 
            // btnGetItem
            // 
            this.btnGetItem.Location = new System.Drawing.Point(576, 27);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(158, 24);
            this.btnGetItem.TabIndex = 6;
            this.btnGetItem.Text = "click to see your rides";
            this.btnGetItem.UseVisualStyleBackColor = true;
            this.btnGetItem.Click += new System.EventHandler(this.btnGetItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetItem);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Disneyland";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.Button btnGetItem;
    }
}