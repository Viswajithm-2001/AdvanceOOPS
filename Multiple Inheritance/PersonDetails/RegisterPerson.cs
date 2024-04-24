using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonDetails
{
    public class RegisterPerson : PersonalInfo,IShowData,IFamilyInfo
    {
        private static int _registerNumber =1000;
        public string RegisterNumber{get;set;}
        public DateTime DateOfRegistration{get;set;}
        public string FatherName{get;set;}
        public string MotherName{get;set;}
        public string HouseAddress{get;set;}
        public int NoOfSiblings{get;set;}

        public RegisterPerson(string name,Gender gender,DateTime dob,string mobileNumber,MaritalStatus marital,string fatherName,string motherName,string houseAddress,int siblings, DateTime registration) : base(name,gender,dob,mobileNumber,marital)
        {
            RegisterNumber = ""+(++_registerNumber);
            Name = name;
            Gender = gender;
            Dob = dob;
            MobileNumber = mobileNumber;
            MaritalStatus = marital;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NoOfSiblings = siblings;
            DateOfRegistration = registration;
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine($"Father Name : {FatherName}");
            System.Console.WriteLine($"Mother Name : {MotherName}");
            System.Console.WriteLine($"House Address : {HouseAddress}");
            System.Console.WriteLine($"Number of Siblings : {NoOfSiblings}");
            System.Console.WriteLine($"Date of registration : {DateOfRegistration.ToString("dd/MM/yyyy")}");
        }
        
    }
}