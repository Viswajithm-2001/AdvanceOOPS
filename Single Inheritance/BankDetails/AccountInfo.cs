using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetails
{
    public class AccountInfo : PersonalInfo
    {
        private double _balance;
        public long AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode {get; set;}
        public double Balance { get{return _balance;} set{_balance = value;} }

        public AccountInfo(string name,string fatherName,string phoneNumber,string mailID,DateTime dob,Gender gender,long accountNumber,string branchName,string ifscCode,double balance) : base(name, fatherName, phoneNumber, mailID, dob, gender)
        {
            AccountNumber = accountNumber;
            BranchName = branchName;
            IFSCCode = ifscCode;
            Balance = balance;
        }
        public void ShowAccountInfo()
        {
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Father Name : {FatherName}");
            System.Console.WriteLine($"PhoneNumber : {PhoneNumber}");
            System.Console.WriteLine($"Maile ID: {MailID}");
            System.Console.WriteLine($"Date of birth : {Dob}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Account Number: {AccountNumber}");
            System.Console.WriteLine($"BranchName: {BranchName}");
            System.Console.WriteLine($"IFSC code: {IFSCCode}");
            System.Console.WriteLine($"Balance : {Balance}");

        }
        public void Deposit(double amount)
        {
            _balance += amount;
            System.Console.WriteLine("Amount deposited successfully");
        }
        public void Withdraw(double amount)
        {
            _balance-=amount;
            System.Console.WriteLine("Amount Withdrawn successfully");

        }
        public void ShowBalance()
        {
            System.Console.WriteLine($"Your Balance now is {Balance}");
        }
    }
}