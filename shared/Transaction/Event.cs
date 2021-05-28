using System;

namespace Shared
{
    public class Event: BaseItem
    {
        public Event() : this(0, 0.0) { }

        public Event(uint qty) : this(qty, 0.0) { }

        public Event(uint qty, double supplierPrice) {
            if (qty > 0) {
                base.AllQty.Add(new InventoryQty() {Qty = qty, SupplierPrice = supplierPrice});
			}
        }

        public double PreOrder { get; set; }
        public double AtDoor { get; set; }
        public DateTime Duration { get; set; }
        public DateTime EventDate { get; set; }
    }
}
