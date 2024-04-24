using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks
{
    public class BookInfo : RackInfo
    {
        private static int _bookID = 1000;
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string departmentName, string degree, int rackNumber, int columnNumber, string bookName, string authorName, double price) : base(departmentName, degree, rackNumber, columnNumber)
        {
            BookID = "BID" + (++_bookID);
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"Department Name : {DepartmentName}");
            System.Console.WriteLine($"Degree          : {Degree}");
            System.Console.WriteLine($"RackNumber      : {RackNumber}");
            System.Console.WriteLine($"Column Number   : {ColumnNumber}");
            System.Console.WriteLine($"Book ID         : {BookID}");
            System.Console.WriteLine($"Book Name       : {BookName}");
            System.Console.WriteLine($"Author Name     : {AuthorName}");
            System.Console.WriteLine($"Price           : {Price}");
            
        }
    }
}