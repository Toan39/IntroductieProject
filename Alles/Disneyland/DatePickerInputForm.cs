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
            if (int.Parse(WeekTextbox.Text) > 52)
            {
                MessageBox.Show("Een jaar heeft niet meer dan 52 weken. Voer een weeknummer onder de 52 in.");
            }
            else
            {
                DatePickerForm date = new DatePickerForm(int.Parse(this.WeekTextbox.Text));
                date.ResultLabel.Text = date.ReturnBestDate();
                date.Show();
                this.Hide();
            }
        }
    }
}
