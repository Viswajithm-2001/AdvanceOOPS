using System;
namespace CarModels;

class Program
{
    public static void Main(string[] args)
    {
        //creating 2 objects for ShiftDezire
        ShiftDezire shift1 = new ShiftDezire("Maruti","Swift","Petrol",4,"White",37.5,10000.7,123456,1234);
        ShiftDezire shift2 = new ShiftDezire("Maruti","Swift","Diesel",4,"Red",38.5,12000.12,78910,5678);
        //creating 2 objects for Eco
        Eco eco1 = new Eco("Maruti","Eeco","Petrol",4,"Sandal",62,10000,687954,1234);
        Eco eco2 = new Eco("Maruti","Eeco","Diesel",4,"Blue",40,30000,198237,1029);


        System.Console.WriteLine("_________________________________________________________________");
        shift1.ShowDetails();
        System.Console.WriteLine("_________________________________________________________________");
        shift2.ShowDetails();
        System.Console.WriteLine("_________________________________________________________________");
        eco1.ShowDetails();
        System.Console.WriteLine("_________________________________________________________________");
        eco2.ShowDetails();
        System.Console.WriteLine("_________________________________________________________________");

    }
}