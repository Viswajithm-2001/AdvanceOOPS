using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePartial
{
    public partial class EmployeeInfo
    {
        public void Update()
        {
            System.Console.WriteLine("Enter ");
            System.Console.WriteLine("1.Name\n2.Gender\n3.Date Of birth\n4. Mobile Number");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.Write("Enter your Name : ");
                    Name = Console.ReadLine();
                    break;
                }
                case 2:
                {
                    System.Console.Write("Enter your Gender : ");
                    Gender = Enum.Parse<Gender>(Console.ReadLine(),true);
                    break;
                }
                case 3:
                {
                    System.Console.Write("Enter your Date of birth (dd/MM/yyyy) : ");
                    Dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                    break;
                }
                case 4:
                {
                    System.Console.Write("Enter your Mobile Number");
                    MobileNumber = Console.ReadLine();
                    break;
                }
            }
            
        }
        public void Display()
        {
            System.Console.WriteLine($"Employee ID   : {EmployeeID}");
            System.Console.WriteLine($"Name          : {Name}");
            System.Console.WriteLine($"Gender        : {Gender}");
            System.Console.WriteLine($"Date of birth : {Dob}");
            System.Console.WriteLine($"Mobile Number : {MobileNumber}");
        }
    }
}