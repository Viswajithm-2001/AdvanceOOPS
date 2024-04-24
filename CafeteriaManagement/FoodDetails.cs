using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class FoodDetails
    {
        private static int s_foodID = 100;
        public string FoodID{get;}
        public string Foodname{get;set;}
        public double FoodPrice{get;set;}
        public int AvailableQuantity{get;set;}

        public FoodDetails(string foodName,double foodPrice,int quantity)
        {
            FoodID = "FID"+(++s_foodID);
            Foodname = foodName;
            FoodPrice = foodPrice;
            AvailableQuantity = quantity;
        }
        
    }
}