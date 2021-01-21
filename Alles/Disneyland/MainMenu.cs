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

        private void DatePickerButton_Click(object sender, EventArgs e)
        {
            DatePickerInputForm UserInputsDatePicker = new DatePickerInputForm();

            //Keeps the form maximized when changing to another form 
            if (this.WindowState == FormWindowState.Maximized)
                UserInputsDatePicker.WindowState = FormWindowState.Maximized;

            //prevents that the form can not be made smaller than the default size
            UserInputsDatePicker.MinimumSize = new Size(616, 405);

            UserInputsDatePicker.Size = this.Size;
            this.Hide();
            UserInputsDatePicker.ShowDialog();
            this.Close();
        }

        private void RouteButton_Click(object sender, EventArgs e)
        {
            RouteMapInputForm UserInputsRouteMap = new RouteMapInputForm();

            //Keeps the form maximized when changing to another form 
            if (this.WindowState == FormWindowState.Maximized)
                UserInputsRouteMap.WindowState = FormWindowState.Maximized;

            //Prevents that the form can not be made smaller than the default size
            UserInputsRouteMap.MinimumSize = new Size(616, 405);
            UserInputsRouteMap.Size = this.Size;

            this.Hide();
            UserInputsRouteMap.ShowDialog();
            this.Close();

        }
    }
}
