using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingQuestion
{
    public interface ICalculate
    {
        public void Deposit(double amount);
        public void Withdraw(double amount);
        public void BalanceCheck();
    }
}