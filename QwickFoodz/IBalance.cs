using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public interface IBalance
    {
        //Property
        public double WalletBalance {get;}

        //Field
        public void WalletRecharge(double amount);
        public void DeductBalance(double amount);

    }
}