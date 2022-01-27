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
    public static class UserDB
    {
        public static string GetConString()
        {
            string conStr = null;
            conStr = Connector.GetConnection();

            return conStr;
        }
        public static List<User> GetUsers()
        {
            string conStr = null;
            string procedure = "[SpGetAllUsers]";
            List<User> users = new List<User>();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    users = db.Query<User>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return users;
        }
        public static bool FindUsername(string usr)
        {
            string conStr = null;
            string procedure = "[GetUsername]";
            var parm = new { user = usr };
            User user = new User();
            bool found = false;

            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    user = db.QuerySingle<User>(procedure, commandType: CommandType.StoredProcedure);

                    if (user != null)
                        found = true;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return found;
        }
        public static User GetUser(int userID)
        {
            string conStr = null;
            string procedure = "[SpGetUser]";
            var par = new { uId = userID };
            User user = new User();
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    user = db.QuerySingle<User>(procedure, par, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            { throw ex; }

            return user;
        }
        public static User GetUserCredintials(string usrname)
        {
            string conStr = null;
            string procedure = "[SpFindUsername]";
            var par = new { user = usrname };
            User user = new User();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    user = db.QuerySingle<User>(procedure, par, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return user;
        }
        public static bool AddUser(User user)
        {
            string conStr = null;
            string procedure = "[SpAddUser]";
            var pars = new
            {
                id = user.Id,
                user = user.Username,
                pwd = user.Password,
                admin = user.IsAdmin
            };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, pars, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static bool UpdateUser(User usr)
        {
            string conStr = null;
            string procedure = "[SpUpdateUser]";
            var pars = new
            {
                id = usr.Id,
                user = usr.Username,
                pwd = usr.Password,
                admin = usr.IsAdmin
            };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, pars, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static bool DeleteUser(int usrID)
        {
            string conStr = null;
            string procedure = "[SpDeleteUser]";
            var pars = new { uId = usrID };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, pars, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static User GetUserId(string username)
        {
            string conStr = null;
            string procedure = "[SpGetUserId]";
            var pars = new { user = username };
            User user = new User();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    user = db.QuerySingle<User>(procedure, pars, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return user;
        }
        public static User GetUsername(int usrId)
        {
            string conStr = null;
            string procedure = "[SpGetUsername]";
            var pars = new { id = usrId };
            User username = new User();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    username = db.QuerySingle<User>(procedure, pars, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return username;
        }
        public static User GetUserPassword(string username)
        {
            string conStr = null;
            string procedure = "[SpGetUserPwd]";
            var pars = new { user = username };
            User user = new User();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    user = db.QuerySingle<User>(procedure, pars, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return user;
        }
        public static List<User> SearchUser(string username)
        {
            string conStr = null;
            string procedure = "[SpSearchUser]";
            string userWC = username + "%";
            var pars = new { user = userWC };
            List<User> usrs = new List<User>();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    usrs = db.Query<User>(procedure, pars, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }

            return usrs;
        }
        public static int GetNextUserId()
        {
            string conStr = null;
            string procedure = "[GetNextUserId]";
            User user = new User();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    user = db.QuerySingle<User>(procedure,commandType: CommandType.StoredProcedure);
                    user.Id += 1;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return user.Id;
        }
        public static bool UpdateUserPassword(User usr)
        {
            string conStr = null;
            string procedure = "[SpChangeUsrPwd]";
            var parms = new { usrname = usr.Username, pwd = usr.Password };
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
