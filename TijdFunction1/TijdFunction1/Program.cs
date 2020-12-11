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


namespace TimeFunction1
{
    public partial class TimeMethod : Form
    {
        //varabiales declarations//
        Button route;
        DataGridView dat_1;
        DataGridView dat_2;
        List<Rij> datalist = new List<Rij>();
        List<attraction> att = new List<attraction>();
        List<string> usedpoints = new List<string>();
        //List<Rij> naamlist = new List<Rij>(); 
        int InsertedTime = 540;
        public TimeMethod()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            ////declarations of panel////

            //Route-button//
            route = new Button();
            route.Text = "route";
            route.Size = new Size(50, 20);
            route.Location = new Point(600, 100);
            this.Controls.Add(route);
            route.Click += new EventHandler(Button1);
            
            // Viewer 1//
            dat_1 = new DataGridView();
            dat_1.Size = new Size(500, 500);
            dat_1.Location = new Point(200, 120);
            this.Controls.Add(dat_1);

            // Viewer 2//
            dat_2 = new DataGridView();
            dat_2.Size = new Size(500, 500);
            dat_2.Location = new Point(800, 120);
            this.Controls.Add(dat_2);

        }

        ////void methods////
        private void Button1(object o, EventArgs ea)
        {
            
            dat_1.DataSource = DataService.QTimes();
            dat_2.DataSource = DataService.WTimes(); //grid

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
            Console.WriteLine(returnlowest(InsertedTime));
            makelist();
        }

        void sorteer()
        {
            datalist = datalist.OrderBy(x => x.TotalTime).ToList();
        }

        void verwijderdupes()
        {
            for (int i = datalist.Count - 1; i >= 0; i--)
            {
                if (datalist[i].EndPoint == datalist[0].EndPoint)
                {
                    datalist.RemoveAt(i);
                }
            }
            //datalist.RemoveAt(0);
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
                        Console.WriteLine(verbruiktetijd);
                        i = 0;
                        //verwijderdupes();
                    }
            }
            return (lowest);
        }

        public void makelist()
        {

            for (int p = 0; p<(usedpoints.Count); p++)
            {
                int k = 0;
                foreach (quetime Name in DataService.QTimes())
                {
                    if (DataService.QTimes()[k].Number == usedpoints[p])
                    {

                        att.Add(new attraction());
                        att[p].Name = DataService.QTimes()[k].Name;
                        att[p].Lat = DataService.QTimes()[k].Lat;
                        att[p].Lon = DataService.QTimes()[k].Lon;
                    }
                    k++;
                }
                Console.WriteLine(att[p].Name);
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
            if(z != "")
            {
                if(y == z)
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


    }

    public class attraction
    {
        public string Name;
        public double Lat;
        public double Lon;
    }

    internal class Rij
    {
        public string StartPoint;
        public string EndPoint;
        public float Distance;
        public float WalkTime;
        public float TotalTime;
        //public string Name;
    }

    class Timefunction1
    {
        static void Main()
        {
            TimeMethod screen;
            screen = new TimeMethod();
            Application.Run(screen);
        }
    }
}

