using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVolume
{
    public class Cylinders : Shape
    {
        public override double Area{get; set;}
        public override double Volume{get; set;}

        public Cylinders(double radius,double height)
        {
            Radius = radius;
            Height = height;
        }
        public override void CalculateArea()
        {
            double tempArea = Radius+Height;
            Area = tempArea*(2*Math.PI*Radius);
            Area = Math.Round(Area,3);
        }
        public override void CalculateVolume()
        {
            Volume = Math.Round(Math.PI*Radius*Radius*Height,3);
        }
    }
}