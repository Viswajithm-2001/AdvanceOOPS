using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmin
{
    public class TeacherInfo : PersonalInfo
    {
        private static int s_tID = 1000;
        public string TeacherID {get;}
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public double YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public TeacherInfo(string name, string fatherName,string phoneNumber,string mailID,DateTime dob,Gender gender,string department,string subjectTeaching,string qualification,double yearOfExperience,DateTime dateOfJoining): base(name, fatherName,phoneNumber,mailID,dob, gender)
        {
            TeacherID = "TID"+(++s_tID);
            Department = department;
            SubjectTeaching = subjectTeaching;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Hi Teacher..");
            Console.WriteLine("Here are your Info....");
            System.Console.WriteLine($"Your Teacher ID      : {TeacherID}");
            System.Console.WriteLine($"Name                 : {Name}");
            System.Console.WriteLine($"FatherName           : {FatherName}");
            System.Console.WriteLine($"Date of birth        : {Dob.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Phone Number         : {PhoneNumber}");
            System.Console.WriteLine($"Gender               : {Gender}");
            System.Console.WriteLine($"Mail ID              : {MailID}");
            System.Console.WriteLine($"Department           : {Department}");
            System.Console.WriteLine($"Subject Teaching     : {SubjectTeaching}");
            System.Console.WriteLine($"Qualification        : {Qualification}");
            System.Console.WriteLine($"Year of experience   : {YearOfExperience}");
            System.Console.WriteLine($"Date of joining      : {DateOfJoining.ToString("dd/MM/yyyy")}");
            
              
        }
    }
}