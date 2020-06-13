using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
    public class InventoryType: Tax
    {
        public uint TypeId { get; set; }
        public string TypeName { get; set; }
        public List<Discount> Discount { get; set; }
        public InventoryType()
        {
            Discount = new List<Discount>();
        }
    }
}
