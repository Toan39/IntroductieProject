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
    public class quetime
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public float AverageQueTime { get; set; }
        public float RideTime { get; set; }
    }

    class TimeMethod : Form
    {
        //varabiales declarations//
        Button route;
        ComboBox combo;
        DataGridView dat;

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
      

            //Combo-box//
            combo = new ComboBox();
            combo.Text = "combo";
            combo.Size = new Size(50, 20);
            combo.Location = new Point(900, 120);
            this.Controls.Add(combo);

            // Viewer//
            dat= new DataGridView();
            dat.Size = new Size(500, 500);
            dat.Location = new Point(1300, 120);
            this.Controls.Add(dat);

            //Draw-eventHandler//
            //this.Paint += this.Draw;

        }

        ////void methods////
        public class DataService
        {
            public static List<quetime> Times()
            {
                string connectionString;
                string sql;

                connectionString = @"Data Source=localhost; Initial Catalog=Tim123; Integrated Security=True ";   //ID=sam; Password=dat123
                sql = "select * from TheDataQueTime";

                using (var connect = new SqlConnection(connectionString))
                {
                    //DataTable dataquetime = connectionString.GetSchema("TheDataQueTime"); 
                    var result = connect.Query<quetime>(sql).ToList();
                    return result;
                }
            }
        }

        public void Button1(object o, EventArgs ea)
        {
            //combo.DataSource = DataService.Times();
            //combo.ValueMember= "AverageQueTime";

            dat.DataSource = DataService.Times();
        }

        //public void WriteToConsole(IEnumerable Times)
        //{
        //    foreach (var result in Times)
        //    {
        //        Console.WriteLine(result);
        //    }
        //}

        //public void Button1(object o, EventArgs ea)
        //{
        //    Invalidate();
        //}

        //public void Draw(object sender, PaintEventArgs pea)
        //{
        //    foreach (var result in Times)
        //            {
        //                DrawString(result, "Arial", Brushes.Black, 200, 200);
        //            }
        //}

        //public void Print1(List<quetime> ReadAll)
        //{
        //    ReadAll.ForEach(Console.WriteLine);
        //}



        public void Time(int waitTime, int walkdistance)
        {            
            //double walkTime;
            //double estimatedTime = queTime + ridetime+ walkTime;
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
