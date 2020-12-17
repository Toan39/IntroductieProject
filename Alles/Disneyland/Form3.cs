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
         }

        ////void methods////
            

       

        public void GoButton_Click(object sender, EventArgs e)
        {
            RouteMap map = new RouteMap(comboBox1.Text);
            //map.attractionlist = DataService.att;
            String s = comboBox1.Text;
            string a = comboBox2.Text;
            
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
            if(comboBox1.SelectedItem == null)
            {MessageBox.Show("Er is geen tijd doorgegeven.");}
            if (comboBox2.SelectedItem == null)
            { MessageBox.Show("Er is geen tijd doorgegeven."); }
            if (SelectRidesListBox.SelectedItem == null)
            { MessageBox.Show("Er zijn geen attracties doorgegeven"); }
           
            else
            { map.Show();
              this.Hide();
            }

           
        }

        private void SelectRidesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRidesListBox.Items.Clear();
            foreach (string s in SelectRidesListBox.CheckedItems)
        {
            SelectedRidesListBox.Items.Add(s);
            SelectedRidesListBox.Invalidate();
            }

        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/activiteiten/");
        }
    }
}


