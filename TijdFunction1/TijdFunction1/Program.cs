using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;
using Dapper;
using System.Collections;


namespace TimeFunction1
{
    public partial class TimeMethod : Form
    {
        //varabiales declarations//
        Button route;
        DataGridView dat_1;
        DataGridView dat_2;

        public TimeMethod()
        {  
            ////declarations of panel////

            //Route-button//
            route = new Button();
            route.Text = "route";
            route.Size = new Size(50, 20);
            route.Location = new Point(600, 120);
            this.Controls.Add(route);
            route.Click += new EventHandler(Button1);
      
            // Viewer 1//
            dat_1= new DataGridView();
            dat_1.Size = new Size(500, 500);
            dat_1.Location = new Point(1300, 120);
            this.Controls.Add(dat_1);

            // Viewer 2//
            dat_2 = new DataGridView();
            dat_2.Size = new Size(500, 500);
            dat_2.Location = new Point(500, 520);
            this.Controls.Add(dat_2);

        }

        ////void methods////
        private void Button1(object o, EventArgs ea)
        {
            dat_1.DataSource = DataService.QTimes();
            dat_2.DataSource = DataService.WTimes();

        }

        public void Time(int waitTime, int walkdistance)
        {            
            //double walkTime;
            //double estimatedTime = queTime + ridetime+ walkTime;
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
