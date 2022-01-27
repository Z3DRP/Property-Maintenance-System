using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class Property
    {
        public int Property_Id
        {
            get { return Property_Id; }
            set
            {
                if (value >= int.MinValue && value <= int.MaxValue)
                    Property_Id = value;
                else
                    throw new ArgumentException("Property Id is out of bounds");
            }
        }
        public int Property_Number
        {
            get { return Property_Number; }
            set
            {
                if (value >= int.MinValue && value <= int.MaxValue)
                    Property_Number = value;
                else
                    throw new ArgumentException("Property Number is out of bounds");
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
                    throw new ArgumentException("Address cannot be more than 75 characters");
            }
        }
        public int Number_Rooms
        {
            get { return Number_Rooms; }
            set
            {
                if (value <= 20 && value > 0)
                    Number_Rooms = value;
                else
                    throw new ArgumentException("Number of rooms is out of bounds");
            }
        }
        public int Number_Baths
        {
            get { return Number_Baths; }
            set
            {
                if (value <= 20 && value > 0)
                    Number_Baths = value;
                else
                    throw new ArgumentException("Number of baths is out of bounds");
            }
        }
        public int Price
        {
            get { return Price; }
            set
            {
                if (value <= int.MaxValue && value > 0)
                    Price = value;
                else
                    throw new ArgumentException("Price is out of bounds");
            }
        }
        public int Rent
        {
            get { return Rent; }
            set
            {
                if (value <= int.MaxValue && value > 0)
                    Rent = value;
                else
                    throw new ArgumentException("Rent is out of bounds");
            }
        }
        public string Occupied
        {
            get { return Occupied; }
            set
            {
                if (value.ToLower() == "true" || value.ToLower() == "false")
                    Occupied = value;
                else
                    throw new ArgumentException("Occupied value is must be 'true' or 'false' non-bool");
            }
        }
        public string Rental
        {
            get { return Rental; }
            set
            {
                if (value.ToLower() == "true" || value.ToLower() == "false")
                    Rental = value;
                else
                    throw new ArgumentException("Rental value is must be 'true' or 'false' non-bool");
            }
        }
        public string Fenced
        {
            get { return Fenced; }
            set
            {
                if (value.ToLower() == "true" || value.ToLower() == "false")
                    Fenced = value;
                else
                    throw new ArgumentException("Fenced value is must be 'true' or 'false' non-bool");
            }
        }
        public string Parking
        {
            get { return Parking; }
            set
            {
                if (value.Length <= 20 && value.Length > 0)
                    Parking = value;
                else
                    throw new ArgumentException("Parking value cannot be more than 20 characters");
            }
        }
        public string Heating
        {
            get { return Heating; }
            set
            {
                if (value.Length <= 75 && value.Length > 0)
                    Heating = value;
                else
                    throw new ArgumentException("Heating value cannot be more than 75 characters");
            }
        }
        public string Cooling
        {
            get { return Cooling; }
            set
            {
                if (value.Length <= 75 && value.Length > 0)
                    Cooling = value;
                else
                    throw new ArgumentException("Cooling value cannot be more than 75 characters");
            }
        }
        // have to figure out how to do a property for a sql varbinary(max) datatype and how 
        // to use the bits to form the picture
        public byte[] House_Image { get; set; }
        public Property CopyProperty()
        {
            return (Property)this.MemberwiseClone();
        }
    }
}
