using System;
namespace BankingQuestion;

class Program
{
    public static void Main(string[] args)
    {
        //Object for 2 persons
        SavingAccount account1 = new SavingAccount("person1",Gender.Male,new DateTime(1999,10,10),"044-54321","+91987654321","QWS00587321","94012837091242","PANNU9876P","HDFC","HDFC0000575","MainBranch","84932876487264",AccountType.Savings,20000);
        SavingAccount account2 = new SavingAccount("person2",Gender.Female,new DateTime(1999,11,11),"044-09876","+91987654322","POP00587321","94012837091242","LOGB9676A","SBI","SBI0000797","SUBBranch","8039864765923",AccountType.Balance,30000);
        
        //Methods
        //For person1
        System.Console.WriteLine("----------------------------------------------------");
        System.Console.WriteLine($"For {account1.Name}");
        account1.Deposit(1000);
        account1.BalanceCheck();
        account1.Withdraw(3000);
        account1.BalanceCheck();
        //For person 2
        System.Console.WriteLine("----------------------------------------------------");
        System.Console.WriteLine($"For {account2.Name}");
        account2.Deposit(500);
        account2.BalanceCheck();
        account2.Withdraw(2000);
        account2.BalanceCheck();

    }
}