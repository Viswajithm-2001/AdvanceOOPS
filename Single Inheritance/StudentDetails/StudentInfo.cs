using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class StudentInfo : PersonalInfo
    {
        public long RegisterNumber { get; set; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }

        public StudentInfo(string name, string fatherName,string phoneNumber,string mailID,DateTime dob,Gender gender,long registerNumber,int standard,string branch,int academicYear):base (name,fatherName,phoneNumber,mailID,dob,gender)
        {
            RegisterNumber=registerNumber;
            Standard = standard;
            Branch=branch;
            AcademicYear=academicYear;

        }
        public void ShowStudentInfo()
        {
            Console.WriteLine($"Your Name : {Name}");
            Console.WriteLine($"Your Father Name : {FatherName}");
            Console.WriteLine($"Your Phone Number : {PhoneNumber}");
            Console.WriteLine($"Your Mail ID: {MailID}");
            Console.WriteLine($"Your Date OF birth: {Dob}");
            Console.WriteLine($"Your Gender : {Gender}");
            Console.WriteLine($"Your Register Number: {RegisterNumber}");
            Console.WriteLine($"Your Standard : {Standard}");
            Console.WriteLine($"Your Branch : {Branch}");
            Console.WriteLine($"Your AcademicYear : {AcademicYear}");

        }
    }
}