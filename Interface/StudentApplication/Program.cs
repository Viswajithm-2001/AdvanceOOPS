using System;
namespace StudentApplication;

class Program
{
    public static void Main(string[] args)
    {
        //Creating Object for Student Class
        StudentInfo student1 = new StudentInfo("Student1","Student1Father","+919876543210");
        //creating object for Employee Class
        EmployeeInfo employee1 = new EmployeeInfo("Employee1","Employee1Father");

        //Display info of both
        System.Console.WriteLine("__________________________________________");
        student1.Display();
        System.Console.WriteLine("___________________________________________");
        employee1.Display();
        System.Console.WriteLine("___________________________________________");
    }
}