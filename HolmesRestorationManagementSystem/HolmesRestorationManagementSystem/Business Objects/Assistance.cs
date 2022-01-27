using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class Assistance
    {
        private int id;
        private string assistance;
        public int Id
        {
            get { return id; }
            set
            {
                if (value <= int.MaxValue && value >= int.MinValue)
                    id = value;
                else
                    throw new ArgumentException("Cooling Id is out of range");
            }
        }
        public string Cooling_Type
        {
            get { return assistance; }
            set
            {
                if (value.Length <= 100 && value.Length > 0)
                    assistance = value;
                else
                    throw new ArgumentException("Cooling Type cannot be longer than 100 characters");
            }
        }
    }
}
