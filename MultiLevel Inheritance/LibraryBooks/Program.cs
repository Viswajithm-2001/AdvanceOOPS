using System;
using System.Collections.Generic;

namespace LibraryBooks;

class Program
{

    public static void Main(string[] args)
    {
        List<BookInfo> booklist = new List<BookInfo>();
        BookInfo book1 = new BookInfo("CSE", "B.Tech", 10, 9, "Introduction to C", "Dennis Richie", 540.00);
        BookInfo book2 = new BookInfo("Mech", "B.Tech", 11, 8, "Mechanical Engineering", "S. Chand", 536.00);
        BookInfo book3 = new BookInfo("CIVIL", "B.Tech", 12, 7, "Construction Management", "Wiley", 412.00);


        booklist.AddRange(new List<BookInfo>{book1,book2,book3});

        foreach(BookInfo  book in booklist)
        {
            Console.WriteLine("-------------------------------------------------------------");
            book.DisplayInfo();
            Console.WriteLine("-------------------------------------------------------------");
        }
    }


}