using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public enum Gender {Select, Male, Female, Transgender}
    public class UserDetails
    {
        /*a.	Username
        userID 3000
        b.	Gender (Enum – Select, Male, Female, Transgender)
        c.	Department  
        d.	MobileNumber
        e.	MailID
        f.	WalletBalance
        */
        //Field
        //static field
        private static int s_userID = 3000;
        //properties
        public string UserID{get;}
        public string Username { get; set; }
        public string  Department{get;set;}
        public Gender Gender{get; set;}
        public long MobileNumber{get;set;}
        public string MailID{get;set;}
        public double WalletBalance{get;set;}
        public int BorrowCount;

        public UserDetails(string userName,Gender gender,string department,long mobileNumber,string mailId,double walletBalance)
        {
            s_userID++;
            UserID = "SF"+(s_userID);
            Username = userName;
            Gender=gender;
            department = Department;
            MobileNumber=mobileNumber;
            MailID=mailId;
            WalletBalance=walletBalance;
            BorrowCount = 0;
        }
    }
}