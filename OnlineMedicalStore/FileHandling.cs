using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class FileHandling
    {
        //Create
        public static void Create()
        {
            //creating folder
            if (!Directory.Exists("MedicalStore"))
            {
                Directory.CreateDirectory("MedicalStore");
                System.Console.WriteLine("folder created successfully..");
            }
            //creating CSV files
            //Creating Userdetail csv.
            if (!File.Exists("MedicalStore/UserDetails.csv"))
            {
                File.Create("MedicalStore/UserDetails.csv").Close();
            }

            //Creating Ticket fair Details
            if (!File.Exists("MedicalStore/MedicineDetails.csv"))
            {
                File.Create("MedicalStore/MedicineDetails.csv").Close();
            }
            //Creating Travel HistoryDetails
            if (!File.Exists("MedicalStore/OrderDetails.csv"))
            {
                File.Create("MedicalStore/OrderDetails.csv").Close();
            }
        }

        //Readfromcsv
        public static void ReadFromCsv()
        {
            //UserDetails
            string[] userDetails = File.ReadAllLines("MedicalStore/UserDetails.csv");
            foreach (string user in userDetails)
            {
                UserDetails user1 = new UserDetails(user);
                Operations.userList.Add(user1);
            }

            //MedicineDetails
            string[] medicineDetails = File.ReadAllLines("MedicalStore/MedicineDetails.csv");
            foreach (string medicine in medicineDetails)
            {
                MedicineDetails medicine1 = new MedicineDetails(medicine);
                Operations.medicineList.Add(medicine1);
            }

            //OrderDetails
            string[] orderDetails = File.ReadAllLines("MedicalStore/OrderDetails.csv");
            foreach (string order in orderDetails)
            {
                OrderDetails order1 = new OrderDetails(order);
                Operations.orderList.Add(order1);
            }

        }

        //writetocsv
        public static void WriteToCsv()
        {
            //UserDetails
            string[] userDetails = new string[Operations.userList.Count];
            int i = 0;
            string userdetail;
            foreach (UserDetails user in Operations.userList)
            {
                userdetail = $"{user.UserID},{user.Name},{user.Age},{user.City},{user.PhoneNumber},{user.WalletBalance}";
                userDetails[i] = userdetail;
                i++;
            }
            File.WriteAllLines("MedicalStore/UserDetails.csv", userDetails);

            //OrderDetails
            string[] orderDetails = new string[Operations.orderList.Count];
            i = 0;
            string order;
            foreach (OrderDetails order1 in Operations.orderList)
            {
                order = $"{order1.OrderID},{order1.UserID},{order1.MedicineID},{order1.MedicineCount},{order1.TotalPrice},{order1.OrderDate.ToString("dd/MM/yyyy")},{order1.OrderStatus}";
                orderDetails[i] = order;
                i++;
            }
            File.WriteAllLines("MedicalStore/OrderDetails.csv", orderDetails);

            //TicketFair
            string[] medicineDetails = new string[Operations.medicineList.Count];
            i = 0;
            string Details;
            foreach (MedicineDetails medicine in Operations.medicineList)
            {
                Details = $"{medicine.MedicineID},{medicine.MedicineName},{medicine.AvailableCount},{medicine.Price},{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}";
                medicineDetails[i] = Details;
                i++;
            }
            File.WriteAllLines("MedicalStore/MedicineDetails.csv", medicineDetails);

        }
    }

}