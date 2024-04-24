using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dimension
{
    public class Sphere : Dimention
    {
        public double Radius{get;set;}
        public Sphere(double radius): base (radius)
        {
            Radius = radius;
        }
        public override double Calculate()
        {
            return base.Calculate()*4*3.14;
        }
        public override void Display()
        {
            System.Console.WriteLine($"Area of Sphere : {Calculate()}");
        }
    }
}