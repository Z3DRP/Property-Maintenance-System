using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class Heating
    {
        private int id;
        private string heating;
        public int Id
        {
            get { return id; }
            set
            {
                if (value >= int.MinValue && value <= int.MaxValue)
                    id = value;
                else
                    throw new ArgumentException("Heating Id is out of bounds");
            }
        }
        public string Heating_Type
        {
            get { return heating; }
            set
            {
                if (value.Length <= 100 && value.Length > 0)
                    heating = value;
                else
                    throw new ArgumentException("Heating Type cannot be more than 100 characters");
            }
        }
    }
}
