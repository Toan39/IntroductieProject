using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductieproject
{
    class user
    {
        public Point Locationuser;
        user()
        {


        }

        public void Draw(Graphics gr)
        {
            gr.DrawImage(Bitmap.FromFile("plaatje.png"), new Point(100, 100));
        }

    }
    class path
    {
        public int Walktime;
        public attraction Destination;
        public path(attraction destination, int walktime)
        {
            this.Destination = destination;
            this.Walktime = walktime;
            //creates a path
        }

        public void Draw(Graphics gr, Pen pen, attraction attraction)
        {
            gr.DrawLine(pen, attraction.Locationattraction, this.Destination.Locationattraction);
            //draws the path
        }

    }

    class attraction
    {
        public Point Locationattraction;
        public string Name;
        public int Queuetime;
        public int Ridetime;
        public bool Allowed; //true means the attraction will be taken into account when calculating the route, false is the opposite.
        List<path> Paths;

        public attraction(Point location, string name, int queuetime, int ridetime)
        {
            this.Locationattraction = location;
            this.Name = name;
            this.Queuetime = queuetime;
            this.Ridetime = ridetime;
            this.Paths = new List<path>();
        }
        public void Draw(Graphics gr, Brush br)
        {

            /*
            gr.FillRectangle(br, this.Location.X - 12, this.Location.Y - 4, 24, 8);
            gr.FillEllipse(br, this.Location.X + 6, this.Location.Y + 14, 8, 8);
            gr.FillEllipse(br, this.Location.X - 12, this.Location.Y + 4, 6, 6);
            gr.FillEllipse(br, this.Location.X + 6, this.Location.Y + 4, 6, 6);
            draws a small cart, as icon for an attraction.*/
        }

    }



    class locatornavigator
    {



        locatornavigator()
        {



        }
    }
}
