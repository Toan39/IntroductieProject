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
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Creation of the main menu where the user can select the datepicker-function(finds best date) or RouteMap-function (seeks best route)
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatePickerInputForm disney = new DatePickerInputForm();
            disney.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RouteMapInputForm disney2 = new RouteMapInputForm();
            disney2.ShowDialog();
            this.Close();

        }
    }
}
