using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public enum Gender{Select,Male,Female,TransGender}
    public class PersonalInfo
    {
        public string Name {get;set;}
        public string FatherName {get;set;}
        public string Mobile {get;set;}
        public string Mail {get;set;}
        public Gender Gender {get;set;}

        public PersonalInfo(string name,string fathername,string mobile,string mail,Gender gender)
        {
            Name = name;
            FatherName = fathername;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
        }

        public void UpdateInfo(string name,string fatherName,string mobile,string mail,Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail=mail;
            Gender = gender;
        }
        
    }
}