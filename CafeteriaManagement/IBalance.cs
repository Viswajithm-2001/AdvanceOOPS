using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public interface IBalance
    {
        protected double WalletBalance{get;}

        public void WalletRecharge(double amount);
        public void DeductAmount(double amount);
    }
}