//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace WebApi.Models
//{
//    public class Inventory
//    {
//        /*
//         * Inventory description section of the database.
//         */
//        public uint InventoryID { get; set; }
//        public String Name { get; set; }
//        public uint SupplierID { get; set; }
//        public String Barcode { get; set; }
//        public Double RetailPrice { get; set; }
//        public String Description { get; set; }
//        public uint TypeID { get; set; }
//        public uint BottleDepositQty { get; set; }
//        public bool NonTaxable { get; set; }
//        public bool NonTaxableLocal { get; set; }

//        /*
//         * Inventory price section of the database.
//         */
//        public uint InventoryQty { get; set; }
//        public Double SupplierPrice { get; set; }
//        public DateTime PurchasedDate { get; set; }

//        /*
//         * Inventory type section of the database. 
//         */
//        public String InventoryType { get; set; }
//        public Double DiscountDown { get; set; } //Discount of  6 to 11 bottles.
//        public Double DiscountUp { get; set; } //Discount of 12 bottles or more.
//    }
//}
