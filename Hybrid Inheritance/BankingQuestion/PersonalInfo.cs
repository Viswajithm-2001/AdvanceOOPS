using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingQuestion
{
    public enum Gender {Select,Male,Female,Transgender}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender {get;set;}
        public DateTime DOB{get;set;}
        public string Phone{get;set;}
        public string Mobile {get; set;}

    }
}