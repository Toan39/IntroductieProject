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

            if (day > 1)
            {
                int groupsize = adult + child;
                int  hotel= groupsize*73;  //staycity aparthotel - disneyland parijs (cheapest hotel)
                price = price + hotel;
            }
                //Does not execute the datapicker if an impossible weeknumber is given
                if (week <= 52)
                { 
                DatePickerForm date = new DatePickerForm(week, price, crowd);
                date.ResultLabel.Text = date.ReturnBestDate();
                date.Show();
                if (this.WindowState == FormWindowState.Maximized)
                    date.WindowState = FormWindowState.Maximized;
                date.MinimumSize = new Size(616, 405);
                this.Hide();
                }
             
        }

        //Returns user to home form
        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            if (this.WindowState == FormWindowState.Maximized)
                main.WindowState = FormWindowState.Maximized;
            this.Hide();
        }

        private void DatePickerInputForm_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(616, 405);
            double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
            double scaleY = (double)this.Height / (double)this.MinimumSize.Height;
            double scaleXY = (scaleY + scaleX) / 2;
            HomeButton.Width = (int)(60 * scaleX);
            HomeButton.Height = (int)(24 * scaleY);

            FindDateButton.Width = (int)(350 * scaleX);
            FindDateButton.Height = (int)(40 * scaleY);
            FindDateButton.Location = new Point((int)((0.5 * this.Width) - 0.5 * FindDateButton.Size.Width), (int)(this.Height - 100));

            WeekTextbox.Size = new Size((int)(54 * scaleX), (int)(21 * scaleY));
            DaysComboBox.Size = new Size((int)(54 * scaleX), (int)(21 * scaleY));
            ChildrenComboBox.Size = new Size((int)(54 * scaleX), (int)(21 * scaleY));
            AdultComboBox.Size = new Size((int)(54 * scaleX), (int)(21 * scaleY));

            WeekTextbox.Location = new Point((int)((0.5 * this.Width) - 0.5 * WeekTextbox.Size.Width), (int)(85 * scaleXY));
            DaysComboBox.Location = new Point((int)((0.5 * this.Width) - 0.5 * DaysComboBox.Size.Width), (int)(155 * scaleXY));
            ChildrenComboBox.Location = new Point((int)((0.5 * this.Width) - 0.5 * ChildrenComboBox.Size.Width), (int)(225 * scaleXY));
            AdultComboBox.Location = new Point((int)((0.5 * this.Width) - 0.5 * AdultComboBox.Size.Width), (int)(295 * scaleXY));

            AdultLabel.Font = new Font(AdultLabel.Font.FontFamily, (float)(19.8 * scaleXY));
            WeekLabel.Font = new Font(WeekLabel.Font.FontFamily, (float)(19.8 * scaleXY));
            ChildrenLabel.Font = new Font(ChildrenLabel.Font.FontFamily, (float)(19.8 * scaleXY));
            DaysLabel.Font = new Font(DaysLabel.Font.FontFamily, (float)(19.8 * scaleX));
            MainTextLabel.Font = new Font(MainTextLabel.Font.FontFamily, (float)(28.2 * scaleXY));

            MainTextLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * MainTextLabel.Size.Width), (int)(1 * scaleXY));
            WeekLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * WeekLabel.Size.Width), (int)(50 * scaleXY));
            DaysLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * DaysLabel.Size.Width), (int)(120 * scaleXY));
            ChildrenLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * ChildrenLabel.Size.Width), (int)(190 * scaleXY));
            AdultLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * AdultLabel.Size.Width), (int)(260 * scaleXY));
        }
    }
}
