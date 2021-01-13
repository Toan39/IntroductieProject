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
        

        public void button1_Click(object sender, EventArgs e)
        {
            var selecteditems = listBoxItem.Items.Cast<String>().ToList();

            Form5 map = new Form5(selecteditems);
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
            if (checkedListBox.SelectedItem == null)
            { MessageBox.Show("Er zijn geen attracties doorgegeven"); }
            if (listBoxItem.Items.Count >18)
            { MessageBox.Show("Mag niet meer dan 18 attracties selecteren"); }

            if (x+q<10 && checkedListBox.SelectedItem!=null && comboBox1.SelectedItem!=null && comboBox2.SelectedItem!=null && listBoxItem.Items.Count < 18)
            { 
              map.Show();
              this.Hide();
            }

           
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in checkedListBox.CheckedItems)
        {
            listBoxItem.Items.Add(s);
            listBoxItem.Invalidate();
        }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/activiteiten/");
        }
    }
}


