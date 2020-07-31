﻿using System;
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
                    eventORM = new EventORM(Inventory);

                return eventORM;
            }
        }
    }
}
