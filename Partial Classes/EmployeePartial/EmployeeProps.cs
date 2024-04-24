using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePartial
{
    public enum Gender {Select,male,Female}
    public partial class EmployeeInfo
    {
        private static int s_employeeID = 1000;
        public string EmployeeID;
        public string Name {get;set;}
        public Gender Gender {get;set;}
        public DateTime Dob {get;set;}
        public string MobileNumber {get;set;}

    }
}