using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public enum OrderStatus {Default,Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        //Field
        private static int s_orderID = 3000;
        
        //Property
        public string OrderID {get;}
        public string CustomerID{get;set;}
        public double TotalPrice{get;set;}
        public DateTime DateOfOrder {get;set;}
        public OrderStatus OrderStatus{get;set;}

        public OrderDetails(string customerID,double totalPrice,DateTime dateOfOrder,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID = "OID"+s_orderID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
            OrderStatus = orderStatus;
        }
    }
}