using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    //Interface which will be inherited by Userdetails class
    public interface IBalance
    {
        //Properties
        public double Balance { get; }

        //Methods
        public void WalletRecharge(double amount);
        public void DeductBalance(double amount);
        
    }
}