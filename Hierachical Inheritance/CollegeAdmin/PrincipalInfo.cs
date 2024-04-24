using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmin
{
    public class PrincipalInfo : PersonalInfo
    {
        private static int s_pID = 1000;
        public string PrincipalID{get;}
        public string Qualification { get; set; }
        public double YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipalInfo(string name, string fatherName,string phoneNumber,string mailID,DateTime dob,Gender gender,string qualification,double yearOfExperience,DateTime dateOfJoining): base(name, fatherName,phoneNumber,mailID,dob, gender)
        {
            PrincipalID = "PID"+(++s_pID);
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Hi Principal..");
            Console.WriteLine("Here are your Info....");
            System.Console.WriteLine($"Your Principal ID    : {PrincipalID}");
            System.Console.WriteLine($"Name                 : {Name}");
            System.Console.WriteLine($"FatherName           : {FatherName}");
            System.Console.WriteLine($"Date of birth        : {Dob.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Phone Number         : {PhoneNumber}");
            System.Console.WriteLine($"Gender               : {Gender}");
            System.Console.WriteLine($"Mail ID              : {MailID}");
            System.Console.WriteLine($"Qualification        : {Qualification}");
            System.Console.WriteLine($"Year of experience   : {YearOfExperience}");
            System.Console.WriteLine($"Date of joining      : {DateOfJoining.ToString("dd/MM/yyyy")}");
            
            
            
        }
    }
}