using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static partial class Operations
    {
        static void LoginSubMenu()
        {
            string loopChoice = "no";
            do
            {
                System.Console.WriteLine("Enter\n1. ShowProfile\n2. OrderFood\n3. Cancel Order\n4. Modify Order\n5. Order history\n6. Recahrge Wallet\n7.Show Wallet balance\n8. Exit");
                Console.Write("Your Option : ");
                int loginChoice = int.Parse(Console.ReadLine());
                switch (loginChoice)
                {
                    case 1:
                        {
                            //Show profile
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            //order food
                            OrderFood();
                            break;
                        }
                    case 3:
                        {
                            //cancel order
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            //modify order
                            ModifyOrder();
                            break;
                        }
                    case 5:
                        {
                            //orderhistory
                            OrderHistory();
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
        static void ShowProfile()
        {
            System.Console.WriteLine("Here are your Details");
            System.Console.WriteLine($"Customer ID : {currentLoggedInUser.CustomerID}");
            System.Console.WriteLine($"Name : {currentLoggedInUser.Name}");
            System.Console.WriteLine($"Father Name : {currentLoggedInUser.FatherName}");
            System.Console.WriteLine($"Gender : {currentLoggedInUser.Gender}");
            System.Console.WriteLine($"Mobile Number : {currentLoggedInUser.Mobile}");
            System.Console.WriteLine($"Date Of Birth: {currentLoggedInUser.DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Mail ID : {currentLoggedInUser.MailID}");

        }
        static void OrderFood()
        {
            OrderDetails order = new OrderDetails(currentLoggedInUser.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);
            List<ItemDetails> localItemList = new List<ItemDetails>();
            System.Console.WriteLine("Food Ordering Portal..");
            System.Console.WriteLine("Here are the foods available");
            System.Console.WriteLine("FoodID    FoodName        PriceQuantity   QuantityAvailable");
            foreach (FoodDetails food in foodDetailsList)
            {
                if (food.QuantityAvailable > 0)
                {
                    System.Console.WriteLine($"{food.FoodID,-12}{food.FoodName,-20}{food.PricePerQuantity,-12}{food.QuantityAvailable,-12}");
                }
            }
            string continueChoice="no";
            
            do{
                bool loopFlag = false;
                System.Console.Write("Enter the food ID that you want order : ");
                string foodID = Console.ReadLine().ToUpper();
                foreach (FoodDetails food in foodDetailsList)
                {
                    if (foodID.Equals(food.FoodID))
                    {
                        loopFlag = true;
                        System.Console.Write("How Much would you like to order : ");
                        int quantity = int.Parse(Console.ReadLine());
                        if (food.QuantityAvailable > quantity)
                        {
                            double price = quantity * food.PricePerQuantity;
                            ItemDetails item = new ItemDetails(order.OrderID, food.FoodID, quantity, price);
                            localItemList.Add(item);
                            food.QuantityAvailable -= quantity;
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
            foreach (ItemDetails item1 in localItemList)
            {
                priceOfOrders += item1.PriceOfOrder;
            }
            Console.Write("Do you want to confirm Purchase (yes/no): ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                if (currentLoggedInUser.WalletBalance > priceOfOrders)
                {
                    order.OrderStatus = OrderStatus.Ordered;
                    order.TotalPrice = priceOfOrders;
                    itemDetailsList.AddRange(localItemList);
                    currentLoggedInUser.DeductBalance(priceOfOrders);
                    orderDetailsList.Add(order);

                }
                else
                {
                    Console.WriteLine("Insufficient Balance...");
                    Console.Write("Do you wish to Recharge (yes/no): ");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        RechargeWallet();
                        ShowWalletBalance();
                    }
                    else
                    {
                        foreach (ItemDetails items in localItemList)
                        {
                            foreach (FoodDetails food in foodDetailsList)
                            {
                                if (items.FoodID.Equals(food.FoodID))
                                {
                                    food.QuantityAvailable += items.PurchaseCount;
                                }
                            }
                        }
                    }
                }
            }

        }
        static void CancelOrder()
        {
            System.Console.WriteLine("Cancel Order........");
            System.Console.WriteLine("Enter the Order ID for cancelling : ");
            string orderID = Console.ReadLine().ToLower();
            bool loopFlag = false;
            foreach (OrderDetails order in orderDetailsList)
            {
                if (order.OrderID.Equals(orderID) && currentLoggedInUser.CustomerID.Equals(order.CustomerID))
                {
                    loopFlag = true;
                    if (order.OrderStatus == OrderStatus.Ordered)
                    {
                        System.Console.WriteLine("Do you want to cancel this order (yes/no): ");
                        if (Console.ReadLine().ToLower() == "yes")
                        {
                            order.OrderStatus = OrderStatus.Cancelled;
                            currentLoggedInUser.WalletRecharge(order.TotalPrice);
                            System.Console.WriteLine("Cancelled");
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
        static void ModifyOrder()
        {
            ShowHistory();
            Console.Write("Enter Order ID that you want to Modify : ");
            string tempOrderID = Console.ReadLine();
            bool loopFlag = false;
            foreach (OrderDetails order in orderDetailsList)
            {
                if (tempOrderID.Equals(order.OrderID))
                {
                    loopFlag = true;
                    if (order.OrderStatus == OrderStatus.Ordered)
                    {
                        Console.Write("Enter Order ID that you want to Modify : ");
                        string tempItemID = Console.ReadLine();
                        bool loopFlag2 = false;
                        foreach (ItemDetails item in itemDetailsList)
                        {
                            if (item.ItemID.Equals(tempItemID))
                            {
                                loopFlag2 = true;
                                System.Console.Write("How much do you want to modify : ");
                                int modifyCount = int.Parse(Console.ReadLine());
                                double actualPrice = item.PriceOfOrder / item.PurchaseCount;
                                double tempPrice = modifyCount * actualPrice;
                                //changing order's total price 
                                System.Console.WriteLine("Do you confirm (yes/no): ");
                                if (Console.ReadLine().ToLower() == "yes")
                                {
                                    order.TotalPrice -= item.PriceOfOrder;
                                    order.TotalPrice += tempPrice;
                                    item.PriceOfOrder = tempPrice;
                                    item.PurchaseCount = modifyCount;
                                    System.Console.WriteLine($"Order ID {order.OrderID} Modified successfully");
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
        static void OrderHistory()
        {
            int count = 0;
            foreach (OrderDetails order in orderDetailsList)
            {
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID))
                {
                    count += 1;
                }
            }
            if (count > 0)
            {
                System.Console.WriteLine("Here is order history : ");
                System.Console.WriteLine("OrderID   CustomerID  TotalPrice  DateofOrder OrderStatus");
                foreach (OrderDetails order in orderDetailsList)
                {
                    System.Console.WriteLine($"{order.OrderID,-12}{order.CustomerID,-12}{order.TotalPrice,-12}{order.DateOfOrder.ToString("dd/MM/yyyy"),-12}{order.OrderStatus,-12}");
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
            System.Console.WriteLine($"Your balance as of now is : {currentLoggedInUser.WalletBalance}");
        }

        static void ShowHistory()
        {
            int count = 0;
            foreach (OrderDetails order in orderDetailsList)
            {
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus == OrderStatus.Cancelled)
                {
                    count += 1;
                }
            }
            if (count > 0)
            {
                System.Console.WriteLine("Here is order history : ");
                System.Console.WriteLine("OrderID   CustomerID  TotalPrice  DateofOrder OrderStatus");
                foreach (OrderDetails order in orderDetailsList)
                {
                    if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus == OrderStatus.Cancelled)
                    {
                        System.Console.WriteLine($"{order.OrderID,-12}{order.CustomerID,-12}{order.TotalPrice,-12}{order.DateOfOrder.ToString("dd/MM/yyyy"),-12}{order.OrderStatus,-12}");
                    }
                }
            }
            else
            {
                System.Console.WriteLine("There is no order History");
            }
        }
    }
}