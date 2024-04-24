using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPartial
{
    public partial class StudentInfo
    {
        public void Calculate()
        {
            double total = PhysicsMark+ChemistryMark+MathsMark;
            System.Console.WriteLine($"Your Total is : {total}");
            System.Console.WriteLine($"Your Percentage is : {Math.Round((total/3),2)}%");

        }
        public void Display()
        {
            System.Console.WriteLine($"Student ID   : {StudentID}");
            System.Console.WriteLine($"Name          : {Name}");
            System.Console.WriteLine($"Gender        : {Gender}");
            System.Console.WriteLine($"Date of birth : {Dob}");
            System.Console.WriteLine($"Mobile Number : {MobileNumber}");
            System.Console.WriteLine($"Your Physics Mark : {PhysicsMark}");
            System.Console.WriteLine($"Your Chemistry Mark : {ChemistryMark}");
            System.Console.WriteLine($"Your Maths Mark : {MathsMark}");
            Calculate();
        }
    }
}