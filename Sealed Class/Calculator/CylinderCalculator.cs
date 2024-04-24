using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class CylinderCalculator : Calculator
    {
        public override void Area()
        {
            double radius = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            System.Console.WriteLine((2*3.14*radius*height)+2*3.14*radius*radius); 
        }
        public new void Volume()
        {
            double radius = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            System.Console.WriteLine(3.14*radius*radius*height); 
        }

    }
}