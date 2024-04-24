using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocerySTore
{
    public static class Operations
    {
        static List<CustomerDetails> customerList = new List<CustomerDetails>();
        static List<ProductDetails> productList = new List<ProductDetails>();
        static List<OrderDetails> orderList = new List<OrderDetails>();
        static List<BookingDetails> bookingList = new List<BookingDetails>();
        static CustomerDetails currentLoggedInUser;


        public static void Default()
        {
            CustomerDetails customer1 = new CustomerDetails(10000,"Ravi","Ettaparajan",Gender.Male,"974774646",new DateTime(1999,11,11),"ravi@gmail.com");
            CustomerDetails customer2 = new CustomerDetails(15000,"Baskaran","Sethurajan",Gender.Male,"847575775",new DateTime(1999,11,11),"baskaran@gmail.com");
            customerList.Add(customer1);
            customerList.Add(customer2);

            ProductDetails product1 = new ProductDetails("Sugar",20,40);
            ProductDetails product2 = new ProductDetails("Rice",100,50);
            ProductDetails product3 = new ProductDetails("Milk",10,40);
            ProductDetails product4 = new ProductDetails("Coffee",10,10);
            ProductDetails product5 = new ProductDetails("Tea",10,10);
            ProductDetails product6 = new ProductDetails("Masala Powder",10,20);
            ProductDetails product7 = new ProductDetails("Salt",10,10);
            ProductDetails product8 = new ProductDetails("Turmeric Powder",10,25);
            ProductDetails product9 = new ProductDetails("Chilli Powder",10,20);
            ProductDetails product10 = new ProductDetails("Groundnut Oil",10,140);
            productList.AddRange(new List<ProductDetails>{product1,product2,product3,product4,product5,product6,product7,product8,product9,product10});

            BookingDetails booking1 = new BookingDetails("CID1001",220,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("CID1002",400,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("CID1001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
            BookingDetails booking4 = new BookingDetails("CID1002",0,new DateTime(2022,07,26),BookingStatus.Initiated);
            bookingList.AddRange(new List<BookingDetails>{booking1,booking2,booking3,booking4});

            OrderDetails order1 = new OrderDetails("BID3001","PID2001",2,80);
            OrderDetails order2 = new OrderDetails("BID3001","PID2002",2,100);
            OrderDetails order3 = new OrderDetails("BID3001","PID2003",1,40);
            OrderDetails order4 = new OrderDetails("BID3002","PID2001",1,40);
            OrderDetails order5 = new OrderDetails("BID3002","PID2002",4,200);
            OrderDetails order6 = new OrderDetails("BID3002","PID2010",1,140);
            OrderDetails order7 = new OrderDetails("BID3002","PID2009",1,20);
            OrderDetails order8 = new OrderDetails("BID3003","PID2002",2,100);
            OrderDetails order9 = new OrderDetails("BID3003","PID2008",4,100);
            OrderDetails order10 = new OrderDetails("BID3003","PID2001",2,80);
            orderList.AddRange(new List<OrderDetails>{order1,order2,order3,order4,order5,order6,order7,order8,order9,order10});
        }
        public static void MainMenu()
        {
            //1. registration 2. login 3. exit
            System.Console.WriteLine("...................Online Grocery Store...............");
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
            string mobileNumber = Console.ReadLine();
            Console.Write("Enter your Date of birth (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter your Mail ID : ");
            string mailID = Console.ReadLine();
            System.Console.WriteLine("Registrering the details...");
            System.Console.Write("Enter you Balance : ");
            double balance = double.Parse(Console.ReadLine());
            CustomerDetails customer = new CustomerDetails(balance,name,fatherName,gender,mobileNumber,dob,mailID);
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
    
        static void LoginSubMenu()
        {
            string loopChoice = "no";
            do
            {
                System.Console.WriteLine("Enter\n1. Show Customer Details\n2. Show Product Details\n3. Wallet Recharge\n4. Take Order\n5. Modify Order Quantity\n6. Cancel order\n7.Show  balance\n8. Exit");
                Console.Write("Your Option : ");
                int loginChoice = int.Parse(Console.ReadLine());
                switch (loginChoice)
                {
                    case 1:
                        {
                            //Show profile
                            ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            //order food
                            ShowProductDetails();
                            break;
                        }
                    case 3:
                        {
                            //cancel order
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            //modify order
                            TakeOrder();
                            break;
                        }
                    case 5:
                        {
                            //orderhistory
                            ModifyOrderQuantity();
                            break;
                        }
                    case 6:
                        {
                            //recharge wallet
                            CancelOrder();
                            break;
                        }
                    case 7:
                        {
                            //show wallet balance
                            ShowBalance();
                            break;
                        }
                    case 8:
                        {
                            //exit
                            System.Console.Write("Do yo want to exit (yes/no): ");
                            loopChoice = Console.ReadLine().ToLower();

                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid Choice");
                            break;
                        }

                }
            } while (loopChoice != "yes");
        }
    
        static void ShowCustomerDetails()
        {
            System.Console.WriteLine("Here are your Details");
            System.Console.WriteLine($"Customer ID : {currentLoggedInUser.CustomerID}");
            System.Console.WriteLine($"Name : {currentLoggedInUser.Name}");
            System.Console.WriteLine($"Father Name : {currentLoggedInUser.FatherName}");
            System.Console.WriteLine($"Gender : {currentLoggedInUser.Gender}");
            System.Console.WriteLine($"Mobile Number : {currentLoggedInUser.MobileNumber}");
            System.Console.WriteLine($"Date Of Birth: {currentLoggedInUser.DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Mail ID : {currentLoggedInUser.MailID}");

        }
        static void ShowProductDetails()
        {
            System.Console.WriteLine("Here are the Product details...");
            System.Console.WriteLine("ProductID ProductName QuantityAvailable   PricePerQuantity");
            foreach(ProductDetails products in productList)
            {
                System.Console.WriteLine($"{products.ProductID,-12}{products.Productname,-12}{products.AvailableQuantity,-12}{products.Price,-12}");
            }
        }
        static void WalletRecharge()
        {
            System.Console.WriteLine("Do you want to Recharge (yes/no): ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                System.Console.Write("Enter the amount to Recharge : ");
                double amount = double.Parse(Console.ReadLine());
                currentLoggedInUser.WalletRecharge(amount);
                System.Console.WriteLine("Recharge Successfull !");
            }
        }
        static void TakeOrder()
        {
            BookingDetails booking = new BookingDetails(currentLoggedInUser.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);
            List<OrderDetails> tempOrderList = new List<OrderDetails>();
            System.Console.WriteLine("Ordering Portal..");
            System.Console.WriteLine("Here are the foods available");
            System.Console.WriteLine("ProductID    ProductName  QuantityAvailable   PricePerQuantity");
            foreach (ProductDetails product in productList)
            {
                if (product.AvailableQuantity > 0)
                {
                    System.Console.WriteLine($"{product.ProductID,-12}{product.Productname,-20}{product.Price,-12}{product.AvailableQuantity,-12}");
                }
            }
            string continueChoice="no";
            
            do{
                bool loopFlag = false;
                System.Console.Write("Enter the food ID that you want order : ");
                string productID = Console.ReadLine().ToUpper();
                foreach (ProductDetails product in productList)
                {
                    if (productID.Equals(product.ProductID))
                    {
                        loopFlag = true;
                        System.Console.Write("How Much would you like to order : ");
                        int quantity = int.Parse(Console.ReadLine());
                        if (product.AvailableQuantity > quantity)
                        {
                            double price = quantity * product.Price;
                            OrderDetails item = new OrderDetails(booking.BookingID,product.ProductID,quantity,price);
                            tempOrderList.Add(item);
                            product.AvailableQuantity -= quantity;
                            System.Console.WriteLine("Order added in Cart...");
                            Console.Write("Do you want to order more (yes/no): ");
                            continueChoice = Console.ReadLine().ToLower();
                        }
                    }
                }
                if(!loopFlag)
                {
                    System.Console.WriteLine("Invalid ID..");
                }
            }while (continueChoice != "no");
            double priceOfOrders = 0;
            foreach (OrderDetails orders in tempOrderList)
            {
                priceOfOrders += orders.PriceOfOrder;
            }
            Console.Write("Do you want to confirm Purchase (yes/no): ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                if (currentLoggedInUser.WalletBalance > priceOfOrders)
                {
                    booking.BookingStatus = BookingStatus.Booked;
                    booking.TotalPrice = priceOfOrders;
                    orderList.AddRange(tempOrderList);
                    currentLoggedInUser.WalletBalance-=priceOfOrders;
                    bookingList.Add(booking);

                }
                else
                {
                    Console.WriteLine("Insufficient Balance...");
                    Console.Write("Do you wish to Recharge (yes/no): ");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        WalletRecharge();
                        ShowBalance();
                    }
                    else
                    {
                        foreach (OrderDetails order in tempOrderList)
                        {
                            foreach (ProductDetails product in productList)
                            {
                                if (product.ProductID.Equals(order.ProductID))
                                {
                                    product.AvailableQuantity += order.PurchaseCount;
                                }
                            }
                        }
                    }
                }
            }

        }
        static void ModifyOrderQuantity()
        {
            System.Console.WriteLine("Here is your Order Details....");
            System.Console.WriteLine("OrderID   BookingID   ProductID   PurchaseCount   PriceOfOrder");
            foreach(OrderDetails orders in orderList)
            {
                System.Console.WriteLine($"{orders.OrderID,-12}{orders.BookingID,-12}{orders.ProductID,-12}{orders.PurchaseCount,-12}{orders.PriceOfOrder,-12}");
            }
            Console.Write("Enter Order ID that you want to Modify : ");
            string tempOrderID = Console.ReadLine();
            bool loopFlag = false;
            foreach (BookingDetails booking in bookingList)
            {
                if (tempOrderID.Equals(booking.BookingID))
                {
                    loopFlag = true;
                    if (booking.BookingStatus == BookingStatus.Booked)
                    {
                        Console.Write("Enter Order ID that you want to Modify : ");
                        string temporderID = Console.ReadLine();
                        bool loopFlag2 = false;
                        foreach (OrderDetails orders in orderList)
                        {
                            if (orders.OrderID.Equals(temporderID))
                            {
                                loopFlag2 = true;
                                System.Console.Write("How much do you want to modify : ");
                                int modifyCount = int.Parse(Console.ReadLine());
                                double actualPrice = orders.PriceOfOrder / orders.PurchaseCount;
                                double tempPrice = modifyCount * actualPrice;
                                //changing order's total price 
                                System.Console.WriteLine("Do you confirm (yes/no): ");
                                if (Console.ReadLine().ToLower() == "yes")
                                {
                                    booking.TotalPrice -= orders.PriceOfOrder;
                                    booking.TotalPrice += tempPrice;
                                    orders.PriceOfOrder = tempPrice;
                                    orders.PurchaseCount = modifyCount;
                                    System.Console.WriteLine($"Order ID {orders.OrderID} Modified successfully");
                                }
                            }
                        }
                        if (!loopFlag2)
                        {
                            System.Console.WriteLine("Invalid ID....");
                        }
                    }

                }
            }
            if (!loopFlag)
            {
                System.Console.WriteLine("Invalid ID..");
            }
        }
        static void CancelOrder()
        {
            System.Console.WriteLine("Cancel Order........");
            System.Console.WriteLine("Enter the Booking ID for cancelling : ");
            string bookedID = Console.ReadLine().ToLower();
            bool loopFlag = false;
            foreach (BookingDetails bookings in bookingList)
            {
                if (bookings.BookingID.Equals(bookedID) && currentLoggedInUser.CustomerID.Equals(bookings.CustomerID))
                {
                    loopFlag = true;
                    if (bookings.BookingStatus == BookingStatus.Booked)
                    {
                        System.Console.WriteLine("Do you want to cancel this order (yes/no): ");
                        if (Console.ReadLine().ToLower() == "yes")
                        {
                            bookings.BookingStatus = BookingStatus.Cancelled;
                            currentLoggedInUser.WalletRecharge(bookings.TotalPrice);
                            System.Console.WriteLine("Cancelled.....");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Order status is not ordered..");

                    }

                }
            }
            if (!loopFlag)
            {
                System.Console.WriteLine("Invalid ID..");
            }
        }
        static void ShowBalance()
        {
            System.Console.WriteLine($"Your balance as of now is : {currentLoggedInUser.WalletBalance}");
        }
    }
}