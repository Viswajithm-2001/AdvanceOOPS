using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        //Field
        private static int s_medicineID = 100;
        //Properties
        public string MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medicineName,int count,double price,DateTime dateOfExpiry)
        {
            MedicineID = "MD"+(++s_medicineID);
            MedicineName = medicineName;
            AvailableCount = count;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }
        public MedicineDetails(string medicine)
        {
            string[] medicine1 = medicine.Split(",");
            ++s_medicineID;
            MedicineID = medicine1[0];
            MedicineName = medicine1[1];
            AvailableCount = int.Parse(medicine1[2]);
            Price = double.Parse(medicine1[3]);
            DateOfExpiry = DateTime.ParseExact(medicine1[4],"dd/MM/yyyy",null);
        }
    }
}