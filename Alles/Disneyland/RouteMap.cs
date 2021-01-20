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
using System.Threading;
using System.Drawing.Printing;

namespace Disneyland
{
    public partial class RouteMap : Form
    {
        Random rnd = new Random();

        //declarations of lists
        List<genal> listForGenAl = new List<genal>();
        List<walktime> WTimes = new List<walktime>();
        List<string> BestChromosome = new List<string>();
        List<string> AttID = new List<string>();
        List<string> FinalRoute = new List<string>();

        //declarations of arrays
        int[] indexPopulation;
        float[] fitnesstime, fitness, fitnessParents;
        string[] CurrentChromosome, parent1, parent2, child;
        string[][] population, parents;

        //declarations of variables
        bool betterChromo;
        int CurrentBest, index;
        int s=0; //index of the population array  
        int GenerationCount = 0; // The current generation. The int GenerationCount is not the amount of generations
        public int UpperBoundTime = 480; // this is the amount of minutes that is assumed for how long  Disneyland is open 
        float bestFitness, sumTime;
        public float higherbound = 0;
        
        //gmap declarations.
        GMapMarker[] mark = new GMapMarker[30];
        GMapOverlay markers = new GMapOverlay("markers");

        public RouteMap(List<string> selecteditems, bool checktime)
        {
            int selected = selecteditems.Count;  //Amount of selected attractions by the user // select 3 attractions, to have low processing time
            //The length of the arrays 
            fitnesstime = new float[popsize(selected)];
            fitness = new float[popsize(selected)];
            population = new string[popsize(selected)][];
            parent2 = new string[selected + 2]; //the +2 is because the whole chromosome has ports
            parent1 = new string[selected + 2];

            InitializeComponent();
            ///<summary>
            ///Genetic Algorithm (finds a approximately best route )
            ///</summary>
            MakeWalktimelist();
            DownScaleList(selecteditems, AttID, "ID");
            CreatePopulation(popsize(selected), selected, "Initial", AttID);
            
            FitnessFunction();
            
            if(checktime == false)
            {
                Selection(selected);

                Termination(popsize(selected), selected);
                Console.WriteLine("end");
            }
           
        }

        //Calculates the populationsize
        public int popsize(int selected)
        {
            int popsize = selected;
            if (selected <= 5)   //For less then 6 attractions a factioral calculation can be used
            {
                for (int i = selected - 1; i >= 1; i--)
                {
                    popsize = popsize * i;
                }
            }
            else
            {
                int factor = 10 * selected / 2;
                popsize = selected * factor;
            }
            return popsize;
        }

        /// <summary>
        ///  PrintButton: Lets the user print out the route generated by the Genetic Algorithm, 
        ///  SwitchButton: Returns the user back to the home form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument document = new PrintDocument();
            document.DocumentName = "DisneyRoute";
            print.Document = document;
            print.AllowSelection = true;
            print.AllowSomePages = true;
            if (print.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            BestChromosome.Clear();
            FinalRoute.Clear();
            Lijst.attLoc.Clear();
            MainMenu main = new MainMenu();
            if (this.WindowState == FormWindowState.Maximized)
                main.WindowState = FormWindowState.Maximized;
            main.Size = this.Size;
            this.Hide();
            main.ShowDialog();
            this.Close ();
        }

        //Retrievies the needed SQL data from the sql-database for the Genetic Algorithm
        public void MakeWalktimelist()
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
                    WTimes[t].TotalTime = float.Parse(reader.GetValue(4).ToString());
                    t++;
                }
            }
        }

        //Compares ListA with ListB and then adds items that are the same into ListB. 
        //And type is the object that is going to be added
        public void DownScaleList(List<string> ListA, List<string> ListB, string type)
        {

            for (int p = 0; p < ListA.Count; p++)
            {

                int k = 0;
                foreach (quetime Name in DataService.QTimes())
                {
                    if (type == "ID")
                    {
                        if (DataService.QTimes()[k].Name == ListA[p])
                        {
                            ListB.Add(DataService.QTimes()[k].Number);
                        }
                    }

                    if (type == "Name")
                    {
                        if (DataService.QTimes()[k].Number == ListA[p])
                        {
                            ListB.Add(DataService.QTimes()[k].Name);

                            //x,y coordinates of the selected attractions
                            Lijst.attLoc.Add(new attractionLoc());
                            Lijst.attLoc[p].Lat = DataService.QTimes()[k].Lat;
                            Lijst.attLoc[p].Lon = DataService.QTimes()[k].Lon;
                        }
                    }
                    k++;
                }
            }
        }

        //Creates the population for the current generation
        public void CreatePopulation(int PopulationSize, int selected, string CurrentPopulation, List<string> CurrentList)
        {
            for (int z = 0; z < PopulationSize;)
            {
                if (CurrentPopulation == "Initial")
                {
                    shuffler.Shuffle(CurrentList); //executes the shuffler
                }
                if (CurrentPopulation == "New")
                {
                    CreateChild(selected);
                    CurrentList.Clear();  //Clear the list, because of the loop 
                    CurrentList = child.ToList();
                }

                SelectItems(selected, CurrentList);
                FunctionSumTime();

                //Forces a re-shuffle if the conditions are not met
                if (duplicate(selected, CurrentPopulation) == false)
                {
                    if (sumTime < UpperBoundTime)
                    {
                        fitnesstime[z] = sumTime;
                        CreatePointArray(listForGenAl.Count);
                        z++;
                    }
                }

                //resets these parameters. So that the loop can be re-used
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
            //    Console.WriteLine("\n");
            //}
        }


        /// <summary>
        /// Converts the selected items (attraction names) into a list (attractionIDs)
        /// And adds the ports as starting point and ending of the route
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="CurrentList"></param>
        public void SelectItems(int selected, List<string> CurrentList)
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
                if (possible(WTimes[i].EndPoint.ToString()) && begincheck(WTimes[i].StartPoint.ToString(), previous) && CheckSelected(WTimes[i].EndPoint.ToString(), a, CurrentList))
                {
                    listForGenAl.Add(new genal());
                    listForGenAl[a].Endpoint = WTimes[i].EndPoint.ToString();
                    listForGenAl[a].TotalTime = routecheck(previous, WTimes[i].EndPoint.ToString());
                    previous = WTimes[i].EndPoint.ToString();
                    a++;
                    if (a == selected + 1)
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

        /// <summary>
        /// Sub-methods that are used for the method: SelectItems
        /// Method possible till routecheck
        /// </summary>
       
        //Checks if an attraction is not yet been added to the route
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

        //Checks if there are attractions yet in the route
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

        //checks what attractions are selected 
        public bool CheckSelected(string selected, int a, List<string> CurrentList)
        {
            if (selected == CurrentList[a - 1])
            {
                return true;
            }
            return false;
        }

        //Checks if the path between 2 attractions is possible
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


        //Calculates the total time of a route
        public void FunctionSumTime()
        {
            foreach (genal attraction in listForGenAl)
            {
                sumTime = sumTime + attraction.TotalTime;  
            }
        }

        //Method to check if there are duplicates in the population
        public bool duplicate(int selected, string CurrentPopulation)
        {
            if (selected == 5 || CurrentPopulation == "New") //reshuffling with 5 amount of selected attractions --> extreme amount of reshuffles.
            {
                return false;
            }
            for (int t = 0; t < fitnesstime.Length; t++)
            {
                if (sumTime == fitnesstime[t])
                {
                    return true;
                }
            }
            return false;
        }

        //Create a population
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

        //Calcualtes the fitnessscore for each chromosome (route) in the population
        public void FitnessFunction()
        {
            for (int t = 0; t < fitness.Length; t++)
            {
                float p = fitnesstime[t] / UpperBoundTime;
                fitness[t] = 100 - (p * 100); //The lower the time of a whole route ,the closer the fitness is to 100
            }


            higherbound = fitness.Max();

            //prints every fitnessScore
            //console.writeline(higherbound);
            //console.writeline("\n");

            ///<summary>
            ///Sets the best fitnessscore of the population and  to a list with attractionIDs 
            ///</summary>
            while (higherbound > bestFitness)
            {
                bestFitness = higherbound;
                CurrentBest = Array.IndexOf(fitness, bestFitness); //This is the index of the best chromosome
                betterChromo = true;
            }

            if (higherbound <= bestFitness)
            {
                GenerationCount++;
            }

            if (betterChromo == true)
            {
                CurrentChromosome = (string[])population.GetValue(CurrentBest); //array of population  
                BestChromosome = CurrentChromosome.ToList(); //Best chromosome as a list
                betterChromo = false;
            }

        }

        //Selects a dynamic top percentile of the population 
        public void Selection(int selected)
        {
            float lowerbound = higherbound - (higherbound / selected);  //dependds on how many parents is needed 
            fitness.OrderBy(x => x); //sort it from low to high
            fitnessParents = Array.FindAll(fitness, x =>
                                      x >= lowerbound && x <= higherbound);

        }

        //Parents are created so that childeren can be create (that prevents covergence of population)
        public void createParents()
        {
            indexPopulation = new int[fitnessParents.Length];
            parents = new string[indexPopulation.Length][];
            for (int t = 0; t < fitnessParents.Length; t++)
            {
                index = Array.IndexOf(fitness, fitnessParents[t]);  //Indexs of the population     
                indexPopulation[t] = index;
            }

            for (int t = 0; t < indexPopulation.Length; t++)
            {
                parents[t] = (string[])population.GetValue(indexPopulation[t]);
            }
        }

        /// <summary>
        /// Terminates the genetic algorithm after 30 generations are made
        /// </summary>
        public void Termination(int PopulationSize, int selected)
        {
            int j = 30;   //low processing time
            if (selected > 4)
            {
                while (GenerationCount < j) 
                {
                    s = 0;
                    createParents();
                    NextGeneration(PopulationSize, selected, "New"); //Multiple generations are created
                }
            }

            //Prints the attraction list (names) that is generated by the genetic algorithm
            DownScaleList(BestChromosome, FinalRoute, "Name");
            PrintLabel();

        }

        /// <summary>
        /// Method that creates a child that can be used to make a new population/generation
        /// </summary>
        public void CreateChild(int selected)
        {
            int r = rnd.Next(indexPopulation.Length);
            parent1 = parents[r];
            r = rnd.Next(indexPopulation.Length);
            parent2 = parents[r];

            //Sets the cross-over points
            int lowerbound = 1;
            int upperbound = parent1.Length - 1;
            child = new string[selected];


            int crossoverlength = rnd.Next(2, upperbound - 2);
            int crossoverpoint = rnd.Next(lowerbound, upperbound - crossoverlength);

            Array.Copy(parent1, crossoverpoint, child, 0, crossoverlength);

            //execution of the crossover   
            crossover(crossoverlength);

            //execution of the mutation
            int MutationChance = rnd.Next(1, 100);
            if (MutationChance <= selected * 4)
            {
                mutation(selected);
            }
        }

        //Davis’ Order Crossover
        //That makes it possible to have unique chromosomes (no duplciate attractions) in a route
        public void crossover(int crossoverlength)
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

                if (check)
                {
                    child[crossoverlength + p] = parent2[z];
                    p++;
                }

                check = true;
            }
        }

        //Swaps a gen (attraction) in a chromosome. So that there is always diversity in a population
        public void mutation(int selected)
        {
            int randomIndex1 = rnd.Next(0, selected - 1);

            int randomIndex2 = rnd.Next(0, selected - 1);
            if (randomIndex1 == randomIndex2)
            {
                if (randomIndex1 != 0)
                {
                    randomIndex1 = randomIndex1 - 1;
                }
                else
                {
                    randomIndex1 = randomIndex1 + 1;
                }
            }
            string Gene = child[randomIndex1];
            child[randomIndex1] = child[randomIndex2];
            child[randomIndex2] = Gene;
        }

        //Creation of a new generation
        public void NextGeneration(int k, int selected, string CurrentPopulation)
        {
            CreatePopulation(k, selected, CurrentPopulation, AttID); 
            FitnessFunction();
            Selection(selected);      
        }


        /// <summary>
        /// G-map package that makes it possible to show the route in a google maps display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void gmap_Load_1(object sender, EventArgs e)
        {
            
            markers.Markers.Clear();
            gmap.Overlays.Clear();
            
            gmap.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(48.872621961563205, 2.7761909189966993);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 15;
            gmap.ShowCenter = false;
            gmap.DragButton = MouseButtons.Left;
            
            
            
            
            
            for (int t = 0; t < Lijst.attLoc.Count; t++)
            {
                PointLatLng p = new PointLatLng(Lijst.attLoc[t].Lat, Lijst.attLoc[t].Lon);
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
                if (t == Lijst.attLoc.Count - 1)
                {
                    t++;
                    string endport = t.ToString();
                    marker.ToolTipText = ("1, " + endport);
                }
                else
                {
                    marker.ToolTipText = (t + 1).ToString();
                }

                marker.ToolTipMode = MarkerTooltipMode.Always;
                mark[t] = marker;

            }
        }

        //Prints out order of attraction names of the best route on the form.
        public void PrintLabel()
        {
            label2.Text=""; 
            for (int t = 0; t < FinalRoute.Count; t++)
            {
                int x = t + 1;
                string result = "";
                result = x.ToString() + ". " + result + FinalRoute[t] + " " + "\n";
                label2.Text = label2.Text + result;
            }
            RouteMapInputForm input = new RouteMapInputForm();
            input.Close();
        }
    }
}


        