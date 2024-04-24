using System;
namespace CalculateSquare;

class Program
{
    public static void Main(string[] args)
    {
        //Creating Onject for calculate class
        Calculate calculate = new Calculate();
        
        //Square value for
        System.Console.WriteLine("  "+calculate.Square(10));
        System.Console.WriteLine("  "+calculate.Square(10.3f));
        System.Console.WriteLine("  "+calculate.Square(10.593));
        System.Console.WriteLine("  "+calculate.Square(123456789019));
    }
}