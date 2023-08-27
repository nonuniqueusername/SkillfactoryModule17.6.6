using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillfactoryModule17._6._6
{
    public abstract class Account
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }
    }
}
