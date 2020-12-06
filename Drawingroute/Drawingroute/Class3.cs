using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawingroute
{
    public class attraction
    {
        public Point Locationattraction;
        public string Name;
        public int Queuetime;
        public int Ridetime;
        public List<path> Paths; //each attraction will hold the paths that are directly connected to them.

        public attraction(Point location, string name, int queuetime, int ridetime)
        {
            this.Locationattraction = location;
            this.Name = name;
            this.Queuetime = queuetime;
            this.Ridetime = ridetime;
            this.Paths = new List<path>();
            //creates an attraction.
        }
    }
}
