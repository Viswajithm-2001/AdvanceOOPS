using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarQuestion
{
    public enum EngineType {Petrol,Diesel,CNG}
    public enum Cartype {Hatchback,Sedan, SUV}
    public abstract class Car
    {
        private int _wheelCount = 4;
        private int _doorCount = 4;

        public EngineType EngineType { get; set; }
        public Cartype CarType{get;set;}
        public int SeatCount{get;set;}
        public double Price {get;set;}
        public void ShowWheels()
        {
            Console.WriteLine("Number of wheels : "+_wheelCount);
        }
        public void ShowDoors()
        {
            Console.WriteLine("Number of Doors : "+_doorCount);
        }
        public abstract void GetEngine();
        public abstract void GetNoOfSeats();
        public abstract void GetCarType();
        public abstract void GetPrice();
        public abstract void Display();
    }
}