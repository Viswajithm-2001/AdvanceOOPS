using System;
namespace CalculatorApp;

class Program
{
    public static void Main(string[] args)
    {
        CylinderVolume cylinder = new CylinderVolume(20,30);//radius,height
        cylinder.CalculateVolume();
        
    }
}