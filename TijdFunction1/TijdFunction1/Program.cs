﻿using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;
using Dapper;

namespace TimeFunction1
{
    public class quetime
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string AverageQueTime { get; set; }
        public string RideTime { get; set; }
    }

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
        
        public List<quetime> ReadAll()
            {
                string connectionString;
                string sql;

                connectionString = @"Data Source=localhost; Initial Catalog=Tim123; Integrated Security=True;";
                sql = "SELECT * FROM TheDataQueTime";

                using (var connect = new SqlConnection(connectionString))
                {
                    //DataTable dataquetime = connectionString.GetSchema("TheDataQueTime"); 
                    var result = connect.Query<quetime>(sql).ToList();
                    return result;
                }
            }
        public void route1_Click(object sender, EventArgs ea)
        {
            // button that prints the result
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
