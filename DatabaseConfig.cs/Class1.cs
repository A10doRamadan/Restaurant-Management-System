using System;
using System.Data.SqlClient;

namespace Restaurant_project
{
    public static class DatabaseConfig
    {
        private static string connectionString = @"Data Source=.;Initial Catalog=project;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}