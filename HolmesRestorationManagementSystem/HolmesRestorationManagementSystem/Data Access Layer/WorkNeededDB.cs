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
    public static class WorkNeededDB
    {
        public static string GetConString()
        {
            string conStr = null;
            conStr = Connector.GetConnection();

            return conStr;
        }
        public static List<WorkNeeded> GetWork()
        {
            string conStr = null;
            string procedure = "[SpGetAllWork]";
            List<WorkNeeded> work = new List<WorkNeeded>();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    work = db.Query<WorkNeeded>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return work;
        }
        public static int GetPropertyId(int workId)
        {
            string conStr = null;
            string procedure = "[SpGetPropertyIdByWorkId]";
            var parm = new { wId = workId };
            WorkNeeded work = new WorkNeeded();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    work = db.QuerySingle<WorkNeeded>(procedure, parm, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return work.Property_Id;
        }
        public static int GetWorkProperty(int workId)
        {
            string conStr = null;
            string procedure = "[SpGetWorkProperty]";
            var parm = new { wId = workId };
            WorkNeeded work = new WorkNeeded();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    work = db.QuerySingle<WorkNeeded>(procedure, parm, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return work.Property_Id;
        }
        public static bool AddWork(WorkNeeded job)
        {
            string conStr = null;
            string procedure = "[SpAddWork]";
            var parms = new
            {
                wId = job.Work_Id,
                pId = job.Property_Id,
                work = job.Work_Needed,
                DesCompletion = job.Desired_Completion_Date,
                priority = job.Priority_Level
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
        public static bool UpdateWork(WorkNeeded job)
        {
            string conStr = null;
            string procedure = "[SpUpdateWork]";
            var parms = new
            {
                wId = job.Work_Id,
                pId = job.Property_Id,
                Work = job.Work_Needed,
                DCompletionDate = job.Desired_Completion_Date,
                Priority = job.Priority_Level
            };
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
        public static bool DeleteWork(WorkNeeded job)
        {
            string conStr = null;
            string procedure = "[SpDeleteWork]";
            var parms = new { wId = job.Work_Id };
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

        public static List<WorkNeeded> GetPropertyWork(int propId)
        {
            string conStr = null;
            string procedure = "[SpGetPropertyWork]";
            var parm = new { propertyId = propId };
            List<WorkNeeded> work = new List<WorkNeeded>();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    work = db.Query<WorkNeeded>(procedure, parm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return work;
        }
        public static WorkNeeded GetWork(int jID)
        {
            string conStr = null;
            string procedure = "[SpGetWork]";
            var parm = new { jobId = jID };
            WorkNeeded work = new WorkNeeded();

            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    work = db.QuerySingle(procedure, parm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }

            return work;
        }
        public static List<WorkNeeded> GetAllWork()
        {
            string conStr = null;
            string procedure = "[SpGetAllWork]";
            List<WorkNeeded> AllWork = new List<WorkNeeded>();

            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    AllWork = db.QuerySingle(procedure,commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }

            return AllWork;
        }
        public static List<WorkNeeded> SearchWork(string job)
        {
            string conStr = null;
            string procedure = "[SpSearchWork]";
            string jobWC = job + "%";
            var parm = new { work = jobWC };
            List<WorkNeeded> work = new List<WorkNeeded>();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    work = db.Query<WorkNeeded>(procedure, parm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return work;
        }
        public static int GetNextWorkId()
        {
            string conStr = null;
            string procedure = "[SpGetNextWorkId]";
            WorkNeeded work = new WorkNeeded();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    work = db.QuerySingle<WorkNeeded>(procedure, commandType: CommandType.StoredProcedure);
                    work.Work_Id += 1;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return work.Work_Id;
        }
    }
}
