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
    public partial class DatePickerOutputForm : Form
    {
		//declarations
		int selectedweek; 
		List<datepickerDate> datalist = new List<datepickerDate>(); 
		List<datepickerDate> selectedweeklist = new List<datepickerDate>(); 
		SqlConnection con;
		int crowdlevel;

	public DatePickerOutputForm(int week, int price, int crowd)
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

		//Reads the sql-data from the database
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
			e.Graphics.DrawRectangle(Pens.White, 0, 0, Crowdlevelpanel.Width-1, Crowdlevelpanel.Height-1);
			e.Graphics.FillRectangle(Brushes.Green, 1, 1, ((float)crowdlevel/(float)220 * Crowdlevelpanel.Width-2), Crowdlevelpanel.Height-2);
        }

		//Returns the user to the main form
        private void HomeButton_Click(object sender, EventArgs e)
        {
			MainMenu main = new MainMenu();

			//Keeps the size of the previous form
			if (this.WindowState == FormWindowState.Maximized)
				main.WindowState = FormWindowState.Maximized;
			main.Size = this.Size;

			this.Hide();
			main.ShowDialog();
			this.Close();
		}

		//The elements of the list.
		internal class datepickerDate
		{
			public int week;
			public string date;
			public string rain;
		}
    }
}
