using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class Operations
    {
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<MedicineDetails> medicineList = new CustomList<MedicineDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();

        static UserDetails currentLoggedInUser;
        public static void Default()
        {
            //Adding Default user details
            UserDetails user1 = new UserDetails("Ravi",33,"Theni","9877774440",400);
            UserDetails user2 = new UserDetails("Baskaran",33,"Chennai","8847757470",500);
            userList.Add(user1);
            userList.Add(user2);

            //Adding Default medicine details
            MedicineDetails medicine1 = new MedicineDetails("Paracitamol",40,5,new DateTime(2024,06,30));
            MedicineDetails medicine2 = new MedicineDetails("Calpol",10,5,new DateTime(2024,05,30));
            MedicineDetails medicine3 = new MedicineDetails("Gelucil",3,40,new DateTime(2024,04,30));
            MedicineDetails medicine4 = new MedicineDetails("Metrogel",5,50,new DateTime(2024,12,30));
            MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin",10,50,new DateTime(2024,10,30));
            medicineList.AddRange(new CustomList<MedicineDetails>{medicine1,medicine2,medicine3,medicine4,medicine5});

            //Adding Default OrderDetails
            OrderDetails order1 =  new OrderDetails("UID1001","MD101",3,15,new DateTime(2022,11,13),OrderStatus.Purchased);
            OrderDetails order2 =  new OrderDetails("UID1001","MD102",2,10,new DateTime(2022,11,13),OrderStatus.Cancelled);
            OrderDetails order3 =  new OrderDetails("UID1001","MD104",2,100,new DateTime(2022,11,13),OrderStatus.Purchased);
            OrderDetails order4 =  new OrderDetails("UID1002","MD103",3,120,new DateTime(2022,11,15),OrderStatus.Cancelled);
            OrderDetails order5 =  new OrderDetails("UID1002","MD105",5,250,new DateTime(2022,11,15),OrderStatus.Purchased);
            OrderDetails order6 =  new OrderDetails("UID1002","MD102",3,15,new DateTime(2022,11,15),OrderStatus.Purchased);
            orderList.AddRange(new CustomList<OrderDetails>{order1,order2,order3,order4,order5,order6});
        }
        public static void MainMenu()
        {
            System.Console.WriteLine("Syncfusion Cafeteria.......");
            string loopChoice = "no";
            do
            {
                System.Console.WriteLine("Enter\n1. User Registration\n2. User Login\n3. Exit");
                int mainChoice;
                bool flag = int.TryParse(Console.ReadLine(), null, out mainChoice);
                while (!flag)
                {
                    System.Console.WriteLine("Invalid Input Please try again..");
                    System.Console.WriteLine("Enter\n1. User Registration\n2. User Login\n3. Exit");
                    flag = int.TryParse(Console.ReadLine(), null, out mainChoice);
                }
                switch (mainChoice)
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

            } while (loopChoice != "yes");
        }

        static void Registration()
        {
            System.Console.WriteLine("Welcome to Registration Portal...");
            Console.Write("Enter your User Name : ");
            string userName = Console.ReadLine();
            Console.Write("Enter your Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your City : ");
            string city = Console.ReadLine();
            Console.Write("Enter your Phone Number : ");
            string phoneNumber = Console.ReadLine();
            System.Console.Write("Enter your Balance amount : ");
            double balance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Registering your details.....");
            UserDetails registerUser = new UserDetails(userName, age, city, phoneNumber, balance);
            userList.Add(registerUser);
            System.Console.WriteLine("Regitration successfull....");
            System.Console.WriteLine($"Here is your User ID : {registerUser.UserID}");
        }
        static void Login()
        {
            System.Console.WriteLine("Login Portal.....");
            System.Console.Write("Enter your User ID : ");
            string loginID = Console.ReadLine().ToUpper();
            bool loginFlag = false;
            foreach (UserDetails user in userList)
            {
                if (user.UserID.Equals(loginID))
                {
                    loginFlag = true;
                    currentLoggedInUser = user;
                    System.Console.WriteLine("You have Logged in successfully..");
                    LoginSubMenu();
                }

            }
            if (!loginFlag)
            {
                System.Console.WriteLine("Invalid User ID...");
            }

        }
        static void LoginSubMenu()
        {
            string loopChoice = "no";
            do
            {
                System.Console.WriteLine("Enter\n1. Show Medicine list\n2. Purchase medicine\n3. Modify purchase\n4. Cancel purchase\n5. Show purchase history\n6. Recharge Wallet\n7.Show Wallet balance\n8. Exit");
                Console.Write("Your Option : ");
                int loginChoice = int.Parse(Console.ReadLine());
                switch (loginChoice)
                {
                    case 1:
                        {
                            //Show profile
                            ShowMedicineList();
                            break;
                        }
                    case 2:
                        {
                            //order food
                            PurchaseMedcine();
                            break;
                        }
                    case 3:
                        {
                            //cancel order
                            ModifyPurchase();
                            break;
                        }
                    case 4:
                        {
                            //modify order
                            CancelPurchase();
                            break;
                        }
                    case 5:
                        {
                            //orderhistory
                            ShowPurchaseHistory();
                            break;
                        }
                    case 6:
                        {
                            //recharge wallet
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            //show wallet balance
                            ShowWalletBalance();
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
        static void ShowMedicineList()
        {
            System.Console.WriteLine("Here are the Medicine List that are available....");
            System.Console.WriteLine("MedicineID    MedicineName    AvailableCount  Price   DateOfExpiry");
            foreach (MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine($"{medicine.MedicineID,-12}{medicine.MedicineName,-12}{medicine.AvailableCount,-12}{medicine.Price,-12}{medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-12}");
            }
        }
        static void PurchaseMedcine()
        {
            ShowMedicineList();
            System.Console.Write("Enter the Medicine ID to purchase : ");
            string tempId = Console.ReadLine().ToUpper();
            bool flag = false;
            foreach (MedicineDetails medicine in medicineList)
            {
                if (tempId.Equals(medicine.MedicineID))
                {
                    flag = true;
                    Console.Write("Enter the Count : ");
                    int count = int.Parse(Console.ReadLine());
                    if (medicine.AvailableCount >= count)
                    {
                        System.Console.WriteLine("Medicines Available...");
                        System.Console.WriteLine("Do you want to confirm payment (yes/no)");
                        if (DateTime.Compare(medicine.DateOfExpiry, DateTime.Now) > 0)
                        {
                            if (Console.ReadLine().ToLower() == "yes")
                            {
                                if (currentLoggedInUser.WalletBalance > (medicine.Price * count))
                                {
                                    currentLoggedInUser.DeductBalance(medicine.Price * count);
                                    medicine.AvailableCount -= count;
                                    OrderDetails order1 = new OrderDetails(currentLoggedInUser.UserID, medicine.MedicineID, count, medicine.Price * count, DateTime.Now, OrderStatus.Purchased);
                                    orderList.Add(order1);
                                    System.Console.WriteLine("Order Ordered successfully....");
                                    System.Console.WriteLine($"Your order ID is : {order1.OrderID}");
                                }
                                else
                                {
                                    System.Console.WriteLine("Insufficient balance...");
                                }
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Medicines Expired..");
                        }
                    }
                }
            }
            if (!flag)
            {
                System.Console.WriteLine("Invalid ID ");
            }

        }
        static void ModifyPurchase()
        {
            ShowPurchaseHistory();
            Console.Write("Enter Order ID to modify : ");
            string orderID = Console.ReadLine();
            bool flag = false;
            foreach (OrderDetails order in orderList)
            {
                if (order.OrderID.Equals(orderID))
                {
                    flag = true;
                    System.Console.WriteLine("Do you want to Modify (yes/no)");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        foreach (MedicineDetails medicine in medicineList)
                        {
                            if (order.MedicineID == medicine.MedicineID)
                            {
                                medicine.AvailableCount += order.MedicineCount;
                                currentLoggedInUser.WalletRecharge(order.TotalPrice);
                                Console.Write("Enter new Count of Medicines : ");
                                int count = int.Parse(Console.ReadLine());
                                double tempPrice = count * medicine.Price;
                                if (tempPrice <= currentLoggedInUser.WalletBalance)
                                {
                                    currentLoggedInUser.DeductBalance(tempPrice);
                                    order.TotalPrice = tempPrice;
                                    order.MedicineCount = count;
                                    System.Console.WriteLine("Order Modified and price deducted successfully...");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient balance.......");
                                    medicine.AvailableCount -= order.MedicineCount;
                                    currentLoggedInUser.DeductBalance(order.TotalPrice);

                                }
                                break;
                            }
                            break;
                        }
                    }

                }
            }
            if (!flag)
            {
                System.Console.WriteLine("Invalid ID..");
            }

        }
        static void CancelPurchase()
        {
            System.Console.WriteLine("Cancel Order........");
            System.Console.WriteLine("Enter the Order ID for cancelling : ");
            string orderID = Console.ReadLine().ToLower();
            bool loopFlag = false;
            foreach (OrderDetails order in orderList)
            {
                if (order.OrderID.Equals(orderID) && currentLoggedInUser.UserID.Equals(order.UserID))
                {
                    loopFlag = true;
                    if (order.OrderStatus == OrderStatus.Purchased)
                    {
                        System.Console.WriteLine("Do you want to cancel this order (yes/no): ");
                        if (Console.ReadLine().ToLower() == "yes")
                        {
                            order.OrderStatus = OrderStatus.Cancelled;
                            currentLoggedInUser.WalletRecharge(order.TotalPrice);
                            System.Console.WriteLine("Cancelled");
                            foreach (MedicineDetails medicine in medicineList)
                            {
                                if (order.MedicineID == medicine.MedicineID)
                                {
                                    medicine.AvailableCount += order.MedicineCount;
                                }
                            }
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
        static void ShowPurchaseHistory()
        {
            int count = 0;
            foreach (OrderDetails order in orderList)
            {
                if (order.UserID.Equals(currentLoggedInUser.UserID))
                {
                    count += 1;
                }
            }
            if (count > 0)
            {
                System.Console.WriteLine("Here is order history : ");
                System.Console.WriteLine("OrderID   UserID  MedicineID  MedicineCount  TotalPrice  OrderDate OrderStatus");
                foreach (OrderDetails order in orderList)
                {
                    System.Console.WriteLine($"{order.OrderID,-12}{order.UserID,-12}{order.MedicineID,-12}{order.MedicineCount,-12}{order.TotalPrice,-12}{order.OrderDate.ToString("dd/MM/yyyy"),-12}{order.OrderStatus,-12}");
                }
            }
            else
            {
                System.Console.WriteLine("There is no order History");
            }

        }
        static void RechargeWallet()
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
        static void ShowWalletBalance()
        {
            System.Console.WriteLine($"Your Wallet balance now is : {currentLoggedInUser.WalletBalance}");
        }
    }
}