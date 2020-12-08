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


namespace Datepickertest
{
	public partial class DatePicker : Form
	{
		List<datum> datumlist = new List<datum>();
		int selectedmonth = 3; //waarden door gebruiker gekozen
		int selectedyear = 2021; //waarden door gebruiker gekozen
		SqlConnection con;
		public DatePicker()
		{
			InitializeComponent();
			ReadData();
			Console.WriteLine(ReturnBestDate());
		}

		private void maakconnectie()
		{
			string path = "Data Source=localhost;Initial Catalog=RainData;Integrated Security=True"; //database path
			con = new SqlConnection(path);
		}
		public void ReadData()
		{
			maakconnectie();
			using (con)
			{
				SqlCommand command = new SqlCommand
				(
				"SELECT * FROM dbo.TheDataAmountRain", con
				);
				con.Open();
				SqlDataReader reader = command.ExecuteReader();


				int t = 0;
				while (reader.Read())
				{
					datumlist.Add(new datum());
					datumlist[t].week = int.Parse(reader.GetValue(0).ToString());
					datumlist[t].date = reader.GetValue(1).ToString();
					datumlist[t].neerslag = float.Parse(reader.GetValue(2).ToString());
					t++;
				}
				con.Close();
			}
		}
		public string ReturnBestDate()
		{
			//de list wordt gesorteerd op neerslag
			datumlist = datumlist.OrderBy(x => x.neerslag).ToList();

			//print de hele list, gesorteerd.
			int i = 0;
			foreach (datum date in datumlist)
			{
				label1.Text = label1.Text + "week " + datumlist[i].week + "        " + datumlist[i].date + "         Neerslag: " + datumlist[i].neerslag + "\n";
				i++;
			}

			//print beste dag
			return ("beste dag: " + "\n" + datumlist[0].date + "         Neerslag: " + datumlist[0].neerslag);
		}

		internal class datum
		{
			public int week;
			public string date;
			public float neerslag;
		}
	}
}


