using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disneyland
{
    /// <summary>
    ///  All these classes represent the elements of their corresponding lists that are used for the Routemap-function
    /// </summary>
    public static class list
    {
        public static List<attractionLoc> attLoc = new List<attractionLoc>();
    }

    public class GenAl
    {
        public string Endpoint;
        public float TotalTime;
    }
    public class quetime
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public float AverageQueTime { get; set; }
        public float RideTime { get; set; }

        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public class walktime
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public float TotalTime { get; set; }
    }

    public class attractionLoc
    {
        public double Lat;
        public double Lon;
    }
}
