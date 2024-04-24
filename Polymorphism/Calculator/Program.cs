using System;
namespace Calculator;

class Program
{
    public static void Main(string[] args)
    {
        Calculator sem1 = new Calculator(90,91,92,93,94,95);
        Calculator sem2 = new Calculator(87,95,90,97,94,85);
        Calculator sem3 = new Calculator(90,81,82,93,94,75);
        Calculator sem4 = new Calculator(70,96,97,87,90,92);

        Calculator total = sem1+sem2+sem3+sem4;

        total.Calculate();
    }
}