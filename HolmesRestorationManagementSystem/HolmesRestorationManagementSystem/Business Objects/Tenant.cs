using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class Tenant
    {
        public int Tenant_Id
        {
            get { return Tenant_Id; }
            set
            {
                if (value <= int.MaxValue && value > 0)
                    Tenant_Id = value;
                else
                    throw new ArgumentException("Tenant Id is out of bounds");
            }
        }
        public string First_Name
        {
            get { return First_Name; }
            set
            {
                if (value.Length <= 50 && value.Length > 0)
                    First_Name = value;
                else
                    throw new ArgumentException("First name cannot be more than 50 characters");
            }
        }
        public string Last_Name
        {
            get { return Last_Name; }
            set
            {
                if (value.Length <= 75 && value.Length > 0)
                    Last_Name = value;
                else
                    throw new ArgumentException("Last name cannot be more than 75 characters");
            }
        }
        public string Phone_Number
        {
            get { return Phone_Number; }
            set
            {
                if (value.Length <= 10 && value.Length > 0)
                    Phone_Number = value;
                else
                    throw new ArgumentException("Phone number cannot be more than 10 characters");
            }
        }
        public string Address
        {
            get { return Address; }
            set
            {
                if (value.Length <= 75 && value.Length > 0)
                    Address = value;
                else
                    throw new ArgumentException("Address cannot be more than 75 characteers");
            }
        }
        public string Occupation
        {
            get { return Occupation; }
            set
            {
                if (value.Length <= 100 && value.Length > 0)
                    Occupation = value;
                else
                    throw new ArgumentException("Occupation cannot be more than 100 characters");
            }
        }
        public int Employment_Length
        {
            get { return Employment_Length; }
            set
            {
                if (value <= 65 && value > 0)
                    Employment_Length = value;
                else
                    throw new ArgumentException("Length of Employment cannot be more than 65 years");
            }
        }
        public string Disabled
        {
            get { return Disabled; }
            set
            {
                if (value.ToLower() == "true" || value.ToLower() == "false")
                    Disabled = value;
                else
                    throw new ArgumentException("Disabled value must be 'true' or 'false' non-bool");
            }
        }
        public string Government_Assistance
        {
            get { return Government_Assistance; }
            set
            {
                if (value.ToLower() == "true" || value.ToLower() == "false")
                    Government_Assistance = value;
                else
                    throw new ArgumentException("Government Assistance value must be 'true' or 'false' non-bool");
            }
        }
        public Tenant CopyTenant()
        {
            return (Tenant)this.MemberwiseClone();
        }
        public static bool operator ==(Tenant t1, Tenant t2)
        {
            bool isEqual;
            int NumberNotEqual = 0;

            if (t1.Tenant_Id != t2.Tenant_Id)
                NumberNotEqual++;
            if (t1.First_Name != t2.First_Name)
                NumberNotEqual++;
            if (t1.Last_Name != t2.Last_Name)
                NumberNotEqual++;
            if (t1.Address != t2.Address)
                NumberNotEqual++;
            if (t1.Phone_Number != t2.Phone_Number)
                NumberNotEqual++;
            if (t1.Occupation != t2.Occupation)
                NumberNotEqual++;
            if (t1.Employment_Length != t2.Employment_Length)
                NumberNotEqual++;
            if (t1.Disabled != t2.Disabled)
                NumberNotEqual++;
            if (t1.Government_Assistance != t2.Government_Assistance)
                NumberNotEqual++;

            isEqual = NumberNotEqual > 0 ? true : false;
            return isEqual;
        }
        public static bool operator !=(Tenant t1, Tenant t2)
        {
            bool NotEqual;
            int NumberEqual = 0;

            if (t1.Tenant_Id == t2.Tenant_Id)
                NumberEqual++;
            if (t1.First_Name == t2.First_Name)
                NumberEqual++;
            if (t1.Last_Name == t2.Last_Name)
                NumberEqual++;
            if (t1.Address == t2.Address)
                NumberEqual++;
            if (t1.Phone_Number == t2.Phone_Number)
                NumberEqual++;
            if (t1.Occupation == t2.Occupation)
                NumberEqual++;
            if (t1.Employment_Length == t2.Employment_Length)
                NumberEqual++;
            if (t1.Disabled == t2.Disabled)
                NumberEqual++;
            if (t1.Government_Assistance == t2.Government_Assistance)
                NumberEqual++;

            NotEqual = NumberEqual > 0 ? true : false;
            return NotEqual;
        }
    }
}
