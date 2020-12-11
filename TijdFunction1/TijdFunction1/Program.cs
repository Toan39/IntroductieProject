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
        //List<string> usedpoints = new List<string>();
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
            dat_2.DataSource = DataService.WTimes();

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
        }

        void sorteer()
        {
            datalist = datalist.OrderBy(x => x.TotalTime).ToList();
        }

        //void verwijderdupes()
        //{
        //    int j = 0;
        //    foreach (Rij Startpoint in datalist)
        //    {
        //        if (datalist[j].EndPoint == datalist[0].EndPoint)
        //        {
        //            datalist.RemoveAt(j);
        //        }
        //        j++;
        //    }
        //}

        public string returnlowest(int Inserted)
        {
            string lowest = "";
            float verbruiktetijd = 0;
            for (int i = 0; verbruiktetijd < Inserted; i++)
            {
                if (datalist[0].EndPoint == datalist[i].StartPoint)
                {
                    lowest = lowest + datalist[i].EndPoint.ToString() + "\n";
                    verbruiktetijd = verbruiktetijd + datalist[i].TotalTime;
                    Console.WriteLine(verbruiktetijd);

                }

            }
            return (lowest);
        }

        /*public bool possible(string x)
        {
            foreach (string endpoint in usedpoints)
            {
                if (x == endpoint)
                {
                    return false;
                }
            }
            return true;
        }*/
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

