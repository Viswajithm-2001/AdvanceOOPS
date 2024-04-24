using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocerySTore
{
    public class OrderDetails
    {
        private static int s_orderID = 100;
        public string OrderID{get;}
        public string BookingID{get;set;}
        public string ProductID{get;set;}
        public double PriceOfOrder{get;set;}
        public int PurchaseCount{get;set;}
        public OrderDetails(string bookingID, string productID, int purchaseCount,double priceOfOrder)
        {
            OrderID = "OID"+(++s_orderID);
            BookingID = bookingID;
            ProductID = productID;
            PriceOfOrder = priceOfOrder;
            PurchaseCount = purchaseCount;
        }
    }
}