using System;
namespace UserApplication;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("name","fname","0987654321","mail.com",Gender.Male,"mname","native",2,new DateTime(1999,10,10));
    }
}