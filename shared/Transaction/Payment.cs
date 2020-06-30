using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Payment
    {
        public uint   PayId { get; set; }
        public string Method { get; set; }
        public string Number { get; set; }
        public double Amount { get; set; }
    }
}
