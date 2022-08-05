using pos_core_api.IORM;
using pos_core_api.ORM.Test;

namespace pos_core_api.ORM
{
    public class DataAccess
    {

        public static readonly DataAccess Instance = new();

        /*
        public static DataAccess Instance 
        {
            get
            {
                return instance;
            }
        }
        */

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

        private static ICustomerNoteORM customerNoteORM = null;


        public bool Test = false;
        public bool Dev = false;
        public ICustomerNoteORM CustomerNote
        {
            get
            {

                if (customerNoteORM == null)
                { 
                    if (Test)
                        customerNoteORM = new CustomerNoteTestORM();
                    else if(Dev)
                        customerNoteORM = new CustomerNoteORM();
                    else
                        customerNoteORM = new CustomerNoteORM();
                }


                return customerNoteORM;
            }
        }

        private static CustomerOrderORM customerOrderORM = null;

        public CustomerOrderORM CustomerOrder
        {
            get
            {
                if (customerOrderORM == null)
                    customerOrderORM = new CustomerOrderORM(Transaction);

                return customerOrderORM;
            }
        }

        private static EventORM eventORM = null;

        public EventORM Event
        {
            get
            {
                if (eventORM == null)
                    eventORM = new EventORM(Inventory, Tax, InventoryType);

                return eventORM;
            }
        }

        private static TransactionORM transactionORM = null;
        public TransactionORM Transaction
        {
            get
            {
                if (transactionORM == null)
                    transactionORM = new TransactionORM(Customer);

                return transactionORM;
            }
        }

        private static EmployeeTypeORM employeeTypeORM = null;
        public EmployeeTypeORM EmployeeType
        {
            get
            {
                if (employeeTypeORM == null)
                    employeeTypeORM = new EmployeeTypeORM();

                return employeeTypeORM;
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
