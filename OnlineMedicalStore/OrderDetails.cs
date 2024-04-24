using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderID = 2000;
        public string OrderID {get;}
        public string UserID{get;set;}
        public string MedicineID{get;set;}
        public int MedicineCount { get; set; }
        public DateTime OrderDate{get;set;}
        public double TotalPrice{get;set;}
        public OrderStatus OrderStatus {get;set;}

        public OrderDetails(string userID,string medicineID,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus orderStatus)
        {
            OrderID = "OID"+(++s_orderID);
            UserID = userID;
            MedicineID =  medicineID;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
        public OrderDetails(string order1)
        {
            ++s_orderID;
            string[] order = order1.Split(",");
            OrderID = order[0];
            UserID = order[1];
            MedicineID = order[2];
            MedicineCount = int.Parse(order[3]);
            TotalPrice = double.Parse(order[4]);
            OrderDate = DateTime.ParseExact(order[5],"dd/MM/yyyy",null);
            OrderStatus = Enum.Parse<OrderStatus>(order[6],true);
        }

    }
}