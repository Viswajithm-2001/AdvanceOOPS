using System;
namespace EmployeePartial;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("Employee1",Gender.Female,new DateTime(1999,11,11),"+91 9876543210");
        employee.Display();
        employee.Update();
        employee.Display();
    }
}