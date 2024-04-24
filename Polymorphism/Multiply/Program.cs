using System;
namespace Multiply;

class Program
{
    public static void Main(string[] args)
    {
        Multiplication mul = new Multiplication();
        //Method with one argument and display the Square value of a given number.
        System.Console.WriteLine("Method with one argument and display the Square value of a given number.");
        mul.Multiply(5);
        //Method with 2 arguments with same argument type and display result.
        System.Console.WriteLine("Method with 2 arguments with same argument type and display result");
        mul.Multiply(5,10);
        //Method with 3 arguments with same argument type and display the result.
        System.Console.WriteLine("Method with 3 arguments with same argument type and display the result.");
        mul.Multiply(5,5,5);
        //Method with 2 arguments with different argument type and display result.
        System.Console.WriteLine("Method with 2 arguments with different argument type and display result.");
        mul.Multiply(5,5.5);
        //Method with 3 arguments with different argument type and display the result.
        System.Console.WriteLine("Method with 3 arguments with different argument type and display the result.");
        mul.Multiply(5,5.5,5.5f);
    }
}