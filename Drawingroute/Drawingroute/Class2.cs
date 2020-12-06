using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawingroute
{
    public class path
    {

        public int Walktime;
        public attraction Destination;
        public Point Location1, Location2;

        public path(attraction destination, int walktime, int x1, int y1, int x2, int y2)
        {
            this.Destination = destination;
            this.Walktime = walktime;
            if(x1 != 0)
            {
                this.Location1 = new Point(x1, y1);
                if(x2 != 0)
                {
                    this.Location2 = new Point(x2, y2);
                }
            }
            //creates a path.
        }


    }
}

