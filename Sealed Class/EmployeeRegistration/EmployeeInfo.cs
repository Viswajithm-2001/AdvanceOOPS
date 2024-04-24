using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public sealed class EmployeeInfo : PersonalInfo
    {
        public string UserID { get; }
        public string Password { get; set; }
        public int KeyInfo { get { return 100; } }

        public EmployeeInfo(string userID, string password, string name, string fathername, string mobile, string mail, Gender gender) : base(name, fathername, mobile, mail, gender)
        {
            UserID = userID;
            Password = password;
        }
        public void UpdateInfo(string password, string name, string fatherName, string mobile, string mail, Gender gender)
        {
            Password = password;
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"User ID : {UserID}");
            System.Console.WriteLine($"Key Info : {KeyInfo}"); 
            System.Console.WriteLine($"User Name : {Name}");
            System.Console.WriteLine($"Father name : {FatherName}");
            System.Console.WriteLine($"Mobile Number : {Mobile}");
            System.Console.WriteLine($"Mail ID : {Mail}");
            System.Console.WriteLine($"Gender : {Gender}");

        }
    }
}