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

namespace Disneyland
{
    public partial class RouteMapInputForm : Form
    {
        public RouteMapInputForm()
         {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            InitializeComponent();
        }

        //When user clicks on Go-button the RouteMap.cs is executed
        public void GoButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// error messages for when an immposible inputs are inserted 
            /// </summary>
            if (PriorityRidesListBox.Items.Count > 18)
            { MessageBox.Show("Select max 18 attractions "); } 
            else if (PriorityRidesListBox.Items.Count == 0)
            {
                { MessageBox.Show("No attractions are selected"); }
            }
            else
            { 
                var selecteditems = PriorityRidesListBox.Items.Cast<String>().ToList();
                RouteMap map = new RouteMap(selecteditems);
                map.Show();
                if (this.WindowState == FormWindowState.Maximized)
                    map.WindowState = FormWindowState.Maximized;
                map.MinimumSize = new Size(800, 584);
                this.Hide();
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
            main.Show();
            if (this.WindowState == FormWindowState.Maximized)
                main.WindowState = FormWindowState.Maximized;
            this.Hide();
        }
    }
}


