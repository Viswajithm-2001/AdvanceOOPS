using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public static class Operations
    {
        static CustList<UserDetails> userlist = new CustList<UserDetails>();
        static CustList<FoodDetails> foodList = new CustList<FoodDetails>();
        static CustList<CartItem> cartList = new CustList<CartItem>();
        static CustList<OrderDetails> orderlist = new CustList<OrderDetails>();
        static UserDetails currentLoggedInUser;

        public static void AddDefault()
        {
            //Adding Food Details
            FoodDetails food1 = new FoodDetails("Coffee",20,100);
            foodList.Add(food1);
            FoodDetails food2 = new FoodDetails("Tea",15,100);
            foodList.Add(food2);
            FoodDetails food3 = new FoodDetails("Biscuit",10,100);
            foodList.Add(food3);
            FoodDetails food4 = new FoodDetails("Juice",50,100);
            foodList.Add(food4);
            FoodDetails food5 = new FoodDetails("Puff",40,100);
            foodList.Add(food5);
            FoodDetails food6 = new FoodDetails("Milk",10,100);
            foodList.Add(food6);
            FoodDetails food7 = new FoodDetails("Popcorn",20,20);
            foodList.Add(food7);




        }
        public static void MainMenu()
        {
            System.Console.WriteLine("Syncfusion Cafeteria.......");
            string loopChoice="no";
            do{System.Console.WriteLine("Enter\n1. User Registration\n2. User Login\n3. Exit");
            int mainChoice;
            bool flag = int.TryParse(Console.ReadLine(), null, out mainChoice);
            while (!flag)
            {
                System.Console.WriteLine("Invalid Input Please try again..");
                System.Console.WriteLine("Enter\n1. User Registration\n2. User Login\n3. Exit");
                flag = int.TryParse(Console.ReadLine(), null, out mainChoice);
            }
            switch(mainChoice)
            {
                case 1:
                {
                    Registration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.Write("Do you want to exit (yes/no): ");
                    loopChoice = Console.ReadLine().ToLower();
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Choice");
                    break;
                }
            }

            }while(loopChoice!="yes");
        }
        static void Registration()
        {
            Console.WriteLine("Registration Portal.....");
            Console.WriteLine("________________________________________");
            Console.Write("Enter User Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter User's Father name : ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your Mobile Number : +91 ");
            string mobileNumber = Console.ReadLine();
            Console.Write("Enter your mail ID : ");
            string mailId = Console.ReadLine();
            Console.Write("Enter your Gender (male/female) : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your Workstation Number : ");
            string workstation = Console.ReadLine();
            System.Console.Write("Enter your balance : ");
            double balance = double.Parse(Console.ReadLine());
            UserDetails registerUser = new UserDetails(name, fatherName, mobileNumber, mailId, gender, workstation, balance);
            userlist.Add(registerUser);
            Console.WriteLine("you have registered successfully....");
            Console.WriteLine("Your ID is "+registerUser.UserID);

        }

        static void Login()
        {
            System.Console.Write("Enter your UserID : ");
            string userID = Console.ReadLine();
            bool loopflag = false;
            foreach(UserDetails user in userlist)
            {
                if(user.UserID.Equals(userID))
                {
                    loopflag = true;
                    currentLoggedInUser = user;
                    Submenu();
                    break;
                }
            }
            if(!loopflag)
            {
                System.Console.WriteLine("Invalid user ID..");
            }
        }
        static void Submenu()
        {
            string loopChoice="no";
            do{System.Console.WriteLine("Enter\na. Show My Profile\nb. Food Order\nc. Modify Order\nd. Cancel Order\ne. Order History\nf. Wallet Recharge\ng. Show Wallet Balance\nh. Exit");
            char choice;
            bool flag = char.TryParse(Console.ReadLine(), out choice);
            while (!flag)
            {
                System.Console.WriteLine("Invalid Input Please try again..");
                System.Console.WriteLine("Enter\n1. User Registration\n2. User Login\n3. Exit");
                flag = char.TryParse(Console.ReadLine(), out choice);
            }
            switch(choice)
            {
                case 'a':
                {
                    ShowMyProfile();
                    break;
                }
                case 'b':
                {
                    FoodOrder();
                    break;
                }
                case 'c':
                {
                    ModifyOrder();
                    break;
                }
                case 'd':
                {
                    CancelOrder();
                    break;
                }
                case 'e':
                {
                    OrderHistory();
                    break;
                }
                case 'f':
                {
                    WalletRecharge();
                    break;
                }
                case 'g':
                {
                    ShowWalletBalance();
                    break;
                }
                case 'h':
                {
                    System.Console.Write("Do you want to exit (yes/no): ");
                    loopChoice = Console.ReadLine().ToLower();
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Option");
                    break;
                }
            }

            }while(loopChoice!="yes");
        }

        static void ShowMyProfile()
        {

            System.Console.WriteLine("Here are your Details : ");
            System.Console.WriteLine($"User ID : {currentLoggedInUser.UserID}");
            System.Console.WriteLine($"Name : {currentLoggedInUser.Name}");
            System.Console.WriteLine($"Father Name : {currentLoggedInUser.FatherName}");
            System.Console.WriteLine($"Mobile Number : {currentLoggedInUser.MobileNumber}");
            System.Console.WriteLine($"Mail ID : {currentLoggedInUser.MailID}");
            System.Console.WriteLine($"Gender : {currentLoggedInUser.Gender}");
            System.Console.WriteLine($"Workstation Number : {currentLoggedInUser.WorkStation}");
            System.Console.WriteLine($"Balance : Rs.{currentLoggedInUser.WalletBalance}");
        }
    
        static void FoodOrder()
        {
            System.Console.WriteLine("Food Order Portal.....");
            System.Console.WriteLine("Here is the menu....");
            System.Console.WriteLine("FoodID    FoodName    Price   AvailableQuantity");
            foreach(FoodDetails food in foodList)
            {
                System.Console.WriteLine($"{food.FoodID,-12}{food.Foodname,-12}{food.FoodPrice,-12}{food.AvailableQuantity,-12}");
            }
            System.Console.Write("Enter your FoodID : ");
            string foodID = Console.ReadLine();
            System.Console.WriteLine("The Order has been initiated....");
            bool loopflag = false;
            foreach(FoodDetails food in foodList)
            {
                if(food.FoodID.Equals(foodID))
                {
                    System.Console.WriteLine("Enter the quantity : ");
                    int quantity = int.Parse(Console.ReadLine());
                    if(food.AvailableQuantity>=quantity)
                    {
                        double amount = food.FoodPrice * quantity;
                        OrderDetails order1 = new OrderDetails(currentLoggedInUser.UserID,DateTime.Now,amount,OrderStatus.Default);
                        orderlist.Add(order1);
                        if(currentLoggedInUser.WalletBalance>=amount)
                        {
                            System.Console.Write("Do you want to place the order(yes/no) : ");
                            if(Console.ReadLine() == "yes")
                            currentLoggedInUser.DeductAmount(amount);
                            food.AvailableQuantity-=quantity;
                            order1.OrderStatus = OrderStatus.Ordered;
                            cartList.Add(new CartItem(order1.OrderID,food.FoodID,amount,quantity));
                            System.Console.WriteLine("Your order has been placed....");
                        }
                        else
                        {
                            System.Console.WriteLine("Insufficient balance ,to continue You have to recharge now...");
                            order1.OrderStatus = OrderStatus.Initiated;
                        }
                    }
                }
            }
            if(!loopflag)
            {
                System.Console.WriteLine("Invalid user ID..");
            }
            

        }

        static void ModifyOrder()
        {
            System.Console.Write("Enter your OrderID : ");
            string orderID = Console.ReadLine();
            bool loopflag = false;
            foreach(OrderDetails order in orderlist)
            {
                if(order.OrderID.Equals(orderID))
                {
                    System.Console.WriteLine("Enter 1 to reduce the quantity\n2 ro increase the quantity");
                    Console.Write("Your choice : ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Write("Enter the quantity : ");
                    int quantity = int.Parse(Console.ReadLine());
                    if(choice ==1)
                    {
                        order.
                    }
                }
            }
            if(!loopflag)
            {
                System.Console.WriteLine("Invalid Order ID..");
            }
            
        }

        static void CancelOrder()
        {
            System.Console.Write("Enter your OrderID : ");
            string orderID = Console.ReadLine();
            bool loopflag = false;
            foreach(OrderDetails order in orderlist)
            {
                if(order.OrderID.Equals(orderID))
                {
                    loopflag=true;
                    System.Console.WriteLine("OrderID    UserID   OrderDate    TotalPrice   OrderStatus");
                    System.Console.WriteLine($"{order.OrderID,-12}{order.UserID,-12}{order.OrderDate.ToString("dd/MM/yyyy"),-12}{order.TotalPrice,12}{order.OrderStatus}");
                    System.Console.WriteLine("Do you want to cancel this order (yes/no) : ");
                    if(Console.ReadLine().ToLower() == "yes")
                    {
                        order.OrderStatus= OrderStatus.Cancelled;
                        currentLoggedInUser.WalletRecharge(order.TotalPrice);
                        System.Console.WriteLine("Order cancelled and money refunded successfully ! ....");
                    }
                    break;
                }
                else if(order.OrderStatus==OrderStatus.Cancelled)
                {
                    System.Console.WriteLine("You have already cancelled this order");
                }
            }
            if(!loopflag)
            {
                System.Console.WriteLine("Invalid Order ID..");
            }
        }


        static void OrderHistory()
        {
            System.Console.WriteLine("OrderID    UserID   OrderDate    TotalPrice   OrderStatus");
            bool flag = false;
            foreach(OrderDetails order in orderlist)
            {
                if(order.UserID.Equals(currentLoggedInUser.UserID))
                {
                    flag = true;
                    System.Console.WriteLine("-----------------------------------------------------------------------------------------");
                    System.Console.WriteLine($"{order.OrderID,-12}{order.UserID,-12}{order.OrderDate.ToString("dd/MM/yyyy"),-12}{order.TotalPrice,12}{order.OrderStatus}");
                    System.Console.WriteLine("-----------------------------------------------------------------------------------------");
                }
            }
            if(!flag)
            {
                System.Console.WriteLine("Nothing to show");
            }
        }

        static void WalletRecharge()
        {
            Console.Write("Do you want to recharge (yes/no) : ");
            if(Console.ReadLine()=="yes")
            {
                System.Console.Write("Enter the amount for recharge : ");
                double amount = double.Parse(Console.ReadLine());
                currentLoggedInUser.WalletRecharge(amount);
                System.Console.WriteLine($"Your current balance is : {currentLoggedInUser.WalletBalance}");
            }
        }

        static void ShowWalletBalance()
        {
            System.Console.WriteLine($"Your wallet balance now is : {currentLoggedInUser.WalletBalance}");
        }

    }
}