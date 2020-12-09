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
    public static class DataService
    {
        public static List<quetime> QTimes()
        {
            string connectionString;
            string sql;

            connectionString = @"Data Source=LAPTOP-40E47QF1\GABRIEL;Initial Catalog=Quetime;Integrated Security=True";
            sql = "select * from TheDataQueTime";

            using (var connect = new SqlConnection(connectionString))
            {
                var result = connect.Query<quetime>(sql).ToList();
                return result;
            }
        }

        public static List<walktime> WTimes()
        {
            string connectionString;
            string sql;

            connectionString = @"Data Source=LAPTOP-40E47QF1\GABRIEL;Initial Catalog=DataWalkTime;Integrated Security=True";
            sql = "select * from TheDataWalkTime";

            using (var connect = new SqlConnection(connectionString))
            {
                var result = connect.Query<walktime>(sql).ToList();
                return result;
            }
        }
    }
}
