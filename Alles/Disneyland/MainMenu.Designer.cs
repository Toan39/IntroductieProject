namespace Disneyland
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.DatePickerButton = new System.Windows.Forms.Button();
            this.RouteButton = new System.Windows.Forms.Button();
            this.MainTextLabel1 = new System.Windows.Forms.Label();
            this.MainTextLabel2 = new System.Windows.Forms.Label();
            this.DisneyLandPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisneyLandPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePickerButton
            // 
            this.DatePickerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatePickerButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatePickerButton.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerButton.Location = new System.Drawing.Point(329, 187);
            this.DatePickerButton.Margin = new System.Windows.Forms.Padding(2);
            this.DatePickerButton.Name = "DatePickerButton";
            this.DatePickerButton.Size = new System.Drawing.Size(204, 82);
            this.DatePickerButton.TabIndex = 0;
            this.DatePickerButton.Text = "Pick My Date";
            this.DatePickerButton.UseVisualStyleBackColor = false;
            this.DatePickerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RouteButton
            // 
            this.RouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RouteButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RouteButton.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteButton.Location = new System.Drawing.Point(329, 274);
            this.RouteButton.Margin = new System.Windows.Forms.Padding(2);
            this.RouteButton.Name = "RouteButton";
            this.RouteButton.Size = new System.Drawing.Size(204, 82);
            this.RouteButton.TabIndex = 1;
            this.RouteButton.Text = "Show my route";
            this.RouteButton.UseVisualStyleBackColor = false;
            this.RouteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainTextLabel1
            // 
            this.MainTextLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTextLabel1.AutoSize = true;
            this.MainTextLabel1.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainTextLabel1.Location = new System.Drawing.Point(217, 28);
            this.MainTextLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainTextLabel1.Name = "MainTextLabel1";
            this.MainTextLabel1.Size = new System.Drawing.Size(183, 46);
            this.MainTextLabel1.TabIndex = 2;
            this.MainTextLabel1.Text = "One day in";
            // 
            // MainTextLabel2
            // 
            this.MainTextLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTextLabel2.AutoSize = true;
            this.MainTextLabel2.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextLabel2.ForeColor = System.Drawing.Color.Snow;
            this.MainTextLabel2.Location = new System.Drawing.Point(207, 93);
            this.MainTextLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainTextLabel2.Name = "MainTextLabel2";
            this.MainTextLabel2.Size = new System.Drawing.Size(203, 33);
            this.MainTextLabel2.TabIndex = 3;
            this.MainTextLabel2.Text = "Disneyland paris\r\n";
            // 
            // DisneyLandPictureBox
            // 
            this.DisneyLandPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisneyLandPictureBox.Image = global::Disneyland.Properties.Resources.Daco_4620584;
            this.DisneyLandPictureBox.Location = new System.Drawing.Point(51, 128);
            this.DisneyLandPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.DisneyLandPictureBox.Name = "DisneyLandPictureBox";
            this.DisneyLandPictureBox.Size = new System.Drawing.Size(204, 239);
            this.DisneyLandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisneyLandPictureBox.TabIndex = 4;
            this.DisneyLandPictureBox.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.MainTextLabel2);
            this.Controls.Add(this.DisneyLandPictureBox);
            this.Controls.Add(this.MainTextLabel1);
            this.Controls.Add(this.RouteButton);
            this.Controls.Add(this.DatePickerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Disneyland";
            this.SizeChanged += new System.EventHandler(this.MainMenu_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DisneyLandPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DatePickerButton;
        private System.Windows.Forms.Button RouteButton;
        private System.Windows.Forms.Label MainTextLabel1;
        private System.Windows.Forms.Label MainTextLabel2;
        public System.Windows.Forms.PictureBox DisneyLandPictureBox;
    }
}