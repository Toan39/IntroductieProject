﻿namespace Disneyland
{
    partial class RouteMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteMap));
            this.PrintButton = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.MainTextLabel = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(71, 2);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(56, 29);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(11, 2);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(56, 29);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // MainTextLabel
            // 
            this.MainTextLabel.AutoSize = true;
            this.MainTextLabel.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextLabel.ForeColor = System.Drawing.Color.White;
            this.MainTextLabel.Location = new System.Drawing.Point(213, 2);
            this.MainTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainTextLabel.Name = "MainTextLabel";
            this.MainTextLabel.Size = new System.Drawing.Size(169, 33);
            this.MainTextLabel.TabIndex = 3;
            this.MainTextLabel.Text = "Estimated time";
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(10, 35);
            this.gmap.Margin = new System.Windows.Forms.Padding(2);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(500, 500);
            this.gmap.TabIndex = 4;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(536, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 5;
            // 
            // RouteMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.MainTextLabel);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.PrintButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RouteMap";
            this.Text = "Disneyland";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label MainTextLabel;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label2;
    }
}