using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount
{
    public enum DressInfo {Ladieswear,Menswear,Childrenswear}
    public abstract class Dress
    {
        public DressInfo DressInfo{get;set;}
        public string DressName { get; set; }
        public double Price {get;set;}
        public double TotalPrice {get;set;}
        public abstract void GetDressInfo();
        public abstract void DisplayInfo();

    }
}