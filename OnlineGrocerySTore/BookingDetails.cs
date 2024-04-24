using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocerySTore
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID = 3000;
        public string BookingID {get;}
        public string CustomerID{get;set;}
        public DateTime BookingDate{get;set;}
        public double TotalPrice{get;set;}
        public BookingStatus BookingStatus {get;set;}

        public BookingDetails(string customerID,double totalPrice,DateTime bookingDate,BookingStatus bookingStatus)
        {
            BookingID = "BID"+(++s_bookingID);
            CustomerID = customerID;
            BookingDate = bookingDate;
            TotalPrice = totalPrice;
            BookingStatus = bookingStatus;
        }

    }
}