using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class WorkNeeded
    {
        public int Work_Id
        {
            get { return Work_Id; }
            set
            {
                if (value <= int.MaxValue && value > 0)
                    Work_Id = value;
                else
                    throw new ArgumentException("Work Id is out of bounds");
            }
        }
        public int Property_Id
        {
            get { return Property_Id; }
            set
            {
                if (value <= int.MaxValue && value > 0)
                    Property_Id = value;
                else
                    throw new ArgumentException("Property Id is out of bounds");
            }
        }
        public string Work_Needed
        {
            get { return Work_Needed; }
            set
            {
                if (value.Length <= int.MaxValue && value.Length > 0)
                    Work_Needed = value;
                else
                    throw new ArgumentException("Work Needed cannot be more than 2GB or 2,147,483,647 characters");
            }
        }
        public DateTime Desired_Completion_Date { get; set; }
        public int Priority_Level
        {
            get { return Priority_Level; }
            set
            {
                if (value <= 5 && value > 0)
                    Priority_Level = value;
                else
                    throw new ArgumentException("Priority Level must be between 1 - 5");
            }
        }
        public WorkNeeded CopyWork()
        {
            return (WorkNeeded)this.MemberwiseClone();
        }
    }
}
