   using System;

namespace Shared
{
    public class Inventory: BaseItem
    {
        /*
         * Inventory description section of the database.
         */
        public uint SupplierID { get; set; }

        /*
         * Inventory price section of the database.
         */
        public DateTime PurchasedDate
        {
            get
            {
                DateTime last = DateTime.MinValue;
                AllQty.ForEach(x => last = (last < x.PurchasedDate) ? x.PurchasedDate : last);
                return last;
            }
        }
    }
}
