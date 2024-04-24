using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApplication
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName {get;set;}
        public string PhoneNumber {get; set;}
        public string MailID {get; set;}
        public Gender Gender {get; set;}

        public PersonalInfo(string name, string fatherName,string phoneNumber,string mailID,Gender gender)
        {
            Name = name;
            FatherName= fatherName;
            PhoneNumber=phoneNumber;
            MailID=mailID.ToLower();
            Gender=gender;
        }
        public virtual void Update()
        {
        }
        public void DisplayInfo()
        {
        System.Console.WriteLine($"Name : {Name}");
        System.Console.WriteLine($"Father Name : {FatherName}");
        System.Console.WriteLine($"Phone Number : {PhoneNumber}");
        System.Console.WriteLine($"Mail ID: {MailID}");
        System.Console.WriteLine($"Gender: {Gender}");

        }

    }
}