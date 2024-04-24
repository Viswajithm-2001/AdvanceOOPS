using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected double radius;
        public double Radius{get{return radius;}}
        internal double Area{get;set;}

        public CircleArea(double radious)
        {
            radius = radious;
        }

        public double CalculateCircleArea()
        {
            Area = PI * (Radius*Radius);
            return Area;
        }
    }
}