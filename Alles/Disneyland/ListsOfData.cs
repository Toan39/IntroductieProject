﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disneyland
{
    public static class Lijst
    {
        public static List<attractionLoc> attLoc = new List<attractionLoc>();
    }

    public class genal
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
