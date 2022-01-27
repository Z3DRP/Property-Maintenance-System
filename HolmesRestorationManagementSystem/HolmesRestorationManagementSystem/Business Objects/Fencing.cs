using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class Fencing
    {
        private int id;
        private string fence;
        public int Id
        {
            get { return id; }
            set
            {
                if (value >= int.MinValue && value <= int.MaxValue)
                    id = value;
                else
                    throw new ArgumentException("Fencing Id is out of range");
            }
        }
        public string Fence_Type
        {
            get { return fence; }
            set
            {
                if (value.Length <= 30 && value.Length > 0)
                    fence = value;
                else
                    throw new ArgumentException("Fence type cannot be more than 30 characters");
            }
        }
    }
}
