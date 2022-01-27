using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class User
    {
        public int Id
        {
            get { return Id; }
            set
            {
                if (value <= int.MaxValue && value > 0)
                    Id = value;
                else
                    throw new ArgumentException("User Id is out of bounds");
            }
        }
        public string Username
        {
            get { return Username; }
            set
            {
                if (value.Length <= 20 && value.Length > 0)
                    Username = value;
                else
                    throw new ArgumentException("Username must be 20 characters or less");
            }
        }
        public string Password
        {
            get { return Password; }
            set
            {
                if (value.Length <= 255 && value.Length > 0)
                    Password = value;
                else
                    throw new ArgumentException("Password must be 255 characters or less");
            }
        }
        public string IsAdmin
        {
            get { return IsAdmin; }
            set
            {
                if (value.ToLower() == "true" || value.ToLower() == "false")
                    IsAdmin = value;
                else
                    throw new ArgumentException("IsAdmin value must be 'true' or 'false' non-bool");
            }
        }
        public User CopyUser()
        {
            return (User)this.MemberwiseClone();
        }
    }
}
