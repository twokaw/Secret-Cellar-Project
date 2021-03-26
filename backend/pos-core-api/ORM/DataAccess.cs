using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace pos_core_api.ORM
{
    public class DataAccess
    {

        public static DataAccess Instance = new DataAccess();

        public DataAccess() { }

        private static InventoryORM inventoryORM = null;

        public InventoryORM Inventory
        {
            get
            {
                if (inventoryORM == null)
                    inventoryORM = new InventoryORM();

                return inventoryORM;
            }
        }

        private static CustomerORM customerORM = null;

        public CustomerORM Customer
        {
            get
            {
                if (customerORM == null)
                    customerORM = new CustomerORM();

                return customerORM;
            }
        }

        private static EventORM eventORM = null;

        public EventORM Event
        {
            get
            {
                if (eventORM == null)
                    eventORM = new EventORM(Inventory, Tax);

                return eventORM;
            }
        }

        private static TransactionORM transactionORM = null;
        public TransactionORM Transaction
        {
            get
            {
                if (transactionORM == null)
                    transactionORM = new TransactionORM();

                return transactionORM;
            }
        }

        private static EmployeeORM employeeORM = null;
        public EmployeeORM Employee
        {
            get
            {
                if (employeeORM == null)
                    employeeORM = new EmployeeORM();

                return employeeORM;
            }
        }

        private static InventoryTypeORM inventoryTypeORM = null;
        public InventoryTypeORM InventoryType
        {
            get
            {
                if (inventoryTypeORM == null)
                    inventoryTypeORM = new InventoryTypeORM();

                return inventoryTypeORM;
            }
        }

        private static PrinterORM printerORM = null;
        public PrinterORM Printer
        {
            get
            {
                if (printerORM == null)
                    printerORM = new PrinterORM();

                return printerORM;
            }
        }


        private static TaxORM taxORM = null;
        public TaxORM Tax
        {
            get
            {
                if (taxORM == null)
                    taxORM = new TaxORM();

                return taxORM;
            }
        }

        private static SupplierORM supplierORM = null;
        public SupplierORM Supplier
        {
            get
            {
                if (supplierORM == null)
                    supplierORM = new SupplierORM();

                return supplierORM;
            }
        }

        private static DiscountORM discountORM = null;
        public DiscountORM Discount
        {
            get
            {
                if (discountORM == null)
                    discountORM = new DiscountORM();

                return discountORM;
            }
        }
    }
}
