using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillfactoryModule17._6._6
{
    public class SalaryAccount : Account, IAccount
    {
        public SalaryAccount()
        {
            Type = "Зарплатный";
        }
        public void CalculateInterest()
        {
            Interest =  Balance * 0.5;
        }
    }
}
