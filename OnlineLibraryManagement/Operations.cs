using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public static class Operations
    {
        static UserDetails currentLoggedInUser;
        static List<BookDetails> BookList = new List<BookDetails>();
        static List<UserDetails>UserList = new List<UserDetails>();
        static List<BorrowedDetails> BorrowList = new List<BorrowedDetails>();
        public static void DefaultData()
        {
            //Adding default user data
            UserDetails user1 = new UserDetails("Ravichandran",Gender.Male,"EEE",9938388333,"ravi@gmail.com",100);
            UserDetails user2 = new UserDetails("Priyadharshini",Gender.Female,"CSE",9938388333,"priya@gmail.com",150);
            UserList.Add(user1);
            UserList.Add(user2);

            //Adding default Bookdetails
            BookDetails book1 = new BookDetails("C#","Author1",3);
            BookDetails book2 = new BookDetails("HTML","Author2",5);
            BookDetails book3 = new BookDetails("CSS","Author1",3);
            BookDetails book4 = new BookDetails("JS","Author1",3);
            BookDetails book5 = new BookDetails("TS","Author2",2);
            BookList.AddRange(new List<BookDetails>{book1,book2,book3,book4,book5});

            // BorrowedDetails borrowed1 = new BorrowedDetails("BID1001","SF001",new DateTime(2023,09,10),2,Status.Borrowed,0);
            // BorrowedDetails borrowed2 = new BorrowedDetails("BID1003","SF001",new DateTime(2023,09,12),1,Status.Borrowed,0);
            // BorrowedDetails borrowed3 = new BorrowedDetails("BID1004","SF001",new DateTime(2023,09,14),1,Status.Returned,16);
            // BorrowedDetails borrowed4 = new BorrowedDetails("BID1002","SF002",new DateTime(2023,09,12),2,Status.Borrowed,0);
            // BorrowedDetails borrowed5 = new BorrowedDetails("BID1005","SF021",new DateTime(2023,09,09),1,Status.Returned,20);
            // BorrowList.AddRange(new List<BorrowedDetails>{borrowed1,borrowed2,borrowed3,borrowed4,borrowed5});
            
        }
        public static void MainMenu()
        {
            Console.WriteLine("**********SYNCFUSION LIBRARY**********");
            string menuChoice = "yes";
            do{
            Console.WriteLine("MainMenu.....");
            Console.WriteLine("Enter\n1. User Registration\n2. User Login\n3. Exit");
            Console.Write("Your option : ");
            int mainChoice = int.Parse(Console.ReadLine());
            switch(mainChoice)
            {
                case 1:
                {
                    UserRegistraion();
                    break;
                }
                case 2:
                {
                    UserLogin();
                    break;
                }
                case 3:
                {
                    menuChoice="no";
                    System.Console.WriteLine("You are Leaving this application");
                    Console.WriteLine("Thank You");
                    break;
                }
                default:
                {
                    
                    System.Console.WriteLine("Invalid Option");
                    break;
                }
            }
            }while(menuChoice=="yes");
        }
        static void UserRegistraion()
        {
            //get user info
            Console.WriteLine("*****User Registration Portal*****");
            Console.Write("Enter your Name : ");
            string registrationName = Console.ReadLine();
            Console.Write("Enter your Gender (Male/Female/Transgender)");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter Your Department : ");
            string department = Console.ReadLine();
            System.Console.Write("Enter you Mobile Number : ");
            long mobileNumber= long.Parse(Console.ReadLine());
            Console.Write("Enter your mail ID : ");
            string mailID = Console.ReadLine();
            Console.Write("Enter your Wallet Balance : ");
            double walletBalnce = double.Parse(Console.ReadLine());
            //create object
            UserDetails registringUser = new UserDetails(registrationName,gender,department,mobileNumber,mailID,walletBalnce);
            //add in a list
            UserList.Add(registringUser);
            Console.WriteLine("Your Registration done successfully...");
            System.Console.WriteLine("Your User ID is "+registringUser.UserID);
        }
        static void UserLogin()
        {
            Console.WriteLine("*****USER LOGIN*****");
            Console.Write("Enter your UserID : ");
            string loginID = Console.ReadLine().ToUpper(); 
            bool flag = true;
            foreach(UserDetails user in UserList)
            {
                if(loginID.Equals(user.UserID))
                {
                    currentLoggedInUser=user;
                    flag=false;
                    SubMenu();
                }

            }
            if(flag)
            {
                Console.WriteLine("Invalid UserID. Please enter a valid one.");
            }
        }
        static void SubMenu()
        {
            /*1.	Borrowbook.
            2.	ShowBorrowedhistory.
            3.	ReturnBooks
            4.	WalletRecharge 
            5.	Exit
            */
            Console.WriteLine("You have logged in succesfully...");
            //submenu
            string choice = "yes";
            do
            {
                Console.WriteLine("Enter\n1. BorrowBook\n2. ShowBorrowedHistory\n3. ReturnBooks\n4. WalletRecharge\n5. Exit");
            Console.Write("Enter your option : ");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    BorrowBook();
                    break;
                }
                case 2:
                {
                    ShowBorrowedHistory();
                    break;
                }
                case 3:
                {
                    ReturnBooks();
                    break;
                }
                case 4:
                {
                    WalletRecharge();
                    break;
                }
                case 5:
                {
                    choice = "no";
                    System.Console.WriteLine("Logged Out");
                    Console.WriteLine("You are Going to Main menu");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid option.");
                    break;
                }
            }

            }while(choice=="yes");

        }
        static void BorrowBook()
        {
            ShowBookList();
            //Program for borrowing 1 book
            Console.Write("Enter Book ID to borrow : ");
            string borrowBookID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach(BookDetails bookDetail in BookList)
            {
                if(borrowBookID.Equals(bookDetail.BookID))
                {
                    if(bookDetail.BookCount>0)
                    {
                        flag=false;
                        Console.WriteLine("The book is available...");
                        //Console.Write("Enter the count of the book : ");
                        int bookCount = 1;
                        BorrowedDetails borroweddetail = new BorrowedDetails(bookDetail.BookID,currentLoggedInUser.UserID,DateTime.Now,bookCount,Status.Borrowed,0);
                        if(bookDetail.BookCount-bookCount >=0)
                        {    
                            BorrowList.Add(borroweddetail);
                            bookDetail.BookCount-=bookCount;
                            Console.WriteLine("Book Borrowed Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Books are not available, books will be available after 15 days."+borroweddetail.BorrowedDate.AddDays(15));
                        }
                    }
                    else
                    {
                        Console.WriteLine("there is no book available for the selected count");
                    }
                    break;
                    
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid Book ID Please Enter valid ID");
            }
        }
        static void ShowBorrowedHistory()
        {
            foreach(BorrowedDetails borrowed in BorrowList)
            {
                if(borrowed.UserID==currentLoggedInUser.UserID)
                    Console.WriteLine(borrowed.BorrowID+" "+borrowed.BookID+" "+borrowed.UserID+" "+borrowed.BorrowedDate.ToString("dd/MM/yyyy")+" "+borrowed.BorrowBookCount+" "+borrowed.Status+" "+borrowed.PaidFineAmount);
            }

        }
        static void ReturnBooks()
        {
            foreach(BorrowedDetails borrowed in BorrowList)
            {
                if(currentLoggedInUser.UserID.Equals(borrowed.UserID))
                {
                    if(borrowed.Status==Status.Borrowed)
                    {
                        ShowBorrowedHistory();
                        DateTime returnDate = borrowed.BorrowedDate.AddDays(15);
                        Console.WriteLine("The return Date should be"+ returnDate.ToString("dd/MM/yyyy"));
                        DateTime today = DateTime.Now;
                        if(today>returnDate)
                        {
                            int fineDays = today.Subtract(returnDate).Days;
                            borrowed.PaidFineAmount+=fineDays;
                            if(currentLoggedInUser.WalletBalance-borrowed.PaidFineAmount>0)
                            {
                                currentLoggedInUser.WalletBalance-=borrowed.PaidFineAmount;
                                foreach(BookDetails book in BookList)
                                {
                                    if(borrowed.BookID.Equals(book.BookID))
                                    {
                                        book.BookCount++;
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }
        static void WalletRecharge()
        {
            Console.Write("Do you Want to Recharge your wallet (yes/no): ");
            string choice = Console.ReadLine().ToLower();
            if(choice=="yes")
            {
                Console.Write("Enter the amount for Recharge : ");
                double amount = double.Parse(Console.ReadLine());
                currentLoggedInUser.WalletBalance+=amount;
                Console.WriteLine("Recharge done successfully...");
            }            

        }
        static void ShowBookList()
        {
            foreach(BookDetails book in BookList)
            {
                book.PrintBookDetails();
            }
        }
    }
}