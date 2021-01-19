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
                var selecteditems = PriorityRidesListBox.Items.Cast<String>().ToList();
                RouteMap map = new RouteMap(selecteditems);
                map.Show();
                if (this.WindowState == FormWindowState.Maximized)
                    map.WindowState = FormWindowState.Maximized;
                map.MinimumSize = new Size(800, 584);
                this.Hide();
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
            MainMenu main = new MainMenu();
            main.Show();
            if (this.WindowState == FormWindowState.Maximized)
                main.WindowState = FormWindowState.Maximized;
            this.Hide();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            float scaleX = this.Width / this.MinimumSize.Width;
            float scaleY = this.Height / this.MinimumSize.Height;

            HomeButton.Width = (int)(100 * scaleX);
            HomeButton.Height = (int)(100 * scaleY);
        }

        private void RouteMapInputForm_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(616, 405);
            double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
            double scaleY = (double)this.Height / (double)this.MinimumSize.Height;

            HomeButton.Width = (int)(60 * scaleX);
            HomeButton.Height = (int)(24 * scaleY);

            PriorityRidesCheckedListBox.Size = new Size((int)(220 * scaleX), (int)(165 * scaleY));
            PriorityRidesCheckedListBox.Location = new Point((int)(10 * scaleX), (int)(75 * scaleY));

            SelectedRidesLabel.Location = new Point((int)(440 * scaleX), (int)(41 * scaleY));
            RidesLabel.Location = new Point((int)(25 * scaleX), (int)(41 * scaleY));

            PriorityRidesListBox.Size = new Size((int)(210 * scaleX), (int)(104 * scaleY));
            PriorityRidesListBox.Location = new Point((int)(385 * scaleX), (int)(75 * scaleY));

            DisneyLandPictureBox.Size = new Size((int)(143 * scaleX), (int)(209 * scaleY));
            DisneyLandPictureBox.Location = new Point((int)(237*scaleX), (int)(52*scaleY));

            InformationButton.Size = new Size((int)(242 * scaleX), (int)(76 * scaleY));
            InformationButton.Location = new Point((int)(60 * scaleX), (int)(285 * scaleY)); 

            GoButton.Size = new Size((int)(231 * scaleX), (int)(76 * scaleY));
            GoButton.Location = new Point((int)(310 * scaleX), (int)(285 * scaleY));

            PriorityRidesCheckedListBox.Font = new Font(PriorityRidesCheckedListBox.Font.FontFamily, (float)(7.8 * scaleY));
            PriorityRidesListBox.Font = new Font(PriorityRidesListBox.Font.FontFamily, (float)(7.8 * scaleY));
            HomeButton.Font = new Font(HomeButton.Font.FontFamily, (float)(7.8 * scaleY));
            RidesLabel.Font = new Font(RidesLabel.Font.FontFamily, (float)(7.8 * scaleY));
            SelectedRidesLabel.Font = new Font(SelectedRidesLabel.Font.FontFamily, (float)(7.8 * scaleY));
            InformationButton.Font = new Font(InformationButton.Font.FontFamily, (float)(7.8 * scaleY));
            GoButton.Font = new Font(GoButton.Font.FontFamily, (float)(7.8 * scaleY));
        }
    }
}


