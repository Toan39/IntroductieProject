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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DaysComboBox = new System.Windows.Forms.ComboBox();
            this.ChildrenComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WeekTextbox = new System.Windows.Forms.TextBox();
            this.AdultComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindDateButton
            // 
            this.FindDateButton.BackColor = System.Drawing.Color.White;
            this.FindDateButton.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindDateButton.Location = new System.Drawing.Point(157, 391);
            this.FindDateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindDateButton.Name = "FindDateButton";
            this.FindDateButton.Size = new System.Drawing.Size(499, 50);
            this.FindDateButton.TabIndex = 1;
            this.FindDateButton.Text = "Find my date!";
            this.FindDateButton.UseVisualStyleBackColor = false;
            this.FindDateButton.Click += new System.EventHandler(this.FindDateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which week do you want to go?\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "For how many days do you want to go?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(199, -7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 58);
            this.label5.TabIndex = 9;
            this.label5.Text = "pick your ideal date";
            // 
            // DaysComboBox
            // 
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
            this.DaysComboBox.Location = new System.Drawing.Point(364, 176);
            this.DaysComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DaysComboBox.Name = "DaysComboBox";
            this.DaysComboBox.Size = new System.Drawing.Size(71, 24);
            this.DaysComboBox.TabIndex = 21;
            // 
            // ChildrenComboBox
            // 
            this.ChildrenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChildrenComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChildrenComboBox.FormattingEnabled = true;
            this.ChildrenComboBox.Items.AddRange(new object[] {
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
            this.ChildrenComboBox.Location = new System.Drawing.Point(364, 258);
            this.ChildrenComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChildrenComboBox.Name = "ChildrenComboBox";
            this.ChildrenComboBox.Size = new System.Drawing.Size(71, 24);
            this.ChildrenComboBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 39);
            this.label3.TabIndex = 23;
            this.label3.Text = "How many children age 3-9?";
            // 
            // WeekTextbox
            // 
            this.WeekTextbox.Location = new System.Drawing.Point(364, 94);
            this.WeekTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.WeekTextbox.Name = "WeekTextbox";
            this.WeekTextbox.Size = new System.Drawing.Size(71, 22);
            this.WeekTextbox.TabIndex = 24;
            this.WeekTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeekTextbox_KeyPress_1);
            // 
            // AdultComboBox
            // 
            this.AdultComboBox.FormattingEnabled = true;
            this.AdultComboBox.Location = new System.Drawing.Point(364, 336);
            this.AdultComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdultComboBox.Name = "AdultComboBox";
            this.AdultComboBox.Size = new System.Drawing.Size(71, 24);
            this.AdultComboBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(221, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 39);
            this.label4.TabIndex = 26;
            this.label4.Text = "How many people age 10+?";
            // 
            // DatePickerInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdultComboBox);
            this.Controls.Add(this.WeekTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChildrenComboBox);
            this.Controls.Add(this.DaysComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindDateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatePickerInputForm";
            this.Text = "Disneyland";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindDateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DaysComboBox;
        private System.Windows.Forms.ComboBox ChildrenComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WeekTextbox;
        private System.Windows.Forms.ComboBox AdultComboBox;
        private System.Windows.Forms.Label label4;
    }
}

