using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static class FileHandling
    {
        //Create
        public static void Create()
        {
            //creating folder
            if(!Directory.Exists("MetroDetails"))
            {
                Directory.CreateDirectory("MetroDetails");
                System.Console.WriteLine("folder created successfully..");
            }
            //creating CSV files
            //Creating Userdetail csv.
            if(!File.Exists("MetroDetails/UserDetails.csv"))
            {
                File.Create("MetroDetails/UserDetails.csv").Close();
            }

            //Creating Ticket fair Details
            if(!File.Exists("MetroDetails/TicketFair.csv"))
            {
                File.Create("MetroDetails/TicketFair.csv").Close();
            }
            //Creating Travel HistoryDetails
            if(!File.Exists("MetroDetails/TravelHistory.csv"))
            {
                File.Create("MetroDetails/TravelHistory.csv").Close();
            }
        }
        
        //Readfromcsv
        public static void ReadFromCsv()
        {
            //UserDetails
            string [] userDetails = File.ReadAllLines("MetroDetails/UserDetails.csv");
            foreach(string user in userDetails)
            {
                UserDetails user1 = new UserDetails(user);
                Operations.userList.Add(user1);
            }

            //TravelHistory
            string[] travelHistories = File.ReadAllLines("MetroDetails/TravelHistory.csv");
            foreach(string travels in travelHistories)
            {
                TravelDetails travel1 = new TravelDetails(travels);
                Operations.travelHistoryList.Add(travel1);
            }
            
            //ticket Fair details
            string[] ticketFairDetails = File.ReadAllLines("MetroDetails/TicketFair.csv");
            foreach(string ticket in ticketFairDetails)
            {
                TicketFairDetails ticket1 = new TicketFairDetails(ticket);
                Operations.ticketFairList.Add(ticket1);
            }

        }
        
        //writetocsv
        public static void WriteToCsv()
        {
            //UserDetails
            string []userDetails = new string[Operations.userList.Count];
            int i=0;
            string userdetail;
            foreach(UserDetails user in Operations.userList)
            {
                userdetail = $"{user.CardNumber},{user.UserName},{user.PhoneNumber},{user.Balance}";
                userDetails[i]=userdetail;
                i++;
            }
            File.WriteAllLines("MetroDetails/UserDetails.csv",userDetails);
            
            //TravelHistory
            string []travelHistory = new string[Operations.travelHistoryList.Count];
            i=0;
            string travelDetail;
            foreach(TravelDetails travel in Operations.travelHistoryList)
            {
                travelDetail = $"{travel.TravelID},{travel.CardNumber},{travel.FromLocation},{travel.ToLocation},{travel.Date.ToString("dd/MM/yyyy")},{travel.TravelCost}";
                travelHistory[i]=travelDetail;
                i++;
            }
            File.WriteAllLines("MetroDetails/TravelHistory.csv",travelHistory);

            //TicketFair
            string[]ticketfair = new string[Operations.ticketFairList.Count];
            i=0;
            string ticketDetails;
            foreach(TicketFairDetails ticket in Operations.ticketFairList)
            {
                ticketDetails = $"{ticket.TicketID},{ticket.FromLocation},{ticket.ToLocation},{ticket.TicketPrice}";
                ticketfair[i]=ticketDetails;
                i++;
            }
            File.WriteAllLines("MetroDetails/TicketFair.csv",ticketfair);

        }
    }
}