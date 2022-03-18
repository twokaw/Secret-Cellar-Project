using System;
using System.Collections.Generic;

namespace Shared
{
    public class InventoryType:Tax 
    {
        public uint TypeId { get; set; }
        public string TypeName { get; set; }
        public uint Min_qty { get; set; }
        public uint Max_qty { get; set; }
        public uint Bottles { get; set; }
        public uint OrderIncrement { get; set; }

        public List<Discount> Discount { get; set; }
        public InventoryType()
        {
            Discount = new List<Discount>();
        }
    }
}
