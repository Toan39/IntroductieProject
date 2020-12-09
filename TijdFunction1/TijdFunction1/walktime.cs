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
    public class walktime
    {
        public string StartPoint { get; set; }
        public string Endpoint { get; set; }
        public float Distance { get; set; }
        public float RideTime { get; set; }
    }
}
