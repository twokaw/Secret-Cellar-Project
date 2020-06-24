using System;
using System.Collections.Generic;

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
