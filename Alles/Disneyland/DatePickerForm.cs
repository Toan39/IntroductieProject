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
    public partial class DatePickerForm : Form
    {
		int selectedweek; //waarde door gebruiker gekozen
		List<datum> datalist = new List<datum>(); //de sql data geconverteerd naar een c# lijst
		List<datum> selectedweeklist = new List<datum>(); //de lijst met data van alleen de gekozen week
		SqlConnection con;
		public DatePickerForm(int week)
		{
			InitializeComponent();
			ReadSqlData();
			this.selectedweek = week;
			
		}
		public void maakconnectie()
		{
			string path = "Data Source=localhost;Initial Catalog=Tim123;Integrated Security=True"; //vul hier je eigen database path in
			con = new SqlConnection(path);
		}
		public void ReadSqlData()
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
					datalist.Add(new datum());
					datalist[t].week = int.Parse(reader.GetValue(0).ToString());
					DateTime timedate = DateTime.Parse(reader.GetValue(1).ToString()).Date;
					string shortdate = timedate.ToShortDateString();
					datalist[t].date = shortdate;
					datalist[t].neerslag = reader.GetValue(2).ToString();
					t++;
				}
				con.Close();
			}
		}
		public void MaakSelectedWeeklist()
		{
			datalist = datalist.OrderBy(x => x.neerslag).ToList();  //Sorteren op neerslag.
																	//gaat alle data af, als de week gelijk is aan de week die de gebruiker gekozen heeft, wordt die kolom met data in de selectedweeklist gekopieerd.
																	//deze lijst is ook gesorteerd op neerslag. 
			int i = 0;
			int j = 0;
			foreach (datum date in datalist)
			{
				if (selectedweek == datalist[i].week)
				{
					selectedweeklist.Add(new datum());
					selectedweeklist[j] = datalist[i];
					j++;
				}
				i++;
			}
		}

		public string ReturnBestDate()
		{
			MaakSelectedWeeklist();
			return ((selectedweeklist[0].date).ToString()); //Beste dag.
		}

		//De elementen van de lijsten.
		internal class datum
		{
			public int week;
			public string date;
			public string neerslag;
		}

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }
       /* private void datePicker()
        {
            label2.Text = 
        }*/

    }
}
