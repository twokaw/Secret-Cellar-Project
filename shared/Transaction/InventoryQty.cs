using System;

namespace Shared
{
    public class InventoryQty
    {
        public InventoryQty()
        {
            PurchasedDate = DateTime.Now;
        }
        public uint Qty { get; set; }
        public double SupplierPrice { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
