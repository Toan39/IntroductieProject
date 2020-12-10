using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;
using Dapper;
using System.Collections;

namespace WindowsFormsApp5
{
    public static class DataService
    {
        public static List<attraction> attraction()
        {
            string connectionString;
            string sql;

            connectionString = @"Data Source=localhost;Initial Catalog=Tim123;Integrated Security=True";
            sql = "select * from kees";

            using (var connect = new SqlConnection(connectionString))
            {
                var result = connect.Query<attraction>(sql).ToList();
                return result;
            }
        }
    }
}
