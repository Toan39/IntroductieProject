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
using System.IO;
using System.Threading;

namespace Disneyland
{
    public partial class DatePickerForm : Form
    {
		//declarations
		int selectedweek; 
		List<datepickerDate> datalist = new List<datepickerDate>(); 
		List<datepickerDate> selectedweeklist = new List<datepickerDate>(); 
		SqlConnection con;
		int crowdlevel;

	public DatePickerForm(int week, int price, int crowd)
		{
			// execute the datapicker function (output:best date + necessities)
			InitializeComponent();
			ReadSqlData();
			this.selectedweek = week;
			crowdlevel= crowd;
			CostLabel.Text = "Total estimated cost: €" + price.ToString();		
		}

		//makes sql connection
		public void MakeConnection()
		{
			string path = "Data Source=localhost;Initial Catalog=Tim123;Integrated Security=True"; 
			con = new SqlConnection(path);
		}

		public void ReadSqlData()
		{
			MakeConnection();
			using (con)
			{
				SqlCommand command = new SqlCommand
				(
				"SELECT * FROM dbo.TheDataAmountRain", con
				);
				con.Open();
				SqlDataReader reader = command.ExecuteReader();

				//adds the retrieved/read data to lists
				int t = 0;
				while (reader.Read())
				{
					datalist.Add(new datepickerDate());
					datalist[t].week = int.Parse(reader.GetValue(0).ToString());
					DateTime timedate = DateTime.Parse(reader.GetValue(1).ToString()).Date;
					string shortdate = timedate.ToShortDateString();
					datalist[t].date = shortdate;
					datalist[t].rain = reader.GetValue(2).ToString();
					t++;
				}
				con.Close();
			}
		}

		//Makes a new list that contains the data selected from sql-database.
		public void MakeSelectedWeekList()
		{
			datalist = datalist.OrderBy(x => x.rain).ToList();  //Orders the amount of rain from low to high.
																	
																	
			int i = 0;
			int j = 0;
			foreach (datepickerDate date in datalist)
			{
				if (selectedweek == datalist[i].week)
				{
					selectedweeklist.Add(new datepickerDate());
					selectedweeklist[j] = datalist[i];
					j++;
				}
				i++;
			}
		}

		//Converts the best Date to a string. So that it can be printed on the form.
		public string ReturnBestDate()
		{
			MakeSelectedWeekList();
			mmRainLabel.Text = selectedweeklist[0].rain + " mm rain";
			return ((selectedweeklist[0].date).ToString()); //Best day.
		}

		//Opens a link to google calendar where the user can add the best date.
		public void CalendarButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://calendar.google.com/calendar");
		}
		
		//Visual of the crowdlevel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
			e.Graphics.DrawRectangle(Pens.White, 0, 0, Crowdlevelpanel.Width+1, Crowdlevelpanel.Height+1);
			e.Graphics.FillRectangle(Brushes.Green, 1, 1, ((float)crowdlevel/(float)220 * Crowdlevelpanel.Width), Crowdlevelpanel.Height);
        }

		//Returns the user to the main form
        private void HomeButton_Click(object sender, EventArgs e)
        {
			MainMenu main = new MainMenu();
			main.Show();
			if (this.WindowState == FormWindowState.Maximized)
				main.WindowState = FormWindowState.Maximized;
			this.Hide();
		}

		//The elements of the list.
		internal class datepickerDate
		{
			public int week;
			public string date;
			public string rain;
		}

        private void DatePickerForm_SizeChanged(object sender, EventArgs e)
        {
			this.MinimumSize = new Size(616, 405);
			double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
			double scaleY = (double)this.Height / (double)this.MinimumSize.Height;

			HomeButton.Width = (int)(60 * scaleX);
			HomeButton.Height = (int)(24 * scaleY);

			CalendarButton.Width = (int)(616 * scaleX);
			CalendarButton.Height = (int)(45 * scaleY);
			CalendarButton.Location = new Point((int)((0.5 * this.Width) - 0.5 * CalendarButton.Size.Width), (int)(this.Height - 100));

			MainTextLabel.Font = new Font(MainTextLabel.Font.FontFamily, (float)(28.2 * scaleY));
			ResultLabel.Font = new Font(ResultLabel.Font.FontFamily, (float)(19.8 * scaleY));
			mmRainLabel.Font = new Font(mmRainLabel.Font.FontFamily, (float)(19.8 * scaleY));
			CrowdLabel.Font = new Font(CrowdLabel.Font.FontFamily, (float)(19.8 * scaleY));
			CostLabel.Font = new Font(CostLabel.Font.FontFamily, (float)(19.8 * scaleY));
			pictureBox1.Size = new Size((int)(104 * scaleX), (int)(80 * scaleY));
			Crowdlevelpanel.Size = new Size((int)(260 * scaleX), (int)(40 * scaleY));

			MainTextLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * MainTextLabel.Size.Width), (int)(1 * scaleY));
			ResultLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * ResultLabel.Size.Width), (int)(70 * scaleY));
			mmRainLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * mmRainLabel.Size.Width), (int)(120 * scaleY));
			CrowdLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * CrowdLabel.Size.Width), (int)(180 * scaleY));
			CostLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * CostLabel.Size.Width), (int)(270 * scaleY));
			Crowdlevelpanel.Location = new Point((int)((0.5 * this.Width) - 0.5 * Crowdlevelpanel.Size.Width), (int)(219 * scaleY));
			pictureBox1.Location = new Point((int)(150 * scaleX), (int)(105 * scaleY));
			Crowdlevelpanel.Invalidate();
		}
    }
}
