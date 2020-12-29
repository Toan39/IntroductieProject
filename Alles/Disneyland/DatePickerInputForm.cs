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
            int kind = 0;
            int week = int.Parse(WeekTextbox.Text);
            try
            {
                kind = int.Parse(ChildrenComboBox.Text);
            }
            catch (Exception) { };
            if (ChildrenComboBox.Text==null)
            {
                kind = 0;
            }
           
            int ouder = int.Parse(AdultComboBox.Text);
            int dag = int.Parse(DaysComboBox.Text);
            int prijs = 0;
            
            if (week > 52)
            {
                MessageBox.Show("Een jaar heeft niet meer dan 52 weken. Voer een weeknummer onder de 52 in.");
            }
            else
            {
                
                if (week < 2)
                {
                    prijs = 89 * ouder + 82 * kind;
                }
                else if (week > 2 && week < 12)
                {
                    prijs = 54 * ouder + 50 * kind;

                }
                else if (week > 12 && week < 22)
                {
                    prijs = 79 * ouder + 73 * kind;
                }
                else if (week > 22 && week < 32)
                {
                    prijs = 89 * ouder + 82 * kind;
                }
                else if (week > 32 && week < 40)
                {
                    prijs = 79 * ouder + 73 * kind;
                }
                else if (week > 40 && week < 48)
                {
                    prijs = 54 * ouder + 50 * kind;
                }
                else if (week > 48)
                {
                    prijs = 89 * ouder + 82 * kind;
                }
                if(dag!=0)
                {
                    if(dag == 1)
                    {
                        dag = 0;
                    }
                    int personen = ouder + kind;
                    int kamer = 200 * dag;
                    int hotel = kamer * (personen/2 + personen%2*2);
                    prijs = prijs + hotel;
                }
                
                DatePickerForm date = new DatePickerForm(week, prijs);
                date.ResultLabel.Text = date.ReturnBestDate();
                date.Show();
                this.Hide();
            }
        }
    }
}
