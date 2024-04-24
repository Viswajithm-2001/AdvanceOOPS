using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace CarQuestion
{
    public class MaruthiSwift : Car
    {
        public override void GetEngine()
        {
            Console.Write("Enter Engine Type (Petrol,diesel,cng) : ");
            EngineType = Enum.Parse<EngineType>(Console.ReadLine(),true);  
        }
        public override void GetNoOfSeats()
        {
            Console.Write("Enter No Of Seats : ");

            SeatCount = int.Parse(Console.ReadLine());
        }
        public override void GetPrice()
        {
            Console.Write("Enter price : ");
            Price = double.Parse(Console.ReadLine());
        }
        public override void GetCarType()
        {
            Console.Write("Enter Car Type (hatchback,sedan, suv): ");
            CarType = Enum.Parse<Cartype>(Console.ReadLine(),true);
        }

        public override void Display()
        {
            System.Console.WriteLine("Car Name : Maruti Swift");
            System.Console.WriteLine($"Engine Type : {EngineType}");
            System.Console.WriteLine($"Price : {Price}");
            System.Console.WriteLine($"Car Type : {CarType}");
            ShowWheels();
            ShowDoors();
        }
    }
}