using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmin
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_sID = 100;
        public string StudentID{get;}
        public string Degree { get; set; }
        public string Department {get;set;}
        public int Semester {get;set;}
        public StudentInfo(string name, string fatherName,string phoneNumber,string mailID,DateTime dob,Gender gender,string degree,string department,int semester): base(name, fatherName,phoneNumber,mailID,dob, gender)
        {
            StudentID = "SID"+(++s_sID);
            Degree = degree;
            Department = department;
            Semester = semester;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Hi Teacher..");
            Console.WriteLine("Here are your Info....");
            System.Console.WriteLine($"Your Teacher ID      : {StudentID}");
            System.Console.WriteLine($"Name                 : {Name}");
            System.Console.WriteLine($"FatherName           : {FatherName}");
            System.Console.WriteLine($"Date of birth        : {Dob.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Phone Number         : {PhoneNumber}");
            System.Console.WriteLine($"Gender               : {Gender}");
            System.Console.WriteLine($"Mail ID              : {MailID}");
            System.Console.WriteLine($"Degree               : {Degree}");
            System.Console.WriteLine($"Department           : {Department}");
            System.Console.WriteLine($"Semester             : {Semester}");
            
        }
    }
}