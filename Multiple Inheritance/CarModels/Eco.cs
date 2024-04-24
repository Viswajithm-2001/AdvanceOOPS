using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModels
{
    public class Eco : Car,IBrand
    {
        private static int s_SID = 100;
        public string EcoID{get;}
        public int EngineNumber{get;set;}
        public int ChasisNumber{get;set;}

        public string BrandName{get;set;}
        public string ModelName{get;set;}


        public Eco(string brandName,string modelName,string fuelType,int numberOfSeats,string color,double tankCapacity,double numberOfKmDriven,int engineNumber,int chasisNumber) : base(fuelType,numberOfSeats,color,tankCapacity,numberOfKmDriven)
        {
            EcoID = "EID"+(++s_SID);
            BrandName = brandName;
            ModelName = modelName;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;

        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Here are the  EECO car details.....");
            System.Console.WriteLine($"ID : {EcoID}");
            System.Console.WriteLine($"Brand Name : {BrandName}");
            System.Console.WriteLine($"Model Name : {ModelName}");
            System.Console.WriteLine($"Fuel Type : {FuelType}");
            System.Console.WriteLine($"Number of Seats : {NumberOfSeats}");
            System.Console.WriteLine($"Color : {Color}");
            System.Console.WriteLine($"Tank Cpacity: {TankCapacity}");
            System.Console.WriteLine($"Number of kilometer driven: {NumberOfKmDriven}");
            System.Console.WriteLine($"Engine Number: {EngineNumber}");
            System.Console.WriteLine($"Chasis Number: {ChasisNumber}");
        }
    }
}