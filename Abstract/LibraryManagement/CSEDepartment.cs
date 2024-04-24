using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class CSEDepartment : Library
    {
        public override string AuthorName{get;set;}
        public override string BookName{get;set;}
        public override string PublisherName{get;set;}
        public override int Year{get;set;}

        public override void SetBookInfo(string authorName, string bookName, string publisherName, int year)
        {
            s_serialNumber++;
            SerialNumber = "LIB" + s_serialNumber;
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("BookID : "+SerialNumber);
            Console.WriteLine("AuthorName : "+AuthorName);
            Console.WriteLine("BookName : "+AuthorName);
            Console.WriteLine("Publisher Name : "+AuthorName);
            Console.WriteLine("Year : "+AuthorName);
        }
    }
}