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
            this.MinimumSize = new Size(616, 405);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatePickerInputForm disney = new DatePickerInputForm();
            if(this.WindowState == FormWindowState.Maximized)
               disney.WindowState = FormWindowState.Maximized;
            disney.MinimumSize = new Size(616, 405);
            disney.Size = this.Size;
            this.Hide();
            disney.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RouteMapInputForm disney2 = new RouteMapInputForm();
            if (this.WindowState == FormWindowState.Maximized)
                disney2.WindowState = FormWindowState.Maximized;
            disney2.MinimumSize = new Size(616, 405);
            disney2.Size = this.Size;
            this.Hide();
            disney2.ShowDialog();
            this.Close();

        }
    }
}
