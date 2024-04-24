using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonDetails
{
    public enum Gender { Select, Male, Female, Transgender }
    public enum MaritalStatus { Select, Single, Married }
    public class PersonalInfo : IShowData
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Dob { get; set; }
        public string MobileNumber { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        public PersonalInfo(string name,Gender gender,DateTime dob,string mobileNumber,MaritalStatus marital)
        {
            Name = name;
            Gender = gender;
            Dob = dob;
            MobileNumber = mobileNumber;
            MaritalStatus = marital;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Gender : {Gender}");
            System.Console.WriteLine($"Date of birth : {Dob.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Mobile Number : {MobileNumber}");
            System.Console.WriteLine($"Marital Status : {MaritalStatus}");
        }
    }
}