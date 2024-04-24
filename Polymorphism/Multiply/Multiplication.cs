using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiply
{
    public class Multiplication
    {

        //Method with one argument and display the Square value of a given number.
        public void Multiply(int number)
        {
            int result = number*number;
            System.Console.WriteLine($"Square of the number is : {result}");
        }


        //Method with 2 arguments with same argument type and display result.
        public void Multiply(int number1,int number2)
        {
            int result = number1*number2;
            System.Console.WriteLine($"Multiplication of the numbers are : {result}");
        }

        //Method with 3 arguments with same argument type and display the result.
        public void Multiply(int number1,int number2,int number3)
        {
            int result = number1*number2*number3;
            System.Console.WriteLine($"Multiplication of the numbers are {result}");

        }


        //Method with 2 arguments with different argument type and display result.
        public void Multiply(int number1,double number2)
        {
            double result = number1*number2;
            System.Console.WriteLine($"Multiplications of the numbers are {result}");

        }


        //Method with 3 arguments with different argument type and display the result.
        public void Multiply(int number1,double number2,float number3)
        {
            double result = number1*number2*number3;
            System.Console.WriteLine($"Multiplications of the numbers are {result}");

        }
    }
}