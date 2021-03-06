﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Disneyland
{
    public partial class DatePickerInputForm : Form
    {
        public DatePickerInputForm()
        {
            //fills in the input boxes with default values
            InitializeComponent();
            DaysComboBox.Text = "1";
            ChildrenComboBox.Text = "0";
            AdultComboBox.Text = "1";
            WeekTextbox.Text = "1";
        }

        //Lets the user select the preferred week 
        private void WeekTextbox_KeyPress_1(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Executes the datapicker-function
        private void FindDateButton_Click(object sender, EventArgs e)
        {
            //Inserted values of the user
            int child = int.Parse(ChildrenComboBox.Text);
            int week = int.Parse(WeekTextbox.Text);
            int adult = int.Parse(AdultComboBox.Text);
            int day = int.Parse(DaysComboBox.Text);
            int price = 89 * adult + 82 * child; //flex price of Disneyland tickets 
            int crowd = 0;
            
            //Crowdlevel information through the year
            switch (week)
                 {
                    case int n when(n > 0 && n <= 2):
                         crowd = 180; break;
                    case int n when(n > 2 && n <= 12):
                        crowd = 100;  break;
                    case int n when(n > 12 && n <= 22):
                        crowd = 150;  break;
                    case  int n when(n > 22 && n <= 32):
                        crowd = 220;  break;
                    case  int n when(n > 32 && n <= 40):
                        crowd = 160;  break;
                    case int n when(n > 40 && n <= 48):
                        crowd = 120;  break;
                    case  int n when(n > 48 && n <= 52):
                        crowd = 220;  break;
                    case  int n when(n > 52):
                        MessageBox.Show("Insert a weeknumber under 52"); break; //error message
            }

            //Calculates hotel cost
            if (day > 1)
            {
                int groupsize = adult + child;
                int  hotel= groupsize * 73 * day;  //staycity aparthotel - disneyland parijs (cheapest hotel)
                price = price + hotel;
            }
                //Does not execute the datapicker if an impossible weeknumber is given
                if (week <= 52)
                {
                this.Hide();
                DatePickerOutputForm date = new DatePickerOutputForm(week, price, crowd);
                date.ResultLabel.Text = date.ReturnBestDate();

                //Keeps the size of the previous form
                if (this.WindowState == FormWindowState.Maximized)
                    date.WindowState = FormWindowState.Maximized;
                date.MinimumSize = new Size(616, 405);

                date.Size = this.Size;
                date.ShowDialog();
                this.Close();
                }
             
        }

        //Returns user to home form
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
    }
}
