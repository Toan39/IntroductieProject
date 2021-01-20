namespace Disneyland
{
    partial class DatePickerInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatePickerInputForm));
            this.FindDateButton = new System.Windows.Forms.Button();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.MainTextLabel = new System.Windows.Forms.Label();
            this.DaysComboBox = new System.Windows.Forms.ComboBox();
            this.ChildrenComboBox = new System.Windows.Forms.ComboBox();
            this.WeekTextbox = new System.Windows.Forms.TextBox();
            this.AdultComboBox = new System.Windows.Forms.ComboBox();
            this.AdultLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindDateButton
            // 
            this.FindDateButton.BackColor = System.Drawing.Color.White;
            this.FindDateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FindDateButton.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindDateButton.Location = new System.Drawing.Point(0, 321);
            this.FindDateButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindDateButton.Name = "FindDateButton";
            this.FindDateButton.Size = new System.Drawing.Size(600, 45);
            this.FindDateButton.TabIndex = 1;
            this.FindDateButton.Text = "Find my date!";
            this.FindDateButton.UseVisualStyleBackColor = false;
            this.FindDateButton.Click += new System.EventHandler(this.FindDateButton_Click);
            // 
            // WeekLabel
            // 
            this.WeekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabel.ForeColor = System.Drawing.Color.White;
            this.WeekLabel.Location = new System.Drawing.Point(140, 50);
            this.WeekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(352, 33);
            this.WeekLabel.TabIndex = 2;
            this.WeekLabel.Text = "Which week do you want to go?\r\n";
            // 
            // DaysLabel
            // 
            this.DaysLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLabel.ForeColor = System.Drawing.Color.White;
            this.DaysLabel.Location = new System.Drawing.Point(96, 120);
            this.DaysLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(441, 33);
            this.DaysLabel.TabIndex = 3;
            this.DaysLabel.Text = "For how many days do you want to go?";
            // 
            // MainTextLabel
            // 
            this.MainTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MainTextLabel.AutoSize = true;
            this.MainTextLabel.Font = new System.Drawing.Font("Script MT Bold", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextLabel.ForeColor = System.Drawing.Color.White;
            this.MainTextLabel.Location = new System.Drawing.Point(150, 1);
            this.MainTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainTextLabel.Name = "MainTextLabel";
            this.MainTextLabel.Size = new System.Drawing.Size(323, 46);
            this.MainTextLabel.TabIndex = 9;
            this.MainTextLabel.Text = "pick your ideal date";
            // 
            // DaysComboBox
            // 
            this.DaysComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DaysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaysComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaysComboBox.FormattingEnabled = true;
            this.DaysComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.DaysComboBox.Location = new System.Drawing.Point(273, 155);
            this.DaysComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.DaysComboBox.Name = "DaysComboBox";
            this.DaysComboBox.Size = new System.Drawing.Size(54, 21);
            this.DaysComboBox.TabIndex = 21;
            // 
            // ChildrenComboBox
            // 
            this.ChildrenComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChildrenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChildrenComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChildrenComboBox.FormattingEnabled = true;
            this.ChildrenComboBox.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.ChildrenComboBox.Location = new System.Drawing.Point(273, 225);
            this.ChildrenComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChildrenComboBox.Name = "ChildrenComboBox";
            this.ChildrenComboBox.Size = new System.Drawing.Size(54, 21);
            this.ChildrenComboBox.TabIndex = 22;
            // 
            // WeekTextbox
            // 
            this.WeekTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeekTextbox.Location = new System.Drawing.Point(273, 85);
            this.WeekTextbox.Name = "WeekTextbox";
            this.WeekTextbox.Size = new System.Drawing.Size(54, 20);
            this.WeekTextbox.TabIndex = 24;
            this.WeekTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeekTextbox_KeyPress_1);
            // 
            // AdultComboBox
            // 
            this.AdultComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdultComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdultComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdultComboBox.FormattingEnabled = true;
            this.AdultComboBox.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.AdultComboBox.Location = new System.Drawing.Point(273, 295);
            this.AdultComboBox.Name = "AdultComboBox";
            this.AdultComboBox.Size = new System.Drawing.Size(54, 21);
            this.AdultComboBox.TabIndex = 25;
            // 
            // AdultLabel
            // 
            this.AdultLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AdultLabel.AutoSize = true;
            this.AdultLabel.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.AdultLabel.ForeColor = System.Drawing.Color.White;
            this.AdultLabel.Location = new System.Drawing.Point(160, 260);
            this.AdultLabel.Name = "AdultLabel";
            this.AdultLabel.Size = new System.Drawing.Size(320, 33);
            this.AdultLabel.TabIndex = 26;
            this.AdultLabel.Text = "How many people age 12+?";
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(10, 5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(60, 24);
            this.HomeButton.TabIndex = 27;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 33);
            this.label1.TabIndex = 28;
            this.label1.Text = "How many children age 3-11?";
            // 
            // DatePickerInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.AdultLabel);
            this.Controls.Add(this.AdultComboBox);
            this.Controls.Add(this.WeekTextbox);
            this.Controls.Add(this.ChildrenComboBox);
            this.Controls.Add(this.DaysComboBox);
            this.Controls.Add(this.MainTextLabel);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.FindDateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatePickerInputForm";
            this.Text = "Disneyland";
            this.SizeChanged += new System.EventHandler(this.DatePickerInputForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindDateButton;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label MainTextLabel;
        private System.Windows.Forms.ComboBox DaysComboBox;
        private System.Windows.Forms.ComboBox ChildrenComboBox;
        private System.Windows.Forms.TextBox WeekTextbox;
        private System.Windows.Forms.ComboBox AdultComboBox;
        private System.Windows.Forms.Label AdultLabel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label label1;
    }
}

