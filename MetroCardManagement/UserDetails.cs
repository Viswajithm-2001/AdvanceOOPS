using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class UserDetails : PersonalDetails,IBalance
    {
        //field
        //Private fields
        private static int s_cardNumber = 1000;
        private double _balance;

        //Properties
        
        public string CardNumber {get;}
        public double Balance {get{return _balance;}}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName">Stores name of userinput for name</param>
        /// <param name="phoneNumber">stores userinput for Phone number </param>
        /// <param name="balance">stores userInput as double value</param> <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public UserDetails(string userName,string phoneNumber,double balance) : base (userName,phoneNumber)
        {
            s_cardNumber++;
            CardNumber = "CMRL"+s_cardNumber;
            _balance = balance;
        }
        public UserDetails(string userDetail)
        {
            string [] users = userDetail.Split(",");
            s_cardNumber = int.Parse(users[0].Remove(0,4));
            CardNumber = users[0];
            UserName = users[1];
            PhoneNumber = users[2];
            _balance = double.Parse(users[3]);
        }

        public void WalletRecharge(double amount)
        {
            _balance += amount;
            System.Console.WriteLine("Recharge successful !");
        }
        public void DeductBalance(double amount)
        {
            _balance -= amount;

        }

        
    }
}