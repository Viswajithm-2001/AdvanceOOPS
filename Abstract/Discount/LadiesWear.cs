using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount
{
    public class LadiesWear : Dress
    {
        public override void GetDressInfo()
        {
            DressInfo = DressInfo.Menswear;
            System.Console.WriteLine("Enter Dress name : ");
            DressName = Console.ReadLine();
            System.Console.WriteLine("Enter the Price Detail: ");
            Price = double.Parse(Console.ReadLine());
            TotalPrice = Price - (0.2*Price);
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"Dress Name : {DressName}");
            System.Console.WriteLine($"Dress Type : {DressInfo}");
            System.Console.WriteLine($"Actual Price : {Price}");
            System.Console.WriteLine($"Discount Price : {TotalPrice}");

        }
    }
}