using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;
using Dapper;
using System.Collections;
using System.Globalization;

namespace Disneyland
{
    public partial class Form3 : Form
    {

        //varabiales declarations//
        
            List<Rij> datalist = new List<Rij>();
            List<string> usedpoints = new List<string>();
        
        
        public Form3()
         {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            InitializeComponent();
         }

        ////void methods////
            

            void sorteer()
            {
                datalist = datalist.OrderBy(x => x.TotalTime).ToList();
            }

            public string returnlowest(int Inserted)
            {
                string lowest = "";
                float verbruiktetijd = 0;
                string previous = "";
                for (int i = 0; (verbruiktetijd + datalist[i].TotalTime) < Inserted; i++)
                {

                    if (possible(datalist[i].EndPoint.ToString()) && begincheck(datalist[i].StartPoint.ToString(), previous))
                    {
                        lowest = lowest + datalist[i].EndPoint.ToString() + "\n";
                        usedpoints.Add(datalist[i].EndPoint.ToString());
                        verbruiktetijd = verbruiktetijd + datalist[i].TotalTime;
                        previous = datalist[i].EndPoint.ToString();
                        i = 0;
                    }
                }
                return (lowest);
            }

            public void makelist()
            {

                for (int p = 0; p < (usedpoints.Count); p++)
                {
                    int k = 0;
                    foreach (quetime Name in DataService.QTimes())
                    {
                        if (DataService.QTimes()[k].Number == usedpoints[p])
                        {

                            DataService.att.Add(new attraction());
                            DataService.att[p].Name = DataService.QTimes()[k].Name;
                            DataService.att[p].Lat = DataService.QTimes()[k].Lat;
                            DataService.att[p].Lon = DataService.QTimes()[k].Lon;
                        }
                        k++;
                    }
                   
                }
            }

            public bool possible(string x)
            {
                foreach (string endpoint in usedpoints)
                {
                    if (x == endpoint)
                    {
                        return false;
                    }
                }
                return true;
            }

            public bool begincheck(string y, string z)
            {
                if (z != "")
                {
                    if (y == z)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }

        internal class Rij
        {
            public string StartPoint;
            public string EndPoint;
            public float Distance;
            public float WalkTime;
            public float TotalTime;
        }
        public class quetime
        {
            public string Number { get; set; }
            public string Name { get; set; }
            public float AverageQueTime { get; set; }
            public float RideTime { get; set; }

            public double Lat { get; set; }
            public double Lon { get; set; }
        }

        public class walktime
        {
            public string StartPoint { get; set; }
            public string EndPoint { get; set; }
            public float Distance { get; set; }
            public float WalkTime { get; set; }
            public float TotalTime { get; set; }
        }

        public static class DataService
        {
            public static List<quetime> QTimes()
            {
                string connectionString;
                string sql;

                connectionString = @"Data Source=localhost;Initial Catalog=Tim123;Integrated Security=True";
                sql = "select * from TheDataQueTime";

                using (var connect = new SqlConnection(connectionString))
                {
                    var result = connect.Query<quetime>(sql).ToList();
                    return result;
                }
            }

            public static List<walktime> WTimes()
            {
                string connectionString;
                string sql;

                connectionString = @"Data Source=localhost;Initial Catalog=Tim123;Integrated Security=True";
                sql = "select * from TheDataWalkTime";

                using (var connect = new SqlConnection(connectionString))
                {
                    var result = connect.Query<walktime>(sql).ToList();
                    return result;
                }

            
            }
            public static List<attraction> att = new List<attraction>();
        }
       

        public void button1_Click(object sender, EventArgs e)
        {
            Form5 map = new Form5();
            //map.attractionlist = DataService.att;
            String s = comboBox1.Text;
            string a = comboBox2.Text;
            int InsertedTime = 100;  /*int.Parse(comboBox1.Text.ToString()) * 60;*/
            int x = 0;
            int q = 0;

            try
            {x = int.Parse(s);}
            catch(Exception)
            {}
            try
            {q = int.Parse(a);}
            catch(Exception)
            {}

            if (x + q > 10)
            {MessageBox.Show("Dit is meer dan 10 uur, dan is disneyland al dicht. Selecteer andere tijden.");}
            if(comboBox1.SelectedItem == null)
            {MessageBox.Show("Er is geen tijd doorgegeven.");}
            if (comboBox2.SelectedItem == null)
            { MessageBox.Show("Er is geen tijd doorgegeven."); }
            if (checkedListBox.SelectedItem == null)
            { MessageBox.Show("Er zijn geen attracties doorgegeven"); }
           
            if(x+q<10&&checkedListBox.SelectedItem!=null&&comboBox1.SelectedItem!=null&&comboBox2.SelectedItem!=null)
            { map.Show();
              this.Hide();
            }

            int i = 0;
            foreach (walktime startpoint in DataService.WTimes())
            {
                datalist.Add(new Rij());
                datalist[i].StartPoint = DataService.WTimes()[i].StartPoint;
                datalist[i].EndPoint = DataService.WTimes()[i].EndPoint;
                datalist[i].Distance = DataService.WTimes()[i].Distance;
                datalist[i].WalkTime = DataService.WTimes()[i].WalkTime;
                datalist[i].TotalTime = DataService.WTimes()[i].TotalTime;
                i++;
            }
            sorteer();
            returnlowest(InsertedTime);
            makelist();
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in checkedListBox.CheckedItems)
        {
            listBoxItem.Items.Add(s);
            listBoxItem.Invalidate();
        }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/activiteiten/");
        }
    }
}


