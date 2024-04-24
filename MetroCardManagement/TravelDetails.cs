using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TravelDetails
    {
        //Field
        private static int s_travelID = 2000;

        //Properties
        public string TravelID{get;}
        public string CardNumber{get;set;}
        public string FromLocation {get;set;}
        public string ToLocation {get;set;}
        public DateTime Date {get;set;}
        public double TravelCost {get;set;}

        public TravelDetails(string cardNumber,string fromLocation,string toLocation,DateTime date,double travelCost)
        {
            s_travelID++;
            TravelID = "TID"+s_travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation= toLocation;
            Date = date;
            TravelCost = travelCost;
        }
        public TravelDetails(string travels)
        {
            string [] travel = travels.Split(",");
            s_travelID = int.Parse(travel[0].Remove(0,3));
            TravelID = travel[0];
            CardNumber = travel[1];
            FromLocation = travel[2];
            ToLocation = travel[3];
            Date = DateTime.Parse(travel[4]);
            TravelCost = double.Parse(travel[5]);

        }
    }
}