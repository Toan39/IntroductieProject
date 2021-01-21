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
    public partial class RouteMapOutputForm
    {
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

        //Retrieves the needed SQL data from the sql-database for the Genetic Algorithm
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

        //Compares ListA with an sql list and then converts the items of  ListA to the needed type + adds to the empty list. 
        //The conversion is list selecteditems  --> list AttID and list BestChromosome --> list FinalRoute
        public void DownScaleList(List<string> ListA)
        {
            for (int p = 0; p < ListA.Count; p++)
            {
                int k = 0;
                foreach (quetime Name in DataService.QTimes())
                {
                        //this is the conversion of selected attraction names to attractionIDs
                        if (DataService.QTimes()[k].Name == ListA[p])
                        {
                        AttID.Add(DataService.QTimes()[k].Number);
                        }

                    //this is  the conversion of  attractionIDs of the  "perfect" route to attraction names
                    if (DataService.QTimes()[k].Number == ListA[p])
                        {
                            FinalRoute.Add(DataService.QTimes()[k].Name);

                            //x,y coordinates of the selected attractions
                            list.attLoc.Add(new attractionLoc());
                            list.attLoc[p].Lat = DataService.QTimes()[k].Lat;
                            list.attLoc[p].Lon = DataService.QTimes()[k].Lon;
                        }
                    k++;
                }
            }
        }

        //Creates the population for the current generation
        public void CreatePopulation(int PopulationSize, int selected)
        {
            for (int z = 0; z < PopulationSize;)
            {
                if (GenerationCount == 0)
                {
                    shuffler.Shuffle(AttID); //executes the shuffler
                }
                else
                {
                    CreateChild(selected);
                    AttID.Clear();  //Clear the list, because of the loop 
                    AttID = child.ToList();
                }

                SelectItems(selected);
                FunctionSumTime();

                //Forces a re-shuffle if the conditions are not met
                if (duplicate(selected) == false)
                {
                    if (sumTime < UpperBoundTime)
                    {
                        fitnesstime[z] = sumTime;
                        CreateChromosome(cache.Count); 
                        z++;
                    }
                }

                //resets these parameters. So that the loop can be re-used
                sumTime = 0;
                cache.Clear();
            }
        }


        /// <summary>
        /// Converts the selected items (attraction names) into a list (attractionIDs)
        /// And adds the ports as starting point and ending of the route
        /// </summary>
        /// <param name="selected"></param>
        public void SelectItems(int selected)
        {
            string p = "P1RA11"; //attractionID of the port
            string previous = p; //previous is the previous item (attraction)  of the cache list 
            int a = 1; //since the port is on index 0 of the cache list
            int i = 0; 

            bool done = true;
            cache.Add(new sqldata());
            cache[0].Endpoint = p;
            cache[0].TotalTime = 0;
            while (i < WTimes.Count && done == true)
            {
                if (possible(WTimes[i].EndPoint.ToString()) && begincheck(WTimes[i].StartPoint.ToString(), previous) && CheckSelected(WTimes[i].EndPoint.ToString(), a))
                {
                    cache.Add(new sqldata());
                    cache[a].Endpoint = WTimes[i].EndPoint.ToString();
                    cache[a].TotalTime = routecheck(previous, WTimes[i].EndPoint.ToString());
                    previous = WTimes[i].EndPoint.ToString();
                    a++;
                    if (a == selected + 1)
                    {
                        done = false;
                        cache.Add(new sqldata());
                        cache[a].Endpoint = p;
                        cache[a].TotalTime = routecheck(previous, p);
                    }
                    i = -1; //to also let the loop work for the first item in WTimes list
                }
                i++;
            }
        }

        /// <summary>
        /// Sub-methods that are used for the method: SelectItems
        /// This summary is apliable to method "possible" till "routecheck"
        /// </summary>

        //Checks if an attraction is not yet been added to the route
        public bool possible(string x)
        {
            foreach (sqldata sqldata in cache)
            {
                if (x == sqldata.Endpoint)
                {
                    return false;
                }
            }
            return true;
        }

        //Checks if there are attractions yet in the route
        public bool begincheck(string y, string z)
        {
            if (y == z)
            {
                return true;
            }
            return false;
        }

        //checks what attractions are selected 
        public bool CheckSelected(string selected, int a)
        {
            if (selected == AttID[a - 1])
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
            foreach (sqldata attraction in cache)
            {
                sumTime = sumTime + attraction.TotalTime;
            }
        }

        //Method to check if there are duplicates in the population
        public bool duplicate(int selected)
        {
            if (selected == 5 || GenerationCount>0) //reshuffling with 5 amount of selected attractions --> extreme amount of reshuffles.
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

        //Creates a chromosome (attractionroute) and add it to the population
        public void CreateChromosome(int z)
        {
            string[] chromosome = new string[z];
            for (int t = 0; t < z; t++)
            {
                chromosome[t] = cache[t].Endpoint;
            }
            population[s] = chromosome; //adding chromosomes to the population
            s++;
        }

        //Calculates the fitnessscore for each chromosome (route) in the population
        public void FitnessFunction(int selected)
        {
            for (int t = 0; t < fitness.Length; t++)
            {
                float p = fitnesstime[t] / UpperBoundTime;
                fitness[t] = 100 - (p * 100); //The lower the time of a whole route ,the closer the fitness is to 100
            }


            HighestFitness = fitness.Max(); //the highestFitness of the current generation

            //prints every fitnessScore
            Console.WriteLine(HighestFitness);
            Console.WriteLine("\n");

            ///<summary>
            ///Sets the best fitnessscore and convert it to a list with attractionIDs 
            ///</summary>
            while (HighestFitness > bestFitness)
            {
                bestFitness = HighestFitness;
                CurrentBest = Array.IndexOf(fitness, bestFitness); //This is the index of the best chromosome
                betterChromo = true;
            }   

            if (betterChromo == true) 
            {
                CurrentChromosome = population[CurrentBest]; //array of population  
                BestChromosome = CurrentChromosome.ToList(); //Best chromosome as a list         
            }

            GenerationCount++; 
        }

        //Selects a dynamic top percentile of the population 
        public void Selection(int selected)
        {
            float higherbound = HighestFitness;
            float lowerbound = higherbound - (higherbound / selected);  //dependds on how many parents is needed 
            fitness.OrderBy(x => x); //sort it from low to high

            //Selection of the fitnessscores of the parents between the upperbound and lowerbound
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
                parents[t] = population[indexPopulation[t]];
            }
        }

        /// <summary>
        /// Terminates the genetic algorithm after 30 generations are made
        /// </summary>
        public void Termination(int PopulationSize, int selected)
        {
            int j = 30;   // for low processing time, 30 generations are produced

            if (selected > 4) //lesser than 4 attractions no new generations are needed, since best route can be directly determined
            {
                while (GenerationCount < j)
                {
                    s = 0;
                    createParents();
                    NextGeneration(PopulationSize, selected); //Multiple generations are created
                }
            }

            //Prints the attraction list (names) that is generated by the genetic algorithm
            DownScaleList(BestChromosome);
            PrintLabel();

        }

        /// <summary>
        /// Method that creates a child that can be used to make a new population/generation
        /// </summary>
        public void CreateChild(int selected)
        {
            //get 2 random parents of the population
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
        public void NextGeneration(int PopulationSize, int selected)
        {
            CreatePopulation(PopulationSize, selected);
            FitnessFunction(selected);
            Selection(selected);
        }

    }
}
