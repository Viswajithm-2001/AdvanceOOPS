using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApplication
{
    public class FamilyInfo : PersonalInfo
    {
        //Properties
        public int NoOfSiblings { get; set;}
        public new string FatherName{get;set;}
        public string MotherName {get;set;}
        public string NativePlace { get; set; }

        public FamilyInfo(string name, string fatherName,string phoneNumber,string mailID,Gender gender,string motherName,string nativePlace,int noOfSiblings) : base(name, fatherName,phoneNumber,mailID, gender)
        {
            FatherName = fatherName;
            MotherName = motherName;
            NativePlace=nativePlace;
            NoOfSiblings = noOfSiblings;

        }

        public sealed override void Update()
        {
            //logic
        }
        public new void DisplayInfo()
        {
        System.Console.WriteLine($"Name : {Name}");
        System.Console.WriteLine($"Father Name : {FatherName}");
        System.Console.WriteLine($"Mother Name : {MotherName}");
        System.Console.WriteLine($"NoOfSiblings : {NoOfSiblings}");
        System.Console.WriteLine($"Native Place : {NativePlace}");
        System.Console.WriteLine($"Phone Number : {PhoneNumber}");
        System.Console.WriteLine($"Mail ID: {MailID}");
        System.Console.WriteLine($"Gender: {Gender}");

        }

    }
}