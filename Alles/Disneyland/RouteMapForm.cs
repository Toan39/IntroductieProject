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
    public partial class RouteMapForm : Form
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

        public RouteMapForm(List<string> selecteditems, bool checktime)
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
            ///Genetic Algorithm (finds a approximately best route) (the code is in GeneticAlgorithm.cs)
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
                Console.WriteLine("\n");
            }
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


        