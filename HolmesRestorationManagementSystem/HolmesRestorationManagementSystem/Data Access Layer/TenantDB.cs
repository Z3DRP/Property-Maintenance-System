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
    public static class TenantDB
    {
        public static string GetConString()
        {
            string conStr = null;
            conStr = Connector.GetConnection();

            return conStr;
        }
        public static List<Tenant> GetTenants()
        {
            string conStr = null;
            var procedure = "[GetAllTenants]";
            List<Tenant> tenants = new List<Tenant>();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    tenants = db.Query<Tenant>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return tenants;
        }
        public static Tenant GetTenant(int tid)
        {
            string conStr = null;
            var procedure = "[SpGetTenant]";
            var parm = new { tId = tid };
            Tenant tenant = new Tenant();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    tenant = db.QuerySingle<Tenant>(procedure, parm, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            { throw ex; }

            return tenant;
        }
        public static bool AddTenant(Tenant person)
        {
            string conStr = null;
            var procedure = "[SpAddTenant]";
            var parms = new
            {
                tId = person.Tenant_Id,
                fname = person.First_Name,
                lname = person.Last_Name,
                number = person.Phone_Number,
                address = person.Address,
                job = person.Occupation,
                emp_length = person.Employment_Length,
                disabled = person.Disabled,
                assistance = person.Government_Assistance
            };
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
        public static bool DeleteTenant(Tenant tid)
        {
            string conStr = null;
            var procedure = "[SpDeleteTenant]";
            var parm = new { tId = tid };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, parm);
                }
            }
            catch(Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static bool UpdateTenant(Tenant person)
        {
            string conStr = null;
            var procedure = "[SpUpdateTenant]";
            var parms = new
            {
                tId = person.Tenant_Id,
                Fname = person.First_Name,
                Lname = person.Last_Name,
                Number = person.Phone_Number,
                Address = person.Address,
                Job = person.Occupation,
                emp_length = person.Employment_Length,
                Disable = person.Disabled,
                Assistance = person.Government_Assistance
            };
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
        public static Tenant GetTenantId(string firstname, string lastname)
        {
            string conStr = null;
            var procedure = "[SpGetTenantId]";
            var parms = new { fname = firstname, lname = lastname };
            Tenant tenant = new Tenant();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    tenant = db.QuerySingle(procedure, parms, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            { throw ex; }

            return tenant;
        }
        public static List<Tenant> SearchTenant(string firstname, string lastname)
        {
            string conStr = null;
            var procedure = "[SpSearchTenantName]";
            string fnameWC = firstname + "%", lnameWC = lastname + "%";
            var parms = new { fname = fnameWC, lname = lnameWC };
            List<Tenant> tenants = new List<Tenant>();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    tenants = db.Query<Tenant>(procedure, parms, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return tenants;
        }
        public static List<Tenant> SearchTenant(Tenant tenant)
        {
            string conStr = null;
            var procedure = "[SpSearchTenantName]";
            string fnameWC = tenant.First_Name + "%", lnameWC = tenant.Last_Name + "%";
            var parms = new { fname = fnameWC, lname = lnameWC };
            List<Tenant> tenants = new List<Tenant>();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    tenants = db.Query<Tenant>(procedure, parms, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }

            return tenants;
        }
        public static int GetNextTenantId()
        {
            string conStr = null;
            string procedure = "[SpGetNextTenantId]";
            Tenant tenant = new Tenant();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    tenant = db.QuerySingle<Tenant>(procedure, commandType: CommandType.StoredProcedure);
                    tenant.Tenant_Id += 1;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return tenant.Tenant_Id;
        }
    }
}
