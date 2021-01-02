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
            HoursSpendComboBox.Text = "1";
            FreeTimeComboBox.Text = "0";
         }

        ////void methods////
            

       

        public void GoButton_Click(object sender, EventArgs e)
        {
            RouteMap map = new RouteMap(HoursSpendComboBox.Text);
            
            //map.attractionlist = DataService.att;
            String s = HoursSpendComboBox.Text;
            string a = FreeTimeComboBox.Text;
            int x = 0;
            int q = 0;

            try
            {x = int.Parse(s);}
            catch(Exception)
            {}
            try
            {q = int.Parse(a);}
            catch(Exception)
            {}

            if (x + q > 12)
            {MessageBox.Show("Dit is meer dan 12 uur, dan is disneyland al dicht. Selecteer andere tijden.");}

            // if (SelectRidesListBox.SelectedItem == null)
            //  { MessageBox.Show("Er zijn geen attracties doorgegeven"); }

            else
            { map.Show();
              this.Hide();
            }
            int t = 0;
            //converts strings in selectedrideslistbox to prioritylist and includes change of type from string to disneyland.walktime
            foreach (string str in PriorityRidesCheckedListBox.CheckedItems)
            {
                map.PriorityList.Add((Disneyland.walktime)Convert.ChangeType(str, typeof(Disneyland.walktime)));
                t++;
            }

        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/activiteiten/");
        }

        private void PriorityRidesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityRidesListBox.Items.Clear();
            foreach (string s in PriorityRidesCheckedListBox.CheckedItems)
            {
                PriorityRidesListBox.Items.Add(s);
                PriorityRidesListBox.Invalidate();
            }
        }
    }
}


