using System;
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
            InitializeComponent();
            DaysComboBox.Text = "1";
            ChildrenComboBox.Text = "0";
            AdultComboBox.Text = "1";
            WeekTextbox.Text = "1";
        }

        private void WeekTextbox_KeyPress_1(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void FindDateButton_Click(object sender, EventArgs e)
        {
            int child = int.Parse(ChildrenComboBox.Text);
            int week = int.Parse(WeekTextbox.Text);
            int adult = int.Parse(AdultComboBox.Text);
            int day = int.Parse(DaysComboBox.Text);
            int price = 89 * adult + 82 * child;
            int crowd = 0;
            
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
                    case  int n when(n > 48 && n<=52):
                        crowd = 220;  break;
                    case  int n when(n > 52):
                        MessageBox.Show("Insert a weeknumber under 52"); break;
            }

            if (day > 1)
            {
                int groupsize = adult + child;
                int  hotel= groupsize*73;  //staycity aparthotel - disneyland parijs
                price = price + hotel;
            }

                if (week <= 52)
                { 
                DatePickerForm date = new DatePickerForm(week, price, crowd);
                date.ResultLabel.Text = date.ReturnBestDate();
                date.Show();
                this.Hide();
                }
             
        }
    }
}
