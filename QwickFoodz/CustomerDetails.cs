using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails : PersonalDetails,IBalance
    {
        //Field
        private static int s_customerID = 1000;
        private double _balance;
        
        //Propeties
        public double WalletBalance{get{return _balance;}}
        public string CustomerID{get;}

        public CustomerDetails(double walletBalance,string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location)
        {
            s_customerID++;

            CustomerID = "CID"+s_customerID;
            _balance = walletBalance;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
            Location = location;
        }
        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }
        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }

        
    }
}