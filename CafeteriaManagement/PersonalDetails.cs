using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    
    public class PersonalDetails
    {
        public string Name { get; set;}
        
        public string FatherName{get;set;}
        public string MobileNumber{get;set;}
        public Gender Gender{get;set;}
        public string MailID{get;set;}

        public PersonalDetails(string name,string fatherName,string mobileNumber,string mailID,Gender gender)
        {
            Name = name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            Gender=gender;
            MailID = mailID;
        }
        
}
}