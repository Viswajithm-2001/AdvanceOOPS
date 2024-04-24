using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingQuestion
{
    public enum AccountType {Select,Savings,Balance}
    public class SavingAccount : IDInfo,ICalculate,IBankInfo
    {
        private double _balance;

        public double Balance{get{return _balance;}}
        public string BankName {get;set;}
        public string IFSC {get; set;}
        public string Branch {get;set;}
        public string AccountNumber { get; set; }
        public AccountType AccountType {get;set;}

        public SavingAccount(string name,Gender gender, DateTime dob,string phone,string mobile,string voterID,string aadharID,string panNumber,string bankname,string ifsc,string branch,string accountNumber,AccountType accountType,double balance)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            Mobile = mobile;
            VoterID = voterID;
            AadharID = aadharID;
            PANNumber = panNumber;
            BankName = bankname;
            IFSC = ifsc;
            Branch = branch;
            AccountNumber = accountNumber;
            AccountType = accountType;
            _balance = balance;
            
        }
        public void Deposit(double amount)
        {
            _balance+=amount;
        }
        public void Withdraw(double amount)
        {
            _balance-=amount;
        }

        public void BalanceCheck()
        {
            System.Console.WriteLine("Your Balance is : "+Balance);
        }

        
    }
}