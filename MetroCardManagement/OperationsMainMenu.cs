using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static partial class Operations
    {
        //Field for class level access
        static UserDetails currentLoggedInUser;

        //List for storing
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelHistoryList = new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> ticketFairList = new CustomList<TicketFairDetails>();
        //Operations class for Mainmenu
        public static void MainMenu()
        {
            //1. registration
            //2. Login
            //3. Exit

            System.Console.WriteLine("Application for Metro card Management...");
            string mainChoice = "no";
            do
            {
            Console.WriteLine("Enter\n1. New User Registraion\n2. Login User\n3. Exit");
            Console.Write("Your option : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    //Registration
                    Registration();
                    break;
                }
                case 2:
                {
                    //Login
                    Login();
                    break;
                }
                case 3:
                {
                    //Exit
                    System.Console.Write("Do you want to exit(yes/no): ");
                    mainChoice = Console.ReadLine().ToLower();
                    break;
                }
                default:
                {
                    break;
                }
            }

            }while(mainChoice =="no");
        }

        //Method for user Registration
        static void Registration()
        {
            System.Console.WriteLine("Welcome to Registration Portal...");
            Console.Write("Enter your User Name : ");
            string userName = Console.ReadLine();
            Console.Write("Enter your Phone Number : ");
            string phoneNumber = Console.ReadLine();
            System.Console.Write("Enter your Balance amount : ");
            double balance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Registering your details.....");
            UserDetails registerUser = new UserDetails(userName,phoneNumber,balance);
            userList.Add(registerUser);
            System.Console.WriteLine("Regitration successfull....");
            System.Console.WriteLine($"Here is your Card Number : {registerUser.CardNumber}");
        }

        static void Login()
        {
            Console.WriteLine("Welcome to Login Portal...");
            Console.Write("Enter your Card Number for Login : ");
            string cardNumber = Console.ReadLine().ToUpper();
            bool loopflag = false;
            foreach(UserDetails user in userList)
            {
                if(user.CardNumber.Equals(cardNumber))
                {
                    loopflag= true;
                    currentLoggedInUser = user;
                    SubMenu();
                }
            }
            if(!loopflag)
            {
                System.Console.WriteLine("Invalid CardNumber.....");
            }

        }
    }
}