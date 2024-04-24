using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static partial class Operations
    {
        //lists for Storing
        static List<CustomerDetails> customerList = new List<CustomerDetails>();
        static List<FoodDetails> foodDetailsList = new List<FoodDetails>();
        static List<OrderDetails> orderDetailsList = new List<OrderDetails>();
        static List<ItemDetails> itemDetailsList = new List<ItemDetails>();

        public static void Default()
        {
            //Default for CustomerDetails Object
            CustomerDetails defaultCustomer1 = new CustomerDetails(10000,"Ravi","Ettaparajan",Gender.Male,"974774646",new DateTime(1999,11,11),"ravi@gmail.com","Chennai");
            CustomerDetails defaultCustomer2 = new CustomerDetails(15000,"Baskaran","Sethurajan",Gender.Male,"847575775",new DateTime(1999,11,11),"baskaran@gmail.com","Chennai");
            customerList.Add(defaultCustomer1);
            customerList.Add(defaultCustomer2);

            //FoodDetails Object
            FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg",100,12);
            FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg",150,10);
            FoodDetails food3 = new FoodDetails("Veg Full Meals",80,30);
            FoodDetails food4 = new FoodDetails("Noodles",100,40);
            FoodDetails food5 = new FoodDetails("Dosa",40,40);
            FoodDetails food6 = new FoodDetails("Idly (2 pieces)",20,50);
            FoodDetails food7 = new FoodDetails("Pongal",40,20);
            FoodDetails food8 = new FoodDetails("Vegetable Biriyani",80,15);
            FoodDetails food9 = new FoodDetails("Lemon Rice",50,310);
            FoodDetails food10 = new FoodDetails("Veg Pulav",120,30);
            FoodDetails food11 = new FoodDetails("Chicken 65(200 Grams)",75,30);
            foodDetailsList.AddRange(new List<FoodDetails>{food1,food2,food3,food4,food5,food6,food7,food8,food9,food10,food11});

            //OrderDetails
            OrderDetails order1 = new OrderDetails("CID1001",580,new DateTime(2022,11,26),OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID1001",580,new DateTime(2022,11,26),OrderStatus.Ordered);
            OrderDetails order3 = new OrderDetails("CID1001",580,new DateTime(2022,11,26),OrderStatus.Ordered);
            orderDetailsList.AddRange(new List<OrderDetails>{order1,order2,order3});
            
            //Item Details
            ItemDetails item1 = new ItemDetails("OID3001","FID2001",2,200);
            ItemDetails item2 = new ItemDetails("OID3001","FID2002",2,300);
            ItemDetails item3 = new ItemDetails("OID3001","FID2003",1,80);
            ItemDetails item4 = new ItemDetails("OID3002","FID2001",1,100);
            ItemDetails item5 = new ItemDetails("OID3002","FID2002",4,600);
            ItemDetails item6 = new ItemDetails("OID3002","FID2010",1,120);
            ItemDetails item7 = new ItemDetails("OID3002","FID2009",1,50);
            ItemDetails item8 = new ItemDetails("OID3003","FID2002",2,300);
            ItemDetails item9 = new ItemDetails("OID3003","FID2008",4,2320);
            ItemDetails item10 = new ItemDetails("OID3003","FID2001",2,200);
            itemDetailsList.AddRange(new List<ItemDetails>{item1,item2,item3,item4,item5,item6,item7,item8,item9,item10});

        }
    }
}