using System;
namespace Calculator;

class Program
{
    public static void Main(string[] args)
    {
        //Creating object for Volume Calculator
        VolumeCalculator volume = new VolumeCalculator(10,20.5);
        //creating object for Area Calculator
        AreaCalculator area = new AreaCalculator(20);

        System.Console.WriteLine("____________________________________");
        volume.Display();
        System.Console.WriteLine("____________________________________");
        area.Display();
        System.Console.WriteLine("____________________________________");
    }
}