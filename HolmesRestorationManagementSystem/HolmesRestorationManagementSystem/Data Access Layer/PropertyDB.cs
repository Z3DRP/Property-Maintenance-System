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
    public static class PropertyDB
    {
        public static string GetConString()
        {
            string conStr = null;
            conStr = Connector.GetConnection();

            return conStr;
        }
        public static List<Property> GetProperties()
        {
            string conStr = null;
            var procedure = "[SpGetAllProperties]";
            List<Property> properties = new List<Property>();

            try
            {
                conStr = GetConString();
                using(IDbConnection db = new SqlConnection(conStr))
                {
                    properties = db.Query<Property>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            { throw ex; }

            return properties;
        }
        public static List<Property> GetAddressAndId()
        {
            string conStr = null;
            var procedure = "[SpGetAddressId]";
            List<Property> properties = new List<Property>();

            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    properties = db.Query<Property>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }

            return properties;
        }
        public static List<Property> GetPropertyInfo()
        {
            string conStr = null;
            var procedure = "[SpGetPropertyInfo]";
            List<Property> properties = new List<Property>();

            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    properties = db.Query<Property>(procedure, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }

            return properties;
        }
        public static Property GetProperty(int propId)
        {
            string conStr = null;
            var procedure = "[SpGetProperty]";
            var parm = new { pId = propId };
            Property prop = new Property();

            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    prop = db.QuerySingle<Property>(procedure, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return prop;
        }
        public static bool AddProperty(Property prop)
        {
            string conStr = null;
            var procedure = "[SpAddProperty]";
            var parms = new
            {
                pId = prop.Property_Id,
                pNum = prop.Property_Number,
                address = prop.Address,
                beds = prop.Number_Rooms,
                baths = prop.Number_Baths,
                price = prop.Price,
                rent = prop.Rent,
                occupied = prop.Occupied,
                rental = prop.Rental,
                fenced = prop.Fenced,
                parking = prop.Parking,
                heat = prop.Heating,
                cooling = prop.Cooling,
                img = prop.House_Image
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
        public static bool DeleteProperty(Property prop)
        {
            string conStr = null;
            var procedure = "[SpDeleteProperty]";
            var parm = new { pId = prop.Property_Id };
            int rowsAffected;
            bool returnStatus;
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    rowsAffected = db.Execute(procedure, parm, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            returnStatus = rowsAffected > 0 ? true : false;
            return returnStatus;
        }
        public static bool UpdateProperty(Property prop)
        {
            string conStr = null;
            var procedure = "[SpUpdateProperty]";
            var parms = new
            {
                pId = prop.Property_Id,
                pNum = prop.Property_Number,
                address = prop.Address,
                beds = prop.Number_Rooms,
                baths = prop.Number_Baths,
                price = prop.Price,
                rent = prop.Rent,
                occupied = prop.Occupied,
                rental = prop.Rental,
                fenced = prop.Fenced,
                parking = prop.Parking,
                heat = prop.Heating,
                cooling = prop.Cooling,
                img = prop.House_Image
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
        public static Property GetPropertyId(string Address)
        {
            string conStr = null;
            var procedure = "[SpGetPropertyId]";
            var parm = new { address = Address };
            Property propId = new Property();
            try
            {
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    propId = db.QuerySingle(procedure, parm, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            { throw ex; }

            return propId;
        }
        public static Property GetPropertyAddress(int PropID)
        {
            string conStr = null;
            var procedure = "[SpGetPropertyAddress]";
            var parm = new { id = PropID };
            Property prop = new Property();
            try
            {
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    prop = db.QuerySingle(procedure, parm, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return prop;
        }
        public static List<Property> SearchProperties(string Address)
        {
            string conStr = null;
            var procedure = "[SpSearchProperties]";
            string addressWC = Address + "%";
            var parm = new { address = addressWC };
            List<Property> properties = new List<Property>();
            try
            {
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    properties = db.QuerySingle(procedure, parm, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            { throw ex; }

            return properties;
        }
        public static int GetNextPropertyId()
        {
            string conStr = null;
            string procedure = "[SpGetNextPropertyId]";
            Property property = new Property();
            try
            {
                conStr = GetConString();
                using (IDbConnection db = new SqlConnection(conStr))
                {
                    property = db.QuerySingle<Property>(procedure, commandType: CommandType.StoredProcedure);
                    property.Property_Id += 1;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return property.Property_Id;
        }
    }
}
