using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePartial
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string name ,Gender gender,DateTime dob,string mobileNumber)
        {
            EmployeeID = "EID"+(++s_employeeID);
            Name = name;
            Gender = gender;
            Dob =dob;
            MobileNumber = mobileNumber;
        }
    }
}