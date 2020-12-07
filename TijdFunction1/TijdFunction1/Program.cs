using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;

namespace TimeFunction1
{

public class walktime 
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int Distance { get; set; }
        public float WalkTime { get; set; }
    }

    class TimeMethod : Form
    {
        //varabiales declarations//
        Button route;
        public int WaitTime { get; set; }
        int restTime = 500; //unit in minutes
        int walkdistance; // distance between 2 attractions
        int attractions = 10; //total number of attractions
        //public List<Elem> elements = new List<Elem> { };
            public TimeMethod()
        {  
            ////declarations of panel////

            //Route-button//
            route = new Button();
            route.Text = "route";
            route.Size = new Size(50, 20);
            route.Location = new Point(600, 120);
            this.Controls.Add(route);
            route.Click += new EventHandler(route1_Click);
        }

        ////void methods////
        public void route1_Click(object sender, EventArgs ea)
        {
            string connectionString;
            connectionString = @"Data Source=localhost; Initial Catalog = Tim123; Integrated Security=True;"; /* User ID = sam; Password = dat123;*/

            using (var connection = new SqlConnection(connectionString))
            {
                var results = connection.Query<walktime>(Select * from TheDataWalkTime).ToList(); //Package pakt hem niet?
                return results;
            }

        }

        public void Time(int waitTime, int walkdistance)
        {            
            double walkTime = walkdistance/1.4; //walkdistance also acquired from database
            double estimatedTime = waitTime + walkTime;
        }
 
        //draw event for time

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
