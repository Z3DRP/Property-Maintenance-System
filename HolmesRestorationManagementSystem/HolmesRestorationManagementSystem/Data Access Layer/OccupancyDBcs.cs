using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using HolmesRestorationManagementSystem.Data_Access_Layer;
using HolmesRestorationManagementSystem.Business_Objects;

namespace HolmesRestorationManagementSystem.Data_Access_Layer
{
    public static class OccupancyDBcs
    {
        public static string GetConString()
        {
            string conStr = null;
            conStr = Connector.GetConnection();

            return conStr;
        }

        public static List<Occupancy> GetOccupancies()
        {
            string conStr = null;
            List<Occupancy> occupancies = new List<Occupancy>();
            var procedure = "[SpGetAllOccupancies]";
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    occupancies = db.Query<Occupancy>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return occupancies;
        }
        public static bool AddOccupancy(Occupancy occupant)
        {
            string conStr = null;
            var procedure = "[SpAddOccupant]";
            var parms = new { pId= occupant.Property_Id, tId= occupant.Tenant_Id, moveIn= occupant.Move_In_Date };
            int rowsAffected;
            bool returnStatus;

            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, parms, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static bool UpdateOccupancy(Occupancy occupant)
        {
            string conStr = null;
            var procedure = "[SpUpdateOccupancy]";
            var parms = new { propId = occupant.Property_Id, tenantId = occupant.Tenant_Id, movieIn = occupant.Move_In_Date };
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
            catch(Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static bool DeleteOccupancy(Occupancy occupant)
        {
            string conStr = null;
            var procedure = "[SpDeleteOccupant]";
            var parms = new { pId = occupant.Property_Id, tId = occupant.Tenant_Id };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, parms, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static List<Occupancy> FindOccupancy(int propertyID)
        {
            string conStr = null;
            var procedure = "[SpFindOccupancy]";
            var parm = new { pId = propertyID };
            List<Occupancy> occupants = new List<Occupancy>();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    occupants = db.Query<Occupancy>(procedure, parm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return occupants;
        }
        public static Occupancy GetTenantAddressId(int tenantID)
        {
            string conStr = null;
            var procedure = "[SpGetTenantAddressId]";
            var parm = new { tId = tenantID };
            Occupancy occupancy = new Occupancy();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    occupancy = db.QuerySingle(procedure, parm, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            { throw ex; }

            return occupancy;
        }
    }
}
