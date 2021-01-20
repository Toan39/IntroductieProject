using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;
using Dapper;
using System.Collections;
using System.Globalization;
using System.IO;


namespace Disneyland
{
    public partial class RouteMapInputForm : Form
    {
        int lunch = 0;
        int spare = 0;
        bool checktime = true;
        public RouteMapInputForm()
         {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            InitializeComponent();
        }

        //When user clicks on Go-button the RouteMap.cs is executed
        public void GoButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// error messages for when an impossible inputs are inserted.
            /// if the totaltime including the lunch breaks and spare time exceeds the upperboundtime, an error message will occur.
            /// </summary>
            if (PriorityRidesListBox.Items.Count > 18)
                { MessageBox.Show("Select max 18 attractions "); } 
            else if (PriorityRidesListBox.Items.Count == 0)
            {
                { MessageBox.Show("No attractions are selected"); }
            }
            else
            {
                Form Wait = new Form();
                Wait.Text = "Wait a bit";
                Wait.Size = new Size(350, 0);
                Wait.StartPosition = FormStartPosition.CenterScreen;
                Wait.Show();
                

                var selecteditems = PriorityRidesListBox.Items.Cast<String>().ToList();
               
                RouteMap map1 = new RouteMap(selecteditems, checktime); //only grabs the higherbound of the first generation.
                float maxfitness = map1.higherbound;
                float maxtime = map1.UpperBoundTime;
                float originaltime = normalizefitnessscore(maxfitness, maxtime);
                map1.MinimumSize = new Size(800, 584);  
                if (this.WindowState == FormWindowState.Maximized)
                {
                    map1.WindowState = FormWindowState.Maximized;
                }
                if(originaltime < 480)
                {
                    checktime = false;
                    RouteMap map2 = new RouteMap(selecteditems, checktime);
                    map2.ShowDialog();
                    this.Hide();
                }
                else
                {
                    string error = "Error: invalid route. Lower the amount of attractions or the amount of";
                    if(lunch == 0)
                    {
                        { MessageBox.Show(error + " spare time"); }
                    }
                    else
                    {
                        { MessageBox.Show(error + " lunchbreaks or the amount of spare time"); }
                    }
                    
                }    
                this.Hide();
                Wait.Close();
                map1.ShowDialog();
            }

          
        }

        //links the user to the attractions information site of Disneyland
        private void InformationButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/activiteiten/"); 
        }

        //User can select the attractions that he wants
        //Adds the selected item in the listbox
        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>          
            {
                PriorityRidesListBox.Items.Clear();
                for (int t = 0; t < PriorityRidesCheckedListBox.CheckedItems.Count; t++)
                {
                    PriorityRidesListBox.Items.Add(PriorityRidesCheckedListBox.CheckedItems[t]);
                }
            }));
        }

        //returns the user to the home form 
        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            if (this.WindowState == FormWindowState.Maximized)
                main.WindowState = FormWindowState.Maximized;
            this.Hide();
            main.ShowDialog();
            this.Close();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lunch = int.Parse(lunchbreak.Value.ToString());
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            spare = int.Parse(timetospare.Value.ToString());
        }

        //converts the fitnessscore to the totaltime.
        private float normalizefitnessscore(float maxfitness, float maxtime)
        {
            float x = (100 - maxfitness) / 100;
            float originaltime = x * maxtime;
            originaltime = originaltime + 5; //adds 5 minutes to the higherbound in order to prevent an infinite route.
            lunch = lunch * 20;
            originaltime = originaltime + lunch + spare;
            return originaltime;
        }
    }
}


