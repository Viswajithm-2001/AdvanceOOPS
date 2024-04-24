using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class PermanentEmployee : SalaryInfo
    {
        private static int s_eID = 2000;
        public string EmployeeID { get; set; }
        public double Salary { get; set; }

        public EmployeeType EmployeeType { get; set; }
        public PermanentEmployee(double basicSalary, int month) : base(basicSalary, month)
        {
            EmployeeID = "PEID" + (++s_eID);
        }
        double DA = 0.002;
        double HRA = 0.018;
        double PF = 0.001;

        public void CalculateSalary()
        {
            Salary = BasicSalary + (DA * BasicSalary) + (HRA * BasicSalary) - (PF * BasicSalary);
        }
        public void ShowSalary()
        {
            CalculateSalary();
            Console.WriteLine($"Your Salary for {Month} months is : Rs.{(double)Month*Salary}");
        }
    }
}
