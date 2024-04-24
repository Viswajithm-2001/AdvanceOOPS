using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public enum Status{Default,Borrowed,Returned}
    public class BorrowedDetails
    {
        //Field
        //static field
        private static int s_borrowID=2000;
        //Properties
        public string BorrowID{get;}
        public string BookID{get;set;}
        public string UserID{get;set;}
        public DateTime BorrowedDate{get;set;}
        public int BorrowBookCount{get;set;}
        public Status Status {get;set;}
        public int PaidFineAmount{get;set;}

        public BorrowedDetails(string bookID,string userID,DateTime borrowedDate,int borrowbookCount,Status status,int paidFineAmount)
        {
            s_borrowID++;
            BorrowID = "LB"+s_borrowID;
            BookID=bookID;
            UserID=userID;
            BorrowedDate=borrowedDate;
            BorrowBookCount=borrowbookCount;
            Status =status;
            PaidFineAmount = paidFineAmount;
        }
    }
}