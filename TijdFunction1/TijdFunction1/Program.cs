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
        Button test;
        DataGridView dat_1;
        DataGridView dat_2;
        List<float> attractiontime = new List<float>();
        List<float> finaltime = new List<float>();
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

            foreach (quetime Number in DataService.QTimes())
            {
                if (DataService.QTimes().Count < 45)     //if statement onnodig
                {
                    attractiontime.Add(new float());
                    attractiontime[i] = DataService.QTimes()[i].AverageQueTime + DataService.QTimes()[i].RideTime;
                    //Console.WriteLine(totaltime[i]);
                    i++;

                }
            }

            for (int p = 0; p < 1893; p++)
            {
                for (int j = 0; j < 44; j++)
                {
                    for (int k = 0; k < 45; k++)
                    {
                        finaltime.Add(new float());
                        attractiontime.Add(new float());
                        finaltime[j] = attractiontime[k] + DataService.WTimes()[p].WalkTime;
                        //Console.WriteLine(finaltime[j]);
                    }
                }

                //if( sumfinaltimes<InsertedTime)
                //    {

                //    }
            }

            Console.WriteLine(returnlowest());
        }

        //
        //public static List<float> Function(List<float> inputList, int max)
        //{
        //    var inputfloats = inputList;

        //    var maxAuthorizedValue = inputfloats
        //        .OrderBy(z => z)
        //        .Take(max)
        //        .Last();

        //    return inputfloats
        //        .Select(z => z <= maxAuthorizedValue ? z : 0)
        //        .ToList();
        //}

        //public void testtest(object sender, EventArgs ea)
        //{
        //    var LowestValues = Function(finaltime, 3);
        //    Console.WriteLine(LowestValues);
        //}


        void sorteer()
        {
            finaltime = finaltime.OrderBy(x => x).ToList();
        }

        public float returnlowest()
        {
            sorteer();
            finaltime.Add(new float());
            return (finaltime[0]);
        }
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

