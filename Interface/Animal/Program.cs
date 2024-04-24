using System;
namespace Animal;

class Program
{
    public static void Main(string[] args)
    {
        //object for Dogs
        Dog dog1 = new Dog("Bob","Barking","Meat");
        Dog dog2 = new Dog("Spike","Eating","Dog food");

        //object for Ducks
        Duck duck1 = new Duck("Quacker","Quacking","Algae");
        Duck duck2 = new Duck("Howard the duck","Swimming","Tadpoles");

        Console.WriteLine("-____________________________________-");
        Console.WriteLine("Dog1 displays...");
        dog1.DisplayName();
        dog1.DisplayInfo();
        Console.WriteLine("Dog2 displays...");
        dog2.DisplayName();
        dog2.DisplayInfo();
        Console.WriteLine("-____________________________________-");
        Console.WriteLine("Duck1 displays...");
        duck1.DisplayName();
        duck1.DisplayInfo();
        Console.WriteLine("Duck2 displays...");
        duck2.DisplayName();
        duck2.DisplayInfo();
    }
}