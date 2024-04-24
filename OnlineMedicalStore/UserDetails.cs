using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class UserDetails : PersonalDetails,IWallet
    {
        //Field
        //Private Static Field
        private static int s_userID = 1000;
        private double _balance;

        //Properties
        
        public string UserID { get;}
        public double WalletBalance {get{return _balance;}}

        public UserDetails(string name,int age,string city,string mobileNumber,double balance)
        {
            UserID = "UID"+(++s_userID);
            Name = name;
            Age = age;
            PhoneNumber=mobileNumber;
            _balance = balance;
            City = city;
        }
        public UserDetails(string userInfo)
        {
            string[] user = userInfo.Split(",");
            ++s_userID;
            UserID = user[0];
            Name = user[1];
            Age = int.Parse(user[2]);
            City = user[3];
            PhoneNumber = user[4];
            _balance = double.Parse(user[5]);

        }

        public void WalletRecharge(double amount)
        {
            _balance+=amount;
            System.Console.WriteLine("Recharge successfull !...");
        }
        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }
    }
}