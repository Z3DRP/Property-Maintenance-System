using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class TruthValues
    {
        private int id;
        private string truth;
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0 && value <= 2)
                    id = value;
                else
                    throw new ArgumentException("Truth Value id is out of bounds");
            }
        }
        public string Truth_Value
        {
            get { return truth; }
            set
            {
                if (value.ToLower() == "true" || value.ToLower() == "false")
                    truth = value;
                else
                    throw new ArgumentException("Truth Value must be 'true' or 'false' non-bool");
            }
        }
    }
}
