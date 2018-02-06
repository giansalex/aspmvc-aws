using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Web;
using Npgsql;

namespace AwsWebApp.Models
{
    public class Helpers
    {
        public static DbConnection CreateConnection()
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

            var cstr = builder.ToString();
#else
            var cstr = "Host=localhost;DataBase=awsTest;User ID=postgres;Password=123456;";
#endif

            return new NpgsqlConnection(cstr);
        }
    }
}