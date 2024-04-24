using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocerySTore
{
    public class ProductDetails
    {
        private static int s_productID = 2000;
        public string ProductID{get;}
        public string Productname{get;set;}
        public double Price{get;set;}
        public int AvailableQuantity{get;set;}

        public ProductDetails(string productname,double price,int quantity)
        {
            ProductID = "PID"+(++s_productID);
            Productname = productname;
            Price = price;
            AvailableQuantity = quantity;
        }
    }
}