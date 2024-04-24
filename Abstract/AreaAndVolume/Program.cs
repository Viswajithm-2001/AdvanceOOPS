using System;
namespace AreaAndVolume;

class Program
{
    public static void Main(string[] args)
    {
        //Cylinder object creation
        Cylinders cylinder = new Cylinders(20,10);
        cylinder.CalculateArea();
        cylinder.CalculateVolume();
        System.Console.WriteLine($"Area of Cylinder : {cylinder.Area}\nVolume of Cylinder : {cylinder.Volume}");

        //Cube object creation
        Cubes cube = new Cubes(20);
        cube.CalculateArea();
        cube.CalculateVolume();
        System.Console.WriteLine($"Area of Cube : {cube.Area}\nVolume of Cube : {cube.Volume}");
    }
}