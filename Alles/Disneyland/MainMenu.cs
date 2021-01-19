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
            disney.Show();
            if(this.WindowState == FormWindowState.Maximized)
               disney.WindowState = FormWindowState.Maximized;
            disney.MinimumSize = new Size(616, 405);
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RouteMapInputForm disney2 = new RouteMapInputForm();
            disney2.Show();
            if (this.WindowState == FormWindowState.Maximized)
                disney2.WindowState = FormWindowState.Maximized;
            disney2.MinimumSize = new Size(616, 405);
            this.Hide();
        }

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(616, 405);
            double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
            double scaleY = (double)this.Height / (double)this.MinimumSize.Height;

            RouteButton.Width = (int)(204 * scaleX);
            RouteButton.Height = (int)(82 * scaleY);
            RouteButton.Location = new Point((int)(329*scaleX), (int)(274*scaleY));

            DatePickerButton.Width = (int)(204 * scaleX);
            DatePickerButton.Height = (int)(82 * scaleY);
            DatePickerButton.Location = new Point((int)(329*scaleX), (int)(187*scaleY));

            DisneyLandPictureBox.Size = new Size ((int)(204 * scaleX), (int)(239 * scaleY));
            DisneyLandPictureBox.Location = new Point((int)(51 * scaleX), (int)(128 * scaleY));

            MainTextLabel1.Font = new Font(MainTextLabel1.Font.FontFamily, (float)(28.2 * scaleY));
            MainTextLabel2.Font = new Font(MainTextLabel2.Font.FontFamily, (float)(19.8 * scaleY));

            MainTextLabel1.Location = new Point((int)((0.5 * this.Width) - 0.5 * MainTextLabel1.Size.Width), (int)(28 * scaleY));
            MainTextLabel2.Location = new Point((int)((0.5 * this.Width) - 0.5 * MainTextLabel2.Size.Width), (int)(93 * scaleY));
        }
    }
}
