using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPartial
{
    public static class Application
    {
        public static void ApplicationForm()
        {
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Gender : ");
            Gender gender  = Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter your Date of birth (dd/MM/yyyy) : ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter your Mobile Number : ");
            string mobileNumber = Console.ReadLine();
            Console.Write("Enter your Physics Mark : ");
            int physicsMark = int.Parse(Console.ReadLine());
            Console.Write("Enter your Physics Mark : ");
            int chemistryMark = int.Parse(Console.ReadLine());
            Console.Write("Enter your Physics Mark : ");
            int mathsMark = int.Parse(Console.ReadLine());

            StudentInfo student1 = new StudentInfo(name,gender,dob,mobileNumber,physicsMark,chemistryMark,mathsMark);

            System.Console.WriteLine("Here are your Total and Percentage");
            student1.Calculate();
            System.Console.WriteLine("______________________________________________");
            System.Console.WriteLine("Here are your Details ....");
            student1.Display();
            
        }
    }
}