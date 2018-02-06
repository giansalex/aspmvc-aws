using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Npgsql;

namespace AwsWebApp.Models
{
    public class Helpers
    {
        public static string GetRdsConnectionString()
        {
#if !DEBUG
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["RDS_DB_NAME"];

            if (string.IsNullOrEmpty(dbname)) return null;

            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = appConfig["RDS_HOSTNAME"],
                Port = int.Parse(appConfig["RDS_PORT"]),
                Database = dbname,
                Username = appConfig["RDS_USERNAME"],
                Password = appConfig["RDS_PASSWORD"]
            };

            return builder.ToString();
#endif

            return "Data Source=localhost;Initial Catalog=awsTest;User ID=postgrres;Password=123456;";
        }
    }
}