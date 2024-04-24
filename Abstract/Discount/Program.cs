using System;

namespace Discount;
class Program 
{
    public static void Main(string[] args)
    {
        //object for Ladies wear
        System.Console.WriteLine("__________________________________");
        System.Console.WriteLine("Ladies wear");
        LadiesWear lady = new LadiesWear();
        lady.GetDressInfo();
        lady.DisplayInfo();

        //object for Ladies wear
        System.Console.WriteLine("__________________________________");
        System.Console.WriteLine("Mens wear");
        LadiesWear men = new LadiesWear();
        men.GetDressInfo();
        men.DisplayInfo();

    }
}