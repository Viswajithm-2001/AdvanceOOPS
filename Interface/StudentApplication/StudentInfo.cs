using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class StudentInfo : IDisplayInfo
    {
        private static int s_studentID = 1000;
        public string StudentID{get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MobileNumber { get; set; }

        public StudentInfo(string name,string fatherName,string mobileNumber)
        {
            StudentID = "SID"+(++s_studentID);
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
        }
        public void Display()
        {
            System.Console.WriteLine($"Student ID : {StudentID}");
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Father Name : {FatherName}");
            System.Console.WriteLine($"Mobile Number : {MobileNumber}");

        }
    }
}