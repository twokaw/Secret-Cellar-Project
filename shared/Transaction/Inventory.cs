   using System;

namespace Shared
{
    public class Inventory: BaseItem
    {

        public uint InvMin { get; set; }
        public uint InvMax { get; set; }
        public double OrderIncrement { get; set; }
        
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
