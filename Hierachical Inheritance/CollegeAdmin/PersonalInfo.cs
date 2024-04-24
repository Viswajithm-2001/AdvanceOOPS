using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmin
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName {get;set;}
        public string PhoneNumber {get; set;}
        public string MailID {get; set;}
        public DateTime Dob {get;set;}
        public Gender Gender {get; set;}

        public PersonalInfo(string name, string fatherName,string phoneNumber,string mailID,DateTime dob,Gender gender)
        {
            Name = name;
            FatherName= fatherName;
            PhoneNumber=phoneNumber;
            MailID=mailID.ToLower();
            Dob = dob;
            Gender=gender;
        }
    }
}