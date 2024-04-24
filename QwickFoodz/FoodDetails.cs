using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class FoodDetails
    {
        //Field
        private static int s_foodID = 2000;
        //Properties
        public string FoodID { get; }
        public string FoodName {get;set;}
        public double PricePerQuantity{get;set;}
        public int QuantityAvailable{get;set;}

        public FoodDetails(string foodName,double pricePerQuantity,int quantityAvailable)
        {
            s_foodID++;
            FoodID = "FID"+s_foodID;
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
            QuantityAvailable=quantityAvailable;
        }
    }
}