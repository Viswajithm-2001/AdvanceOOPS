using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Calculator
{
    public class CircleCalculator : Calculator
    {
        public sealed override void Area()
        {
            double radius = double.Parse(Console.ReadLine());
            System.Console.WriteLine(3.14*radius*radius); 
        }
        
    }
}