using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal
{
    public class Duck : IAnimal
    {
        public string Name{get;set;}
        public string Habitat{get;set;}
        public string EatingHabit{get;set;}
        public Duck(string name,string habitat,string eatingHabit)
        {
            Name = name;
            Habitat = habitat;
            EatingHabit = eatingHabit;
        }
        public void DisplayName()
        {
            System.Console.WriteLine($"Hi I am Duck and My name is {Name}");
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Habitat : {Habitat}");
            System.Console.WriteLine($"Eating habit : {EatingHabit}");

        }

    }
}