using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInterest
{
    public class SBI : GetInterestInfo
    {
        public override double GetIntrestInfo()
        {
            return 0.075;
        }
    }
}