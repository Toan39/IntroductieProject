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
            
            public double Lat { get; set; }
            public double Lon { get; set; }
    }
}
