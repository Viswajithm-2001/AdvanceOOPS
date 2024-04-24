using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocerySTore
{

    public class CustomerDetails : PersonalDetails,IBalance
    {
        //Field
        private static int s_customerID = 100;
        //Properties
        public string CustomerID { get; }
        public double WalletBalance{get;set;}


        public CustomerDetails(double balance,string name, string fatherName, Gender gender, string mobileNumber, DateTime dob, string mailID)
        {
            CustomerID = "CID" + (++s_customerID);
            WalletBalance = balance;
            Name = name;
            FatherName = fatherName;
            MailID = mailID;
            MobileNumber = mobileNumber;
            Gender = gender;
            DOB = dob;
        }
        public void WalletRecharge(double amount)
        {
            WalletBalance+=amount;
            System.Console.WriteLine("Recharge successfull !...");
        }
    }
}