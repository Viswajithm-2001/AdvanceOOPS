using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class EmployeeInfo : PersonDetails
    {
        private static int s_employeeID = 100;

        public string EmployeeID { get; set; }
        public double SalaryAmount{get;set;}

        public EmployeeInfo(string name,string fatherName,string mobileNumber,Gender gender) : base(name,fatherName,mobileNumber,gender)
        {
            EmployeeID = "EID"+(++s_employeeID);            
        }
        public virtual void CalculateSalary()
        {
        }
        public virtual void Display()
        {
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Father Name : {FatherName}");
            System.Console.WriteLine($"Gender : {Gender}");
            System.Console.WriteLine($"Phone Number : {PhoneNumber}");
        }
    }
}