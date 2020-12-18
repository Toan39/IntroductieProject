﻿using GMap.NET;
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
using System.Drawing.Printing;

namespace Disneyland
{
    public partial class RouteMap : Form
    {
        List<string> usedpoints = new List<string>();
        List<walktime> WTimes = new List<walktime>();
        public RouteMap(string tijd)
        {
            InitializeComponent();
            maakwalktimelist();
           
            int InsertedTime = (int.Parse(tijd) * 60);
            
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

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument document = new PrintDocument();
            document.DocumentName = "DisneyRoute";
            print.Document = document;
            print.AllowSelection = true;
            print.AllowSomePages = true;
            if(print.ShowDialog()==DialogResult.OK)
            {
                document.Print();
            }
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            Form3 rides = new Form3();
            rides.Show();
            this.Hide();
        }

        void sorteer()
        {
            WTimes = WTimes.OrderBy(x => x.TotalTime).ToList();
        }

        public string returnlowest(int Inserted)
        {
            string lowest = "";
            float verbruiktetijd = 0;
            string previous = "";
            for (int i = 0; (verbruiktetijd + WTimes[i].TotalTime) < Inserted; i++)
            {

                if (possible(WTimes[i].EndPoint.ToString()) && begincheck(WTimes[i].StartPoint.ToString(), previous))
                {
                    lowest = lowest + WTimes[i].EndPoint.ToString() + "\n";
                    usedpoints.Add(WTimes[i].EndPoint.ToString());
                    verbruiktetijd = verbruiktetijd + WTimes[i].TotalTime;
                    previous = WTimes[i].EndPoint.ToString();
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
        public void maakwalktimelist()
        {
            string connectionString;
            string sql;
            connectionString = @"Data Source=localhost;Initial Catalog=Tim123;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            sql = "select * from TheDataWalkTime";

            using (con)
            {
                SqlCommand command = new SqlCommand
                    (
                    sql, con
                    );
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                int t = 0;
                while (reader.Read())
                {
                    WTimes.Add(new walktime());
                    WTimes[t].StartPoint = reader.GetValue(0).ToString();
                    WTimes[t].EndPoint = reader.GetValue(1).ToString();
                    WTimes[t].Distance = int.Parse(reader.GetValue(2).ToString());
                    WTimes[t].WalkTime = float.Parse(reader.GetValue(3).ToString());
                    WTimes[t].TotalTime = float.Parse(reader.GetValue(4).ToString());
                    t++;
                }
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
