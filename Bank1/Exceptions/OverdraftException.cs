using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Exceptions
{
    public class OverdraftException : Exception
    {
        public OverdraftException(string msg) : base(msg) { }
    }
}
