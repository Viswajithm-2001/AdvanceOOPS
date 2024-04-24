using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksheet
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
        public long RegistrationNumber{get;set;}
        public string Name {get;set;}
        public string Fathername {get;set;}
        public string PhoneNumber {get;set;}
        public DateTime Dob {get;set;}
        public Gender Gender {get;set;}

        public PersonalInfo(long registrationNumber,string name,string fathername,string phoneNumber,DateTime dob,Gender gender)
        {
            RegistrationNumber = registrationNumber;
            Name = name;
            Fathername = fathername;
            PhoneNumber = phoneNumber;
            Dob = dob;
            Gender = gender;
        }

        
    }
}