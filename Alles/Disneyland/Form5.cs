using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.Collections;


namespace Disneyland
{
    public partial class Form5 : Form
    {
        List<Rij> datalist = new List<Rij>();
        List<string> usedpoints = new List<string>();
        public Form5(string tijd)
        {
            InitializeComponent();
            int InsertedTime = (int.Parse(tijd) * 60);
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


           for (int t = 0; t < Lijst.att.Count; t++)
            {
                int x = t + 1;
                string result = "";
                result = x.ToString() + ". " + result + Lijst.att[t].Name + "\n";
                label2.Text = label2.Text + result;
            }

            // System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/plattegronden/");
        }


        public static class Lijst
        {
            public static List<attraction> att = new List<attraction>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 rides = new Form3();
            rides.Show();
            this.Hide();
        }

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
        

        public void makelist()
        {

            for (int p = 0; p < (usedpoints.Count); p++)
            {
                int k = 0;
                foreach (quetime Name in DataService.QTimes())
                {
                    if (DataService.QTimes()[k].Number == usedpoints[p])
                    {

                        Lijst.att.Add(new attraction());
                        Lijst.att[p].Name = DataService.QTimes()[k].Name;
                        Lijst.att[p].Lat = DataService.QTimes()[k].Lat;
                        Lijst.att[p].Lon = DataService.QTimes()[k].Lon;
                    }
                    k++;
                }

            }
        }



        private void gmap_Load_1(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(48.872562, 2.773616);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 16;
            gmap.ShowCenter = false;
            gmap.DragButton = MouseButtons.Left;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker[] mark;
            mark = new GMapMarker[1000];



            for (int t = 0; t < Lijst.att.Count; t++)
            {
                PointLatLng p = new PointLatLng(Lijst.att[t].Lat, Lijst.att[t].Lon);
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
                marker.ToolTipText = (t + 1).ToString();
                marker.ToolTipMode = MarkerTooltipMode.Always;
                mark[t] = marker;

            }
        }
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

    public class attraction
    {
        public string Name;
        public double Lat;
        public double Lon;
    }
}
