using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static partial class Operations
    {
        static CustomerDetails currentLoggedInUser;
        public static void MainMenu()
        {
            //1. registration 2. login 3. exit
            System.Console.WriteLine("...................Qwick Foodz...............");
            string mainChoice = "no";
            do
            {
                System.Console.WriteLine("Enter\n1. Customer Registration\n2. Customer Login \n3. Exit");
                Console.Write("Your option : ");
                int choice = int.Parse(Console.ReadLine());
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
                        //exit
                        System.Console.Write("Do your want to exit (yes/no): ");
                        mainChoice = Console.ReadLine();
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Choice..");
                        break;
                    }
                }

            }while(mainChoice!="yes");

        }
        
        //Registration
        static void Registration()
        {
            System.Console.WriteLine("Registration Portal..");
            Console.Write("Enter you name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Father name : ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your Gender (Male/Female/Transgender)");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter your Phone Number : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter your Date of birth (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter your Mail ID : ");
            string mailID = Console.ReadLine();
            System.Console.Write("Enter your Location : ");
            string location = Console.ReadLine();
            System.Console.WriteLine("Registrering the details...");
            System.Console.Write("Enter you Balance : ");
            double balance = double.Parse(Console.ReadLine());
            CustomerDetails customer = new CustomerDetails(balance,name,fatherName,gender,phoneNumber,dob,mailID,location);
            customerList.Add(customer);
            System.Console.WriteLine($"Your Registration is successful, Here is your ID : {customer.CustomerID}");

        }


        //Login
        static void Login()
        {
            System.Console.WriteLine("Login Portal.....");
            System.Console.Write("Enter your Customer ID : ");
            string loginID = Console.ReadLine().ToUpper();
            bool loginFlag = false;
            foreach(CustomerDetails customer in customerList)
            {
                if(customer.CustomerID.Equals(loginID))
                {
                    loginFlag = true;
                    currentLoggedInUser = customer;
                    System.Console.WriteLine("You have Logged in successfully..");
                    LoginSubMenu();
                }

            }
            if(!loginFlag)
            {
                System.Console.WriteLine("Invalid Customer ID...");
            }
            
        }
    }
}