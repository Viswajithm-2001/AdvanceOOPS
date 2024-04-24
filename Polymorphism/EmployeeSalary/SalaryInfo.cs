using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class SalaryInfo : EmployeeInfo
    {
        //field
        //property
        public int NoOfWorkingDays{get;set;}

        public SalaryInfo(string name,string fatherName,string phoneNumber,Gender gender,int noOfWorkingDays) : base(name,fatherName,phoneNumber,gender)
        {
            NoOfWorkingDays = noOfWorkingDays;
        }
        public override void CalculateSalary()
        {
            SalaryAmount = 500*NoOfWorkingDays;
            System.Console.WriteLine($"Salary : {SalaryAmount}");
        }
        public override void Display()
        {
            System.Console.WriteLine($"Employee ID : {EmployeeID}");
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Father Name : {FatherName}");
            System.Console.WriteLine($"Gender : {Gender}");
            System.Console.WriteLine($"PhoneNumber : {PhoneNumber}");

        }
    }
}