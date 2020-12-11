using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disneyland
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 map = new Form5();
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

            if (x + q > 10)
            {MessageBox.Show("Dit is meer dan 10 uur, dan is disneyland al dicht. Selecteer andere tijden.");}
            if(comboBox1.SelectedItem == null)
            {MessageBox.Show("Er is geen tijd doorgegeven.");}
            if (comboBox2.SelectedItem == null)
            { MessageBox.Show("Er is geen tijd doorgegeven."); }
            if (checkedListBox.SelectedItem == null)
            { MessageBox.Show("Er zijn geen attracties doorgegeven"); }
           
            if(x+q<10&&checkedListBox.SelectedItem!=null&&comboBox1.SelectedItem!=null&&comboBox2.SelectedItem!=null)
            { map.Show();
              this.Hide();
            }
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in checkedListBox.CheckedItems)
            listBoxItem.Items.Add(s);
            listBoxItem.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/activiteiten/");
        }

    }
}
