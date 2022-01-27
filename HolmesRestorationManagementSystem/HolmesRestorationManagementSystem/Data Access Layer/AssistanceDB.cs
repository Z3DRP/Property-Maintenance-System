using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Data;
using HolmesRestorationManagementSystem.Data_Access_Layer;
using HolmesRestorationManagementSystem.Business_Objects;

namespace HolmesRestorationManagementSystem.Data_Access_Layer
{
    public static class AssistanceDB
    {
        public static string GetConString()
        {
            string conStr = null;
            conStr = Connector.GetConnection();

            return conStr;
        }
        public static List<Assistance> GetAssistanceInfo()
        {
            List<Assistance> assitanceInfo = new List<Assistance>();
            var procedure = "[SpGetAssistances]";
            string conStr = string.Empty;
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    assitanceInfo = db.Query<Assistance>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }

            return assitanceInfo;
        }
    }
}
