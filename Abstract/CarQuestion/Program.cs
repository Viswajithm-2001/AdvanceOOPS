using System;
namespace CarQuestion;

class Program
{
    public static void Main(string[] args)
    {
        //creating object for marutiswft
        System.Console.WriteLine("----------------------------------");
        System.Console.WriteLine("Maruti car");
        MaruthiSwift maruti = new MaruthiSwift();
        maruti.GetEngine();
        maruti.GetNoOfSeats();
        maruti.GetPrice();
        maruti.GetCarType();
        maruti.Display();

        //creating object for suzuki ciaz
        System.Console.WriteLine("----------------------------------");
        System.Console.WriteLine("Suzki car");
        SuzukiCiaz ciaz = new SuzukiCiaz();
        ciaz.GetEngine();
        ciaz.GetNoOfSeats();
        ciaz.GetPrice();
        ciaz.GetCarType();
        ciaz.Display();
    }
}