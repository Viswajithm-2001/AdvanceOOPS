using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public enum Gender{Select,Male,Female}
    public class UserDetails : PersonalDetails,IBalance
    {
        //Field
        //Private Static Field
        private static int s_userID = 1000;
        private double _balance;

        //Properties
        public string UserID { get;}
        public string WorkStation {get;set;}
        public double WalletBalance {get{return _balance;}}

        public UserDetails(string name,string fatherName,string mobileNumber,string mailID,Gender gender,string workstation,double balance): base(name,fatherName, mobileNumber,mailID,gender)
        {
            UserID = "SF"+(++s_userID);
            Name = name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            Gender=gender;
            WorkStation = workstation;
            _balance = balance;
        }

        public void WalletRecharge(double amount)
        {
            _balance+=amount;
            System.Console.WriteLine("Recharge successfull !...");
        }
        public void DeductAmount(double amount)
        {
            _balance-=amount;
        }
    }
}