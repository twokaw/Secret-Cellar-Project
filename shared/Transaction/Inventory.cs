using System;

namespace Shared
{
    public class Inventory: BaseItem
    {
        /*
         * Inventory description section of the database.
         */
        public uint SupplierID { get; set; }
        public double RetailPrice { get; set; }
        public string Description { get; set; }
        public uint TypeID { get; set; }

        /*
         * Inventory price section of the database.
         */
        public double SupplierPrice { get; set; }
        public DateTime PurchasedDate { get; set; }

        /*
         * Inventory type section of the database. 
         */
        public double DiscountDown { get; set; } //Discount of  6 to 11 bottles.
        public double DiscountUp { get; set; } //Discount of 12 bottles or more.
    }
}
