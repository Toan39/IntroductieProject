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

        private void FindDateButton_Click(object sender, EventArgs e)
        {
            DatePickerForm date = new DatePickerForm(int.Parse(this.WeekTextbox.Text));
			date.label2.Text = date.ReturnBestDate();
            date.Show();
            this.Hide();
        }

    }
}
