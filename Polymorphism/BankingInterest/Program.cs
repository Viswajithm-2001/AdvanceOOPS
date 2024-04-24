using System;
namespace BankingInterest;

class Program
{
    public static void Main(string[] args)
    {
        SBI sbi = new SBI();
        ICICI icici = new ICICI();
        HDFC hdfc = new HDFC();
        IDBI idbi = new IDBI();

        System.Console.WriteLine($"SBI Interest  : {sbi.GetIntrestInfo}");
        System.Console.WriteLine($"ICICI Interest  : {icici.GetIntrestInfo}");
        System.Console.WriteLine($"HDFC Interest  : {hdfc.GetIntrestInfo}");
        System.Console.WriteLine($"IDBI Interest  : {idbi.GetIntrestInfo}");
    }
}