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
    public partial class Form3 : Form
    {

        //varabiales declarations//
        
        
        public Form3()
         {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            InitializeComponent();

            ////////add combobox later
            //HoursSpendComboBox.Text = "1";
            //FreeTimeComboBox.Text = "0";
        }

        ////void methods////




        public void GoButton_Click(object sender, EventArgs e)
        {
            var selecteditems = PriorityRidesListBox.Items.Cast<String>().ToList();
            RouteMap map = new RouteMap(selecteditems);


            //map.attractionlist = DataService.att;

            ////add combobox later
            //String s = HoursSpendComboBox.Text;
            //string a = FreeTimeComboBox.Text;

            int x = 0;
            int q = 0;


            ////add combobox later
            //try
            //{x = int.Parse(s);}
            //catch(Exception)
            //{}
            //try
            //{q = int.Parse(a);}
            //catch(Exception)
            //{}

            if (x + q > 12)
            {MessageBox.Show("Dit is meer dan 12 uur, dan is disneyland al dicht. Selecteer andere tijden.");}

            // if (SelectRidesListBox.SelectedItem == null)
            //  { MessageBox.Show("Er zijn geen attracties doorgegeven"); }

            else
            { map.Show();
              this.Hide();
            }

        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/activiteiten/");
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>          //regel van stackoverflow
            {
                PriorityRidesListBox.Items.Clear();
                for (int t = 0; t < PriorityRidesCheckedListBox.CheckedItems.Count; t++)
                {
                    PriorityRidesListBox.Items.Add(PriorityRidesCheckedListBox.CheckedItems[t]);
                }
            }));
        }
    }
}


