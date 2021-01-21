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
    
    // list of the attractionlocations of the near-perfect route 
    public static class list
    {
        public static List<attractionLoc> attLoc = new List<attractionLoc>();
    }

    // x,y coordinates that are needed for the attractionlocations 
    public class attractionLoc
    {
        public double Lat;
        public double Lon;
    }

    //Endpoints and total time data of an attraction from the selected attractions
    public class sqldata
    {
        public string Endpoint;
        public float TotalTime;
    }

    //SQL-data from "TheDataQueTime" table of the database
    public class quetime
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    //SQL-data from "TheDataWalkTime" table of the database
    public class walktime
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public float TotalTime { get; set; }
    }

}
