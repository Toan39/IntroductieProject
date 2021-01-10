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
        //List<string> usedpoints = new List<string>();
        List<genal> listForGenAl = new List<genal>();
        List<walktime> WTimes = new List<walktime>();

        float[] fitness;
        string[][] population;
        float sumTime = 0;
        int s = 0;
        int UpperBoundTime = 480;
        public Form5(string tijd, List <string> selecteditems)
        {
            int m = selecteditems.Count;
            int popsize =m*1000; // select 3 attractions, to have low processing time
            fitness = new float[popsize];
            population = new string[popsize][];

            InitializeComponent();
            maakwalktimelist();
            DownScaleList(selecteditems);
            CreatePopulation(popsize, selecteditems);
            //int InsertedTime = (int.Parse(tijd) * 60);

           
            
            //sorteer();
            //returnlowest(InsertedTime);

            PrintLabel();
      
            // System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/plattegronden/");
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
                    //WTimes[t].Distance = int.Parse(reader.GetValue(2).ToString());
                    //WTimes[t].WalkTime = float.Parse(reader.GetValue(3).ToString());
                    WTimes[t].TotalTime = float.Parse(reader.GetValue(4).ToString());
                    t++;
                }
            }
        }


        
        public void DownScaleList(List<string> selecteditems)
        {
          
            for (int p = 0; p < selecteditems.Count; p++)
            {
                int k = 0;
                foreach (quetime Name in DataService.QTimes())
                {
                    if (DataService.QTimes()[k].Name == selecteditems[p])
                    {
                        Lijst.att.Add(new attraction());
                        Lijst.att[p].Number = DataService.QTimes()[k].Number;
                        //Lijst.att[p].Name = DataService.QTimes()[k].Name;
                        //Lijst.att[p].Lat = DataService.QTimes()[k].Lat;
                        //Lijst.att[p].Lon = DataService.QTimes()[k].Lon;
                    }
                    k++;
                }
            }

            //Lijst.att.Add(new attraction());
            //p = selectedPoints.Count;
            //Lijst.att[p].Name = DataService.QTimes()[26].Name;
            //Lijst.att[p].Lat = DataService.QTimes()[26].Lat;
            //Lijst.att[p].Lon = DataService.QTimes()[26].Lon;
        }

       

        public void CreatePopulation(int k, List<string> selecteditems)
        {
            for (int z = 0; z < k;)
            {
                shuffler.Shuffle(Lijst.att);
                SelectItems(selecteditems);
                FunctionSumTime();

                if (sumTime < UpperBoundTime)
                {
                    fitness[z] = sumTime;
                    CreatePointArray(listForGenAl.Count);
                    z++;
                }
                sumTime = 0;
                listForGenAl.Clear();
            }

            //print the arrays in the jagged array with the index number in console
            for (int i = 0; i < population.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < population[i].Length; j++)
                {
                    Console.Write("{0}{1}", population[i][j], j == (population[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
        }
       

        

        public void SelectItems(List<string> selecteditems)
        {
            string previous = "P1RA11";
            int a = 1;
            int i = 0;

            bool done = true;
            listForGenAl.Add(new genal());
            listForGenAl[0].Endpoint = "P1RA11";
            listForGenAl[0].TotalTime = 0;
            while (i < WTimes.Count && done == true)
            {
                if (possible(WTimes[i].EndPoint.ToString()) && begincheck(WTimes[i].StartPoint.ToString(), previous) && selected(WTimes[i].EndPoint.ToString(), a))
                {
                    listForGenAl.Add(new genal());
                    listForGenAl[a].Endpoint = WTimes[i].EndPoint.ToString();
                    listForGenAl[a].TotalTime = routecheck(previous, WTimes[i].EndPoint.ToString());
                    previous = WTimes[i].EndPoint.ToString();
                    a++;
                    if (a == selecteditems.Count+1)
                    {
                        done = false;
                        listForGenAl.Add(new genal());
                        listForGenAl[a].Endpoint = "P1RA11";
                        listForGenAl[a].TotalTime = routecheck(previous, "P1RA11");
                    }
                    i = 0;
                }
                i++;
            }
        }

        public bool possible(string x)
        {
            foreach (genal genal in listForGenAl)
            {
                if (x == genal.Endpoint)
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

        public bool selected(string selected, int a)
        {
            if (selected == Lijst.att[a - 1].Number)
            {
                return true;
            }
            return false;
        }

        public float routecheck(string start, string end)
        {
            float totaltime;
            for (int t = 0; t < WTimes.Count; t++)
            {
                if (start == WTimes[t].StartPoint.ToString() && end == WTimes[t].EndPoint.ToString())
                {
                    totaltime = WTimes[t].TotalTime;
                    return totaltime;
                }
            }
            return 0;
        }



        public void FunctionSumTime()
        {
            foreach (genal attraction in listForGenAl)
            {
                sumTime = sumTime + attraction.TotalTime;  // 1. : sum=0 , 2: sum=0 , 3: sum=120, 4: sum= 120+140
            }
        }

        public void CreatePointArray(int z)
        {
            string[] index = new string[z];
            for (int t = 0; t < z; t++)
            {
                index[t] = listForGenAl[t].Endpoint;
            }
            population[s] = index;
            s++;
        }



        //void sorteer()
        //    {
        //        WTimes = WTimes.OrderBy(x => x.TotalTime).ToList();
        //    }

        //public string returnlowest(int Inserted)
        //{
        //    string lowest = "";
        //    float verbruiktetijd = 0;
        //    string previous = "";
        //    for (int i = 0; (verbruiktetijd + WTimes[i].TotalTime) < Inserted; i++)
        //    {

        //        if (possible(WTimes[i].EndPoint.ToString()) && begincheck(WTimes[i].StartPoint.ToString(), previous))
        //        {
        //            usedpoints.Add(WTimes[i].EndPoint.ToString());
        //            verbruiktetijd = verbruiktetijd + WTimes[i].TotalTime;
        //            previous = WTimes[i].EndPoint.ToString();
        //            i = 0;
        //        }
        //    }
        //}


        //public void makelist()
        //{

        //    for (int p = 0; p < (usedpoints.Count); p++)
        //    {
        //        int k = 0;
        //        foreach (quetime Name in DataService.QTimes())
        //        {
        //            if (DataService.QTimes()[k].Number == usedpoints[p])
        //            {

        //                Lijst.att.Add(new attraction());
        //                Lijst.att[p].Name = DataService.QTimes()[k].Name;
        //                Lijst.att[p].Lat = DataService.QTimes()[k].Lat;
        //                Lijst.att[p].Lon = DataService.QTimes()[k].Lon;
        //            }
        //            k++;
        //        }

        //    }
        //}

        //private void gmap_Load_1(object sender, EventArgs e)
        //{
        //    gmap.MapProvider = GMapProviders.GoogleMap;
        //    GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
        //    gmap.Position = new GMap.NET.PointLatLng(48.872562, 2.773616);
        //    gmap.MinZoom = 5;
        //    gmap.MaxZoom = 100;
        //    gmap.Zoom = 16;
        //    gmap.ShowCenter = false;
        //    gmap.DragButton = MouseButtons.Left;
        //    GMapOverlay markers = new GMapOverlay("markers");
        //    GMapMarker[] mark;
        //    mark = new GMapMarker[1000];



        //    for (int t = 0; t < Lijst.att.Count; t++)
        //    {
        //        PointLatLng p = new PointLatLng(Lijst.att[t].Lat, Lijst.att[t].Lon);
        //        GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.blue_pushpin);
        //        markers.Markers.Add(marker);
        //        gmap.Overlays.Add(markers);
        //        marker.ToolTipText = (t + 1).ToString();
        //        marker.ToolTipMode = MarkerTooltipMode.Always;
        //        mark[t] = marker;

        //    }
        //}
        public void PrintLabel()
        {
            for (int t = 0; t < listForGenAl.Count; t++)
            {
                int x = t + 1;
                string result = "";
                result = x.ToString() + ". " + result + listForGenAl[t].Endpoint + " " + listForGenAl[t].TotalTime.ToString() + "\n";
                label2.Text = label2.Text + result;
            }
        }
    }

    public static class shuffler
    {
        public static Random rng = new Random(); // taken from the internet
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
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

    public static class Lijst
    {
        public static List<attraction> att = new List<attraction>();
    }

    public class genal
    {
        public string Endpoint;
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
        //public float Distance { get; set; }
        //public float WalkTime { get; set; }
        public float TotalTime { get; set; }
    }

    public class attraction
    {
        public string Number;
        //public string Name;
        //public double Lat;
        //public double Lon;
    }
}
