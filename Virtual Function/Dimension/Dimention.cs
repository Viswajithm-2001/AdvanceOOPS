using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dimension
{
    public class Dimention
    {
        public double Value1{get;set;}
        public double Value2{get;set;}

        public double Area{get;set;}
        public Dimention(double value)
        {
            Value1 = value;
            Value2= value;
        }

        public Dimention(double value1,double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public virtual double Calculate()
        {
            double result = Value1*Value2;
            return result;
        }

        public virtual void Display()
        {
            System.Console.WriteLine($"Area : {Calculate()}");
        }
    }
}