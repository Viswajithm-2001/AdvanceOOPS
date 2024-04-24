using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class StudentInfo: PersonalInfo
    {
        public long RegisterNumber{get;set;}
        public int Standard{get;set;}
        public string Branch {get; set;}
        public int AcademicYear {get; set;}

        public StudentInfo(string name, string fatherName,string phoneNumber,string mailID,DateTime dob,Gender gender):base( name,fatherName, phoneNumber, mailID,dob, gender)
        {
            
        }

        public void GetStudentInfo()
        {
            Console.Write("Enter your RegisterNumebr : ");
            long registerNumber = long.Parse(Console.ReadLine()); 
            Console.Write("Enter your standard : ");
            int standard = int.Parse(Console.ReadLine());
            Console.Write("Enter your branch : ");
            string branch = Console.ReadLine();
            Console.Write("Enter your Academic year : ");
            int academicYear = int.Parse(Console.ReadLine());
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch = branch;
            AcademicYear=academicYear;

        }
        public void ShowInfo()
        {
            System.Console.WriteLine("Here are your Details : ");
            System.Console.WriteLine($"Name                : {Name}");
            System.Console.WriteLine($"Father Name         : {FatherName}");
            System.Console.WriteLine($"Phone Number        : {PhoneNumber}");
            System.Console.WriteLine($"Mail ID             : {MailID}");
            System.Console.WriteLine($"DateOfBirth         : {Dob.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"RegisterNumebr      : {RegisterNumber}");
            System.Console.WriteLine($"standard            : {Standard}");
            System.Console.WriteLine($"Branch              : {Branch}");
            System.Console.WriteLine($"Academicyear        : {AcademicYear}");

        }
        
    }
}