using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class Parking
    {
        private int id;
        private string parking;
        public int Id
        {
            get { return id; }
            set
            {
                if (value >= int.MinValue && value <= int.MaxValue)
                    id = value;
                else
                    throw new ArgumentException("Parking Id is out of bounds");
            }
        }
        public string Parking_Type
        {
            get { return parking; }
            set
            {
                if (value.Length <= 50 && value.Length > 0)
                    parking = value;
                else
                    throw new ArgumentException("Parking Type cannot be more than 50 characters");
            }
        }
    }
}
