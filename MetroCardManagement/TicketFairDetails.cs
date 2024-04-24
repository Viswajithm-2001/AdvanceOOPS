using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TicketFairDetails
    {
        //Field
        private static int s_ticketID = 3000;

        //Properties
        public string TicketID {get;}
        public string FromLocation {get;set;}
        public string ToLocation {get;set;}
        public double TicketPrice {get;set;}

        public TicketFairDetails(string fromLocation,string toLocation,double ticketPrice)
        {
            s_ticketID++;
            TicketID = "MR"+s_ticketID;
            FromLocation = fromLocation;
            ToLocation= toLocation;
            TicketPrice = ticketPrice;
        }

        public TicketFairDetails(string ticketDetails)
        {
            string [] ticketDetail = ticketDetails.Split(",");
            TicketID = ticketDetail[0];
            s_ticketID = int.Parse(ticketDetail[0].Remove(0,2));
            FromLocation = ticketDetail[1];
            ToLocation = ticketDetail[2];
            TicketPrice = double.Parse(ticketDetail[3]);
        }
    }
}