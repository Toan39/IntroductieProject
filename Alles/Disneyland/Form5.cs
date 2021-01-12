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
using System.Threading;
using System.Collections;


namespace Disneyland
{
    public partial class Form5 : Form
    {
        List<genal> listForGenAl = new List<genal>();
        List<walktime> WTimes = new List<walktime>();
        List<string> BestChromosome = new List<string>();
        List<string>  AttNumber = new List<string>();
        List<string> FinalRoute = new List<string>();
        //List<string> LowChromosome = new List<string>();

        int[] indexPopulation;
        float[] fitnesstime, fitness, fitnessParents;
        string[] CurrentChromosome;
        string[] parent1;
        string[] parent2;
        string[] child;
        string[][] population;
        string[][] parents;
        
        
        int s = 0; 
        int stop = 0;
        int UpperBoundTime = 480;
        float bestFitness = 0;
        float sumTime = 0;
        float higherbound = 0 ;
        int index;

        public Form5(string tijd, List <string> selecteditems)
        {
            int m = selecteditems.Count;  // select 3 attractions, to have low processing time
            fitnesstime = new float[popsize(m)];
            fitness = new float[popsize(m)];
            population = new string[popsize(m)][];
         

            InitializeComponent();
            //makewalktimelist();
            //Order();
            //MakeChromosome(UpperBoundTime);

            DownScaleList(selecteditems, AttNumber, "Number");
            CreatePopulation(popsize(m), selecteditems, m);
            FitnessFunction();
            Selection();
            CreateChild(m);
            //NextGeneration();
            //NormalizeFitness();
            
            //DownScaleList(BestChromosome, FinalRoute, "Name");
            foreach(string s in FinalRoute)
            {
                Console.WriteLine(s);
            }
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



        public int popsize(int number)
        {
            int popsize = number;
            if (number <= 5)
            {  
                for (int i = number - 1; i >= 1; i--)
                {
                    popsize = popsize * i/*+6*/;
                }
            }
            else
            {
                popsize = number * 300;
            }
            return popsize;
        }

        public void makewalktimelist()
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

        //public void Order()
        //{
        //    WTimes = WTimes.OrderBy(x => x.TotalTime).ToList();
        //}

        //public string MakeChromosome( int UpperBoundTime)
        //{
        //    string lowest = "";
        //    float usedTime = 0;
        //    string previous = "";
        //    for (int i = 0; (usedTime + WTimes[i].TotalTime) < UpperBoundTime; i++)
        //    {

        //        if (possible(WTimes[i].EndPoint.ToString()) && begincheck(WTimes[i].StartPoint.ToString(), previous))
        //        {
        //            LowChromosome.Add(WTimes[i].EndPoint.ToString());
        //            usedTime = usedTime + WTimes[i].TotalTime;
        //            previous = WTimes[i].EndPoint.ToString();
        //            i = 0;
        //        }
        //    }
        //    foreach (string s in LowChromosome)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.WriteLine("\n");
        //    return lowest;
        //}


        //Compares ListA with ListB and then adds items that are the same into ListB. 
        //And type is the object that is going to be added
        public void DownScaleList(List<string> ListA, List<string> ListB, string type)
        {
          
            for (int p = 0; p < ListA.Count; p++)
            {
                int k = 0;
                foreach (quetime Name in DataService.QTimes())
                {
                    if (type == "Number")
                    {
                        if (DataService.QTimes()[k].Name == ListA[p])
                        {
                            ListB.Add(DataService.QTimes()[k].Number);
                        }
                    }              

                    if (type=="Name")
                    {
                        if (DataService.QTimes()[k].Number == ListA[p])
                        {
                            ListB.Add(DataService.QTimes()[k].Name);
                            Lijst.attLoc.Add(new attractionLoc());
                            Lijst.attLoc[p].Lat = DataService.QTimes()[k].Lat;
                            Lijst.attLoc[p].Lon = DataService.QTimes()[k].Lon;
                        }
                    }
                    k++;
                }
            }
        }

        public void CreatePopulation(int k, List<string> selecteditems, int selected)
        {
            for (int z = 0; z < k;)
            {
                shuffler.Shuffle(AttNumber);
                SelectItems(selecteditems);
                FunctionSumTime();

                if (duplicate(selected) == false)
                {
                    if (sumTime < UpperBoundTime)
                    {
                        fitnesstime[z] = sumTime;
                        CreatePointArray(listForGenAl.Count);
                        z++;
                    }
                }
                sumTime = 0;
                listForGenAl.Clear();
            }

            //print the arrays in the jagged array with the index number in console
            //for (int i = 0; i < population.Length; i++)
            //{
            //    Console.Write("Element({0}): ", i);

            //    for (int j = 0; j < population[i].Length; j++)
            //    {
            //        Console.Write("{0}{1}", population[i][j], j == (population[i].Length - 1) ? "" : " ");
            //    }
            //    Console.WriteLine();
            //}
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
            if (selected == AttNumber[a - 1])
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

        public bool duplicate(int selected)
        {
            if (selected==5) //reshuffling with 5 amount of selected attractions --> extreme amount of reshuffles.
            {
                return false;      
            }
            for (int t=0; t<fitnesstime.Length; t++)
            {
                if(sumTime == fitnesstime[t])
                {
                    return true;
                }
            }
            return false;
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

     
        public void FitnessFunction()
        {
            fitnesstime.CopyTo(fitness, 0);

            for(int t=0; t< fitness.Length; t++)
            {
                fitness[t] = 100-( fitness[t] / UpperBoundTime* 100); //How lower the time of a whole route the closer the fitness is to 100
                /*Console.WriteLine(fitness[t]);*/ //prints fitness array
            }

            higherbound = fitness.Max();
            if (higherbound>bestFitness)
            {
                bestFitness = higherbound;
                int CurrentBest= Array.IndexOf(fitness, bestFitness); //This is the index of the best chromosome
                
                CurrentChromosome = (string[])population.GetValue(CurrentBest); //array of population
                BestChromosome = CurrentChromosome.ToList(); //Best chromosome as a list
                //foreach(string s in BestChromosome)
                //{
                //    Console.WriteLine(s);
                //}
                //Console.WriteLine("\n");
            }
            /*else
            {
              stop++;     
            }*/
            

        }

        //Selects top 10 percentile of the population 
        public void Selection()
        {
            float lowerbound = higherbound - (higherbound / 10);  //dependds on how many parents is needed 
            fitness.OrderBy(x => x); //sort it from low to high
            fitnessParents = Array.FindAll(fitness, x =>
                                      x >= lowerbound && x <= higherbound);

            //for (int t = 0; t < parents.Length; t++)
            //{
            //    Console.WriteLine(parents[t]);
            //}

        }

        public void CreateChild(int selected)
        {
            Random rnd = new Random();
            indexPopulation = new int[fitnessParents.Length];
            parents= new string[indexPopulation.Length][];
            parent2 = new string[selected];
            parent1 = new string[selected];
           
            for (int t = 0; t < fitnessParents.Length; t++)
            {
                index = Array.IndexOf(fitness, fitnessParents[t]);  //Indexs of the population     
                indexPopulation[t] = index;
            }

            for (int t = 0; t < indexPopulation.Length; t++)
            {
                parents[t]= (string[])population.GetValue(indexPopulation[t]);
            }

                int r = rnd.Next(indexPopulation.Length);
                parent1=parents[r];
                r = rnd.Next(indexPopulation.Length);
                parent2 = parents[r];

            int lowerbound = 1; 
            int upperbound = parent1.Length - 1;
            child = new string[selected];
           
            int crossoverlength = rnd.Next(2,upperbound - 2); //upperbound niet vergeten.
            int crossoverpoint = rnd.Next(lowerbound, upperbound - crossoverlength);


            Array.Copy(parent1, crossoverpoint, child, 0, crossoverlength);

            
            crossover(crossoverlength, crossoverpoint);
           



            for (int t = 0; t < parent2.Length; t++)
            {
                Console.WriteLine(parent1[t]);
            }
            Console.WriteLine("\n");
            for (int t = 0; t < parent2.Length; t++)
            {
                Console.WriteLine(parent2[t]);
            }
            Console.WriteLine("\n");
            for (int t = 0; t < child.Length; t++)
            {
                Console.WriteLine(child[t]);
            }
        }

        public void crossover(int crossoverlength, int crossoverpoint)
        {
            bool check = true;
            int p = 0;
            for (int z = 1; z < parent2.Length - 1; z++)
            {
                for (int x = 0; x < child.Length; x++)
                {
                    if (parent2[z] == child[x])
                    {
                        check = false;
                    }
                }

                if(check)
                {
                    child[crossoverlength + p] = parent2[z];
                    p++;
                }

                check = true;
            }

        }

        ///////////// Notmalize function for last step
        /*public void NormalizeFitness()
        {
            for (int t = 0; t < fitness.Length; t++)
            {
                float p = 100 - fitness[t];
                fitness[t] =p/ 100 * UpperBoundTime;
                Console.WriteLine(fitness[t]); //prints fitness array
            }
        }*/

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

    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
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
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
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
        public static List<attractionLoc> attLoc = new List<attractionLoc>();
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

    public class attractionLoc
    {
        public double Lat;
        public double Lon;
    }
}
