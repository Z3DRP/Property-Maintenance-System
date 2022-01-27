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
    public static class CoolingDB
    {
        public static string GetConString()
        {
            string conStr = null;
            conStr = Connector.GetConnection();

            return conStr;
        }
        public static List<Cooling> GetCoolingInfo()
        {
            List<Cooling> coolInfo = new List<Cooling>();
            var procedure = "[SpGetAllCooling]";
            string conStr = string.Empty;
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    coolInfo = db.Query<Cooling>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return coolInfo;
        }
        public static bool AddCooling(Cooling cType)
        {
            string conStr = null;
            var procedure = "[SpAddCooling]";
            var parms = new { id = cType.Id, type = cType.Cooling_Type };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, parms, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static bool UpdateCooling(Cooling cType)
        {
            string conStr = null;
            var procedure = "[SpUpdateCooling]";
            var parms = new { id = cType.Id, type = cType.Cooling_Type };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, parms, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static bool DeleteCooling(Cooling cType)
        {
            string conStr = null;
            var procedure = "[SpDeleteCooling]";
            var parms = new { id = cType.Id };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, parms, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
    }
}
