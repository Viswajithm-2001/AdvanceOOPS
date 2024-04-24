using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class EmployeeInfo : IDisplayInfo
    {
        private static int s_employeeID = 1000;
        public string EmployeeID{get;}
        public string Name { get; set; }
        public string FatherName { get; set; }

        public EmployeeInfo(string name,string fatherName)
        {
            EmployeeID = "SID"+(++s_employeeID);
            Name = name;
            FatherName = fatherName;
        }
        public void Display()
        {
            System.Console.WriteLine($"Student ID : {EmployeeID}");
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Father Name : {FatherName}");

        }
    }
}