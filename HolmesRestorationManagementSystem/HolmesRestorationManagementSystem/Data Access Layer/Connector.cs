using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace HolmesRestorationManagementSystem.Data_Access_Layer
{
    public static class Connector
    {
        // connects to app.config to get the connection string for database
        public static string GetConnection()
        {
            string conString = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["HolmesConnectString"].ConnectionString;
                //conString = ConfigurationManager.ConnectionStrings["HolmesRestorationManagementSystem.Properties.Settings.HolmesRestorationConnectionString"].ConnectionString;
            }
            catch(Exception ex)
            { throw ex; }

            if (conString != null)
                return conString;
            else
                return string.Empty;
        }
    }
}
