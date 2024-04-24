using System;
using System.Collections.Generic;

namespace EmployeeSalary;
class Program
{
    public static void Main(string[] args)
    {
        List<PermanentEmployee> permanentEmployeeList = new List<PermanentEmployee>();
        List<TemporaryEmployee> temporaryEmployeeList = new List<TemporaryEmployee>();

        PermanentEmployee pEmployee1 = new PermanentEmployee(15000,5);
        PermanentEmployee pEmployee2 = new PermanentEmployee(15000,6);

        permanentEmployeeList.Add(pEmployee1);
        permanentEmployeeList.Add(pEmployee2);
        
        TemporaryEmployee tEmployee1 = new TemporaryEmployee(15000,5);
        TemporaryEmployee tEmployee2 = new TemporaryEmployee(15000,6);

        temporaryEmployeeList.Add(tEmployee1);
        temporaryEmployeeList.Add(tEmployee2);

        System.Console.WriteLine("Permanent employee...");
        foreach(PermanentEmployee permanentEmployee in permanentEmployeeList)
        {
            System.Console.WriteLine("__________________________________________");
            permanentEmployee.ShowSalary();
            System.Console.WriteLine("__________________________________________");
        }
        System.Console.WriteLine("Temporary Employee....");
        foreach(TemporaryEmployee temporaryEmployee in temporaryEmployeeList)
        {
            System.Console.WriteLine("__________________________________________");
            temporaryEmployee.ShowSalary();
            System.Console.WriteLine("__________________________________________");
        }
        Console.WriteLine("Thank you..");

    }
}