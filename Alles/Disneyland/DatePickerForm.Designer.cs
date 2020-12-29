﻿namespace Disneyland
{
    partial class DatePickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatePickerForm));
            this.CalendarButton = new System.Windows.Forms.Button();
            this.MainTextLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.mmRainLabel = new System.Windows.Forms.Label();
            this.CrowdLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarButton
            // 
            this.CalendarButton.BackColor = System.Drawing.Color.White;
            this.CalendarButton.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarButton.Location = new System.Drawing.Point(141, 353);
            this.CalendarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(477, 85);
            this.CalendarButton.TabIndex = 0;
            this.CalendarButton.Text = "Add to calendar!";
            this.CalendarButton.UseVisualStyleBackColor = false;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // MainTextLabel
            // 
            this.MainTextLabel.AutoSize = true;
            this.MainTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainTextLabel.Font = new System.Drawing.Font("Script MT Bold", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextLabel.ForeColor = System.Drawing.Color.White;
            this.MainTextLabel.Location = new System.Drawing.Point(213, 9);
            this.MainTextLabel.Name = "MainTextLabel";
            this.MainTextLabel.Size = new System.Drawing.Size(388, 58);
            this.MainTextLabel.TabIndex = 1;
            this.MainTextLabel.Text = "your ideal date is...";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Black;
            this.ResultLabel.Location = new System.Drawing.Point(292, 76);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(229, 39);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "may 14th 2021 !";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mmRainLabel
            // 
            this.mmRainLabel.AutoSize = true;
            this.mmRainLabel.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmRainLabel.ForeColor = System.Drawing.Color.White;
            this.mmRainLabel.Location = new System.Drawing.Point(465, 155);
            this.mmRainLabel.Name = "mmRainLabel";
            this.mmRainLabel.Size = new System.Drawing.Size(82, 39);
            this.mmRainLabel.TabIndex = 4;
            this.mmRainLabel.Text = "0mm";
            // 
            // CrowdLabel
            // 
            this.CrowdLabel.AutoSize = true;
            this.CrowdLabel.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrowdLabel.ForeColor = System.Drawing.Color.White;
            this.CrowdLabel.Location = new System.Drawing.Point(265, 219);
            this.CrowdLabel.Name = "CrowdLabel";
            this.CrowdLabel.Size = new System.Drawing.Size(256, 39);
            this.CrowdLabel.TabIndex = 5;
            this.CrowdLabel.Text = "Crowd expectation";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.ForeColor = System.Drawing.Color.White;
            this.CostLabel.Location = new System.Drawing.Point(292, 312);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(223, 39);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "total cost: € 218";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Disneyland.Properties.Resources._07_Weather;
            this.pictureBox1.Location = new System.Drawing.Point(300, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(223, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 48);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DatePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CrowdLabel);
            this.Controls.Add(this.mmRainLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.MainTextLabel);
            this.Controls.Add(this.CalendarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatePickerForm";
            this.Text = "Disneyland";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Label MainTextLabel;
        public System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label mmRainLabel;
        private System.Windows.Forms.Label CrowdLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}