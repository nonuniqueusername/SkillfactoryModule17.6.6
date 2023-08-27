using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillfactoryModule17._6._6
{
    public class RegularAccount : Account, IAccount
    {
        public RegularAccount()
        {
            Type = "Обычный";
        }
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            Interest -= Balance < 1000 
                ? Balance * 0.2 
                : Balance * 0.4;
        }
    }
}
