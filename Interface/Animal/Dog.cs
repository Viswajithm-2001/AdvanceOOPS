using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal
{
    public class Dog : IAnimal
    {

        //Properties
        public string Name{get;set;}
        public string Habitat{get;set;}
        public string EatingHabit{get;set;}

        //Constructor
        public Dog(string name,string habitat,string eatinghabit)
        {
            Name = name;
            Habitat =habitat;
            EatingHabit = eatinghabit;
        }
        public void DisplayName()
        {
            System.Console.WriteLine($"Hi I am Dog and My name is {Name}");
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Habitat : {Habitat}");
            System.Console.WriteLine($"Eating Habitat : {EatingHabit}");
        }
        
    }
}