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
        //declarations of variables
        int lunch = 0;
        int spare = 0;
        bool checktime = true; //used to execute RouteMapOutputForm partially
        public RouteMapInputForm()
         {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            InitializeComponent();
        }

        /// <summary>
        /// Error messages for when an impossible inputs are inserted.
        /// If the totaltime including the lunch breaks and spare time exceeds the upperboundtime, an error message will occur.
        /// When user clicks on Go-button the RouteMap.cs is executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GoButton_Click(object sender, EventArgs e)
        {
            if (PriorityRidesListBox.Items.Count > 18)
                { MessageBox.Show("Select max 18 attractions "); } 
            else if (PriorityRidesListBox.Items.Count == 0)
            {
                { MessageBox.Show("No attractions are selected"); }
            }
            else
            {
                //A wait form for when the user has to wait on the final result ("best" route)
                Form Wait = new Form();
                Wait.Text = "Wait a bit";
                Wait.Size = new Size(350, 0);
                Wait.StartPosition = FormStartPosition.CenterScreen;
                Wait.Show();

                var selecteditems = PriorityRidesListBox.Items.Cast<String>().ToList();

                //RouteMapOutputForm is going to be partially executed
                //So that you have a time-value to create an error message
                RouteMapOutputForm FirstGen = new RouteMapOutputForm(selecteditems, checktime); //Only grabs the higherbound of the first generation, because of the bool on termination+selection
                float maxfitness = FirstGen.higherbound;
                float maxtime = FirstGen.UpperBoundTime;
                float originaltime = normalizefitnessscore(maxfitness, maxtime);
                FirstGen.Close();

                //When the upperbound is not exceeded the RouteMapOutputForm is executed
                if (originaltime < 480)
                {
                    checktime = false;
                    RouteMapOutputForm routemap = new RouteMapOutputForm(selecteditems, checktime);

                    //Keeps the size of the previous form
                    routemap.MinimumSize = new Size(800, 584);
                    routemap.Size = this.Size;
                    if (this.WindowState == FormWindowState.Maximized)
                        routemap.WindowState = FormWindowState.Maximized;

                    this.Hide();
                    this.Close();
                    Wait.Hide();
                    Wait.Close();
                    routemap.ShowDialog();
                }

                //When the upperbound is  excedeed error messages are going to show up that advice te user to change his input
                else
                {
                    Wait.Hide();
                    Wait.Close();
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

        //Returns the user to the home form 
        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();

            //Keeps the size of the previous form
            if (this.WindowState == FormWindowState.Maximized)
                main.WindowState = FormWindowState.Maximized;
            main.Size = this.Size;

            this.Hide();
            main.ShowDialog();
            this.Close();

        }

        /// <summary>
        /// Input boxes for the lunchbreak and spare time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LunchBreakNumeric_ValueChanged(object sender, EventArgs e)
        {
            lunch = int.Parse(LunchBreakNumeric.Value.ToString());
        }

        private void SpareTimeNumeric_ValueChanged(object sender, EventArgs e)
        {
            spare = int.Parse(SpareTimeNumeric.Value.ToString());
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


