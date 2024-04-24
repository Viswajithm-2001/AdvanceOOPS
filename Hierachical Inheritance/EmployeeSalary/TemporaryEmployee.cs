using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class TemporaryEmployee : SalaryInfo
    {
        private static int s_eID = 2000;
        public string EmployeeID {get;set;}
        public double Salary {get;set;}

        public EmployeeType EmployeeType {get;set;}
        public TemporaryEmployee(double basicSalary,int month) : base(basicSalary,month)
        {
            EmployeeID = "TEID"+(++s_eID);
        }
        double DA = 0.0015;
        double HRA = 0.0018;
        double PF = 0.001;

        public void CalculateSalary()
        {
            Salary = BasicSalary +(DA*BasicSalary)+(HRA*BasicSalary)-(PF*BasicSalary);
        }
        public void ShowSalary()
        {
            CalculateSalary();
            Console.WriteLine($"Your Salary for {Month} months is : Rs.{(double)Month*Salary}");
        }
    }
}