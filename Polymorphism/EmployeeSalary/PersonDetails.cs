using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public enum Gender { select, Male, Female }
    public class PersonDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }

        public PersonDetails(string name,string fatherName,string phoneNumber,Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }
        
    }
}