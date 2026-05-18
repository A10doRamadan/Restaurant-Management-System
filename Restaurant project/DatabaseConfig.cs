using System;
using System.Data.SqlClient;

namespace Restaurant_project
{
    // كلمة public و static هنا هما اللي بيخلوه يتشاف في المشروع كله
    public static class DatabaseConfig
    {
        private static string connectionString = @"Data Source=.;Initial Catalog=project;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}