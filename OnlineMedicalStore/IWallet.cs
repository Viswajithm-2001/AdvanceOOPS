using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public interface IWallet
    {
        //Properties
        public double WalletBalance { get;}

        //Methods
        public void WalletRecharge(double amount);
        public void DeductBalance(double amount);
    }
}