using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class VolumeCalculator : AreaCalculator
    {
        public double Height{get;set;}

        public VolumeCalculator(double radius,double height): base(radius)
        {
            Height = height;
        }

        public override double Calculate()
        {
            return base.Calculate()*Height;
        }
        public override void Display()
        {
            System.Console.WriteLine($"Volume : {Calculate()}");
        }

    }
}