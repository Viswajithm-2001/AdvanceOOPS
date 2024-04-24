using System;
namespace EmployeeRegistration;

class Program
{
    public static void Main(string[] args)
    {
        //Creating Objects for Employee class
        EmployeeInfo employee = new EmployeeInfo("user100","password","User","Father","+91987654321","mail@mail",Gender.Male);
        employee.UpdateInfo("user100","User","Father","+91987654321","mailID@mail",Gender.TransGender);
        employee.DisplayInfo();

        //Creat object fo Hack
        Hack hack = new Hack();
        hack.ShowKeyInfo();

        
    }
}