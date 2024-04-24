using System;
namespace AttendanceQuestion;

class Program
{
    public static void Main(string[] args)
    {
        Attendance month1 = new Attendance(20,1,5);
        Attendance month2 = new Attendance(22,2,4);
        Attendance month3 = new Attendance(19,0,3);

        System.Console.WriteLine($"Month 1 Salary : {month1.Calculate()}");
        System.Console.WriteLine($"Month 2 Salary : {month2.Calculate()}");
        System.Console.WriteLine($"Month 3 Salary : {month3.Calculate()}");
    }
}