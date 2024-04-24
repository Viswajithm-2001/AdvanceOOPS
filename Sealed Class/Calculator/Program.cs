using System;
namespace Calculator;

class Program
{
    public static void Main(string[] args)
    {
        CircleCalculator circle = new CircleCalculator();
        circle.Area();

        CylinderCalculator cylinder = new CylinderCalculator();
        cylinder.Area();
        cylinder.Volume();
    }
}