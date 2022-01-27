using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class Occupancy
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
        public int Tenant_Id
        {
            get { return Tenant_Id; }
            set
            {

                if (value >= int.MinValue && value <= int.MaxValue)
                    Tenant_Id = value;
                else
                    throw new ArgumentException("Tenant Id is out of bounds");
            }
        }
        public DateTime Move_In_Date { get; set; }
    }
}
