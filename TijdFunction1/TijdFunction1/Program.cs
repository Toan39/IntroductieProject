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
        List<float> totaltime = new List<float>();
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
                    totaltime.Add(new float());
                    totaltime[i] = DataService.QTimes()[i].AverageQueTime + DataService.QTimes()[i].RideTime;
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
                        totaltime.Add(new float());
                        finaltime[j] = totaltime[k] + DataService.WTimes()[p].WalkTime;
                        //Console.WriteLine(finaltime[j]);
                    }
                }

            if( sumfinaltimes<InsertedTime)
                {

                }
            }


        }


        public static List<float> Function(List<float> finaltime, int max)
        {
            var inputfloats = finaltime;

            var maxAuthorizedValue = inputfloats
                .OrderBy(z => z)
                .Take(max)
                .Last();

            return inputfloats
                .Select(z => z <= maxAuthorizedValue ? z.Tostring() : "n")
                .ToList();
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

