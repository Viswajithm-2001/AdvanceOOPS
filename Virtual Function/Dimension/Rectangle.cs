using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dimension
{
    public class Rectangle:Dimention
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(double length,double height) : base(length,height)
        {
            Length = length;
            Height = height;
        }
        public override double Calculate()
        {
            return base.Calculate();
        }
        public override void Display()
        {
            System.Console.WriteLine($"Area of Rectangle : {Calculate()}");
        }

    }
}