using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class AreaCalculator
    {
        public double Radius {get;set;}

        public AreaCalculator(double radius)
        {
            Radius = radius;
        }

        public virtual double Calculate()
        {
            double result = 3.14 * Radius*Radius;
            return result;
        }
        public virtual void Display()
        {
            System.Console.WriteLine($"Area : {Calculate()}");            
        }
    }
}