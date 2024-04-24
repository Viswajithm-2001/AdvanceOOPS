using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public int Mark5 { get; set; }
        public int Mark6 { get; set; }


        public Calculator(int mark1,int mark2,int mark3,int mark4,int mark5,int mark6)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Mark4 = mark4;
            Mark5 = mark5;
            Mark6 = mark6;
        }
        public void Calculate()
        {
            int total = Mark1+Mark2+Mark3+Mark4+Mark5+Mark6;
            double percent = (double)total/6;
            System.Console.WriteLine($"Total : {total}");
            System.Console.WriteLine($"Percent : {percent}");
        }
        public static Calculator operator + (Calculator cal1,Calculator cal2)
        {
            int tempMark1 = cal1.Mark1+cal2.Mark1;
            int tempMark2 = cal1.Mark2+cal2.Mark2;
            int tempMark3 = cal1.Mark3+cal2.Mark3;
            int tempMark4 = cal1.Mark4+cal2.Mark4;
            int tempMark5 = cal1.Mark5+cal2.Mark5;
            int tempMark6 = cal1.Mark6+cal2.Mark6;

            return new Calculator(tempMark1,tempMark2,tempMark3,tempMark4,tempMark5,tempMark6);
        }
    }
}