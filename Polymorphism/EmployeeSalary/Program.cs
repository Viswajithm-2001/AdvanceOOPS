using System;
namespace EmployeeSalary;

class Program
{
    public static void Main(string[] args)
    {
        PersonDetails personal1 = new EmployeeInfo("emp","father1","098765432",Gender.Female);
        SalaryInfo sal1 = new SalaryInfo("Employee1","Father1","098768362489",Gender.Male,30);
        sal1.CalculateSalary();
        sal1.Display();
    }
}