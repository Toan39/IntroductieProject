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
        public RouteMapInputForm()
         {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            InitializeComponent();

            ////////add combobox later
            //HoursSpendComboBox.Text = "1";
            //FreeTimeComboBox.Text = "0";
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
                Form Wait = new Form();
                Wait.Text = "Wait a bit";
                Wait.Size = new Size(350, 0);
                Wait.StartPosition = FormStartPosition.CenterScreen;
                Wait.Show();
                

                var selecteditems = PriorityRidesListBox.Items.Cast<String>().ToList();
                this.Hide();

                RouteMap map = new RouteMap(selecteditems);
                Wait.Close();
                map.ShowDialog();
             //   this.Close();




            }

            ////add combobox later

            //String s = HoursSpendComboBox.Text;
            //string a = FreeTimeComboBox.Text;

            //int x = 0;
            //int q = 0;

            //try
            //{x = int.Parse(s);}
            //catch(Exception)
            //{}
            //try
            //{q = int.Parse(a);}
            //catch(Exception)
            //{}

            //if (x + q > 12)
            //{MessageBox.Show("Dit is meer dan 12 uur, dan is disneyland al dicht. Selecteer andere tijden.");}
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
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
            this.Close();

        }
    }
}


