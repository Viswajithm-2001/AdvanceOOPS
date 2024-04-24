using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static partial class Operations
    {
        //Creating submenu for login
        static void SubMenu()
        {
            System.Console.WriteLine("You have successfully logged in");
            string subMenuChoice = "no";
            do
            {
                System.Console.WriteLine("Enter \n1. Balance Check\n2. Recharge\n3. View Travel History\n4. Travel\n5. Exit");
                Console.Write("Enter your option : ");
                int subOption = int.Parse(Console.ReadLine());
                switch(subOption)
                {
                    case 1:
                    {
                        //Balance check
                        BalanceCheck();
                        break;
                    }
                    case 2:
                    {
                        //Recharge
                        Recharge();
                        break;
                    }
                    case 3:
                    {
                        //View Travel History
                        ViewTravelHistory();
                        break;
                    }
                    case 4:
                    {
                        //Travel
                        Travel();
                        break;
                    }
                    case 5:
                    {
                        System.Console.Write("Do you want to exit (yes/no) : ");
                        subMenuChoice = Console.ReadLine().ToLower();
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Option.....");
                        break;
                    }
                } 

            }while(subMenuChoice!="yes");
        }

        static void BalanceCheck()
        {
            Console.Write("Do you want to check balance (yes/no) :");
            string choice = Console.ReadLine().ToLower();
            if(choice.Equals("yes"))
            {
                System.Console.WriteLine($"Your Balance amount Now is : {currentLoggedInUser.Balance}");
            }

        }
        static void Recharge()
        {
            System.Console.Write("Do you want to Recharge (yes/no): ");
            string choice = Console.ReadLine().ToLower();
            if(choice.Equals("yes"))
            {
                Console.Write("Enter the amount that you want to recharge : ");
                double amount = double.Parse(Console.ReadLine());
                currentLoggedInUser.WalletRecharge(amount);
            }

        } 
        static void ViewTravelHistory()
        {
            //for counting the number of travels if  count =0 then show nothing
            int count =0;
            foreach(TravelDetails travel in travelHistoryList)
            {
                if(travel.CardNumber.Equals(currentLoggedInUser.CardNumber))
                {
                    count+=1;
                }
            }
            if(count>0)
            {
                System.Console.WriteLine("TravelID   CardNumber   FromLocation    ToLocation   Date     TravelCost");
                foreach(TravelDetails travel in travelHistoryList)
                {
                    if(travel.CardNumber.Equals(currentLoggedInUser.CardNumber))
                    {
                        System.Console.WriteLine($"{travel.TravelID,-12}{travel.CardNumber,-12}{travel.FromLocation,-12}    {travel.ToLocation,-12}{travel.Date.ToString("dd/MM/yyyy"),-12}{travel.TravelCost,-12}");
                    }
                }
            }
            else
            {
                System.Console.WriteLine("No Travel History.....");
            }
        }
        
        static void Travel()
        {
            System.Console.WriteLine("Welcome where do you wanna travel....");
            System.Console.WriteLine("TicketID  FromLocation    ToLocation  Fair");
            foreach(TicketFairDetails ticket in ticketFairList)
            {
                System.Console.WriteLine($"{ticket.TicketID,-10}|{ticket.FromLocation,-10}|{ticket.ToLocation,-12}|{ticket.TicketPrice}");
            }
            System.Console.Write("Enter ticket ID to continue : ");
            string ticketID = Console.ReadLine().ToUpper();
            bool ticketFlag = false;
            foreach(TicketFairDetails ticketFair in ticketFairList)
            {
                if(ticketFair.TicketID.Equals(ticketID))
                {
                    if(currentLoggedInUser.Balance>=ticketFair.TicketPrice)
                    {
                        ticketFlag = true;
                        System.Console.WriteLine("Do you want to confirm payment (yes/no) : ");
                        string wishChoice = Console.ReadLine().ToLower();
                        if(wishChoice.Equals("yes"))
                        {
                            currentLoggedInUser.DeductBalance(ticketFair.TicketPrice);
                            Console.WriteLine("Payment successful !");
                            TravelDetails travel = new TravelDetails(currentLoggedInUser.CardNumber,ticketFair.FromLocation,ticketFair.ToLocation,DateTime.Now,ticketFair.TicketPrice);
                            travelHistoryList.Add(travel);
                            Console.WriteLine("Ticket is now booked...Happy Journey!");
                        }
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Insufficient Balance..");
                        break;
                    }
                }
            }
            if(!ticketFlag)
            {
                System.Console.WriteLine("Invalid Ticket ID...");
            }
            
        }

        
    }
}