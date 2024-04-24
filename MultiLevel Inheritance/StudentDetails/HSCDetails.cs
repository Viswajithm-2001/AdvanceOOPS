using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class HSCDetails : StudentInfo
    {
        public long HSCMarksheetNumber {get;set;}
        public int PhysicsMark{get;set;}
        public int MathsMark{get;set;}
        public int ChemistryMark{get;set;}
        public int Total {get;set;}
        public double Percentage {get;set;}

        public HSCDetails(string name, string fatherName,string phoneNumber,string mailID,DateTime  dob,Gender gender,long hscMarksheetNumber):base( name, fatherName, phoneNumber, mailID,dob, gender)
        {
            
            HSCMarksheetNumber = hscMarksheetNumber;

        }

        public void GetMarks()
        {
            Console.Write("Enter Your Physics Marks : ");
            int physicsMark = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Chemistry Marks : ");
            int chemistryMark = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Maths Marks : ");
            int mathsMark = int.Parse(Console.ReadLine());
            PhysicsMark = physicsMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;
            System.Console.WriteLine("Your Marks are saved..");


        }
        public void Calculate()
        {
            Total = PhysicsMark+ChemistryMark+MathsMark;
            Percentage = (double)Total/3;
        }
        public void ShowMarkSheet()
        {
            ShowInfo();
            System.Console.WriteLine($"HSCMarkSheet Number : {HSCMarksheetNumber}");
            System.Console.WriteLine($"Physics Mark        : {PhysicsMark}");
            System.Console.WriteLine($"Chemistry Mark      : {ChemistryMark}");
            System.Console.WriteLine($"Maths Mark          : {MathsMark}");
            System.Console.WriteLine($"Total Marks         : {Total}");
            System.Console.WriteLine($"Percentage          : {Math.Round(Percentage,2)}");

        }
        
        
    }
}