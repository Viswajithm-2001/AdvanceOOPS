using System;
namespace BankDetails;

class Program
{
    public static void Main(string[] args)
    {
        AccountInfo account1 = new AccountInfo("User1","User1'sFather","+919876543210","user1@email.com",new DateTime(2000,11,02),Gender.Male,1234567890,"Mylapore","hdfc0000678",0);
        AccountInfo account2 = new AccountInfo("User2","User2'sFather","+919876543211","user2@email.com",new DateTime(2001,11,02),Gender.Female,1234567891,"Kilpauk","hdfc0000672",0);
        AccountInfo account3 = new AccountInfo("User3","User3'sFather","+919876543212","user30@email.com",new DateTime(2002,11,02),Gender.Select,1234567892,"Mambalam","hdfc0000666",0);

        account1.ShowAccountInfo();
        account2.ShowAccountInfo();
        account3.ShowAccountInfo();

        account1.Deposit(455.50);
        account2.Deposit(1000.00);
        account3.Deposit(1000.00);

        account1.Withdraw(50);
        account2.Withdraw(100);
        account3.Withdraw(100.50);

        account1.ShowBalance();
        account2.ShowBalance();
        account3.ShowBalance();



    }
}