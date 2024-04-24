using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static partial class Operations
    {
        public static void DefaultDetails()
        {
            //Default for userdetails
            UserDetails user1 = new UserDetails("Ravi","9848812345",1000);
            UserDetails user2 = new UserDetails("Baskaran","994884321",1000);
            userList.Add(user1);
            userList.Add(user2);

            
            //Default Ticket fair Details
            TicketFairDetails ticket1 = new TicketFairDetails("Airport","Egmore",55);
            TicketFairDetails ticket2 = new TicketFairDetails("Airport","Koyambedu",25);
            TicketFairDetails ticket3 = new TicketFairDetails("Alandur","Koyambedu",25);
            TicketFairDetails ticket4 = new TicketFairDetails("Koyambedu","Egmore",32);
            TicketFairDetails ticket5 = new TicketFairDetails("Vadapalani","Egmore",45);
            TicketFairDetails ticket6 = new TicketFairDetails("Arumbakkam","Egmore",25);
            TicketFairDetails ticket7 = new TicketFairDetails("Vadapalani","Koyambedu",25);
            TicketFairDetails ticket8 = new TicketFairDetails("Arumbakkam","Koyambedu",16);
            //adding all in ticketList
            ticketFairList.AddRange(new CustomList<TicketFairDetails>{ticket1,ticket2,ticket3,ticket4,ticket5,ticket6,ticket7,ticket8});


            //Default Travel History Details
            TravelDetails travel1 = new TravelDetails(user1.CardNumber,"Airport","Egmore",new DateTime(2023,10,10),55);
            TravelDetails travel2 = new TravelDetails("CMRL1001","Egmore","Koyambedu",new DateTime(2023,10,10),32);
            TravelDetails travel3 = new TravelDetails("CMRL1002","Alandur","Koyambedu",new DateTime(2023,11,10),25);
            TravelDetails travel4 = new TravelDetails("CMRL1003","Egmore","Thirumanagalam",new DateTime(2023,11,10),25);
            //adding all in travellist
            travelHistoryList.AddRange(new CustomList<TravelDetails>{travel1,travel2,travel3,travel4});

            
        }
    }
}