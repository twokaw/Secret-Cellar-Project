using Newtonsoft.Json;
using System.Collections.Generic;
using Shared;
using static SecretCellar.WebConnector;
using System;

namespace SecretCellar
{
    public class DataAccess
    {      
        private static WebConnector web = null;
        public static DataAccess instance;
        public DataAccess(string connectionString)
        {
            if(web == null)
                web = new WebConnector(connectionString);
            instance = new DataAccess();
        }
        public DataAccess() { }

        #region Inventory
        public void DeleteItem(Inventory inv)
        {
            web.DataDelete ($"api/inventory/{inv.Id}");
        }  

        public List<Inventory> GetInventory()
        {
            string test = web.DataGet("api/inventory");
            return (List<Inventory>)JsonConvert.DeserializeObject(test, typeof(List<Inventory>));
        }

        public Inventory GetItem(string barcode)
        {
            if (!string.IsNullOrWhiteSpace(barcode))
            {
                string result = web.DataGet($"api/inventory/{barcode}");
                return (Inventory)JsonConvert.DeserializeObject(result, typeof(Inventory));
            }
            return null;
        }

        public uint UpdateItem(Inventory item)
        {
            Response resp = null;
            string result = web.DataPut($"api/Inventory/{item.Id}", item, resp);

            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }

        public uint InsertItem(Inventory item)
        {
            Response resp = null;
            string result = web.DataPost($"api/Inventory", item, resp);

            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        #endregion

        #region Employee
        public EmployeeModel GetEmployee(int EmpID)
        {
            string result = web.DataGet($"api/Employee/{EmpID}");
            return (EmployeeModel)JsonConvert.DeserializeObject(result, typeof(EmployeeModel));
        }
        #endregion

        #region Suppliers
        public List<Supplier> GetSuppliers()
        {
            string result = web.DataGet("api/Supplier");
            return JsonConvert.DeserializeObject<List<Supplier>>(result);
        }

        public Supplier GetSupplier(uint supplierID)
        {
            string result = web.DataGet($"api/Supplier/{supplierID}");
            return JsonConvert.DeserializeObject<Supplier>(result);
        }

        public uint UpdateSupplier(Supplier supplier)
        {
            Response resp = null;
            string result = web.DataPut($"api/Supplier", supplier, resp);

            if (uint.TryParse(result, out uint id))
                return id;
            else 
                return 0;
        }
        #endregion

        #region Tax
        public List<Tax> GetTax()
        {
            string result = web.DataGet("api/Tax");
            return JsonConvert.DeserializeObject<List<Tax>>(result);
        }

        public Tax GetTax(uint taxID)
        {
            string result = web.DataGet($"api/Tax/{taxID}");
            return JsonConvert.DeserializeObject<Tax>(result);
        }

        public uint UpdateTax(Tax tax)
        {
            Response resp = null;
            string result = web.DataPut($"api/Tax", tax, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        #endregion

        #region InventoryType
        public List<InventoryType> GetInventoryType()
        {
            string result = web.DataGet("api/InventoryType");
            return JsonConvert.DeserializeObject<List<InventoryType>>(result);
        }

        public InventoryType GetInventoryType(uint taxID)
        {
            string result = web.DataGet($"api/InventoryType/{taxID}");
            return JsonConvert.DeserializeObject<InventoryType>(result);
        }

        public InventoryType GetInventoryType(string name)
        {
            string result = web.DataGet($"api/InventoryType/name/{name}");
            return JsonConvert.DeserializeObject<InventoryType>(result);
        }

        public uint UpdateInventoryType(InventoryType invType)
        {
            Response resp = null;
            string result = web.DataPut($"api/InventoryType", invType, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }

        public uint DeleteInventoryType(uint typeId)
        {
            Response resp = null;
            string result = web.DataPut($"api/InventoryType/{typeId}", resp);
            return uint.TryParse(result, out uint id) ? id : 0;
        }
        #endregion

        #region Transaction
        public Transaction Get(uint transactionID)
        {
            string result = web.DataGet($"api/Transaction/{transactionID}");
            return JsonConvert.DeserializeObject<Transaction>(result);
        }
        public List<Transaction> Get()
        {
            string result = web.DataGet($"api/Transaction");
            return JsonConvert.DeserializeObject<List<Transaction>>(result);
        }
        public List<Transaction> Get(DateTime start, DateTime end )
        {
            string result = web.DataGet($"api/Transaction?start={start}&end={end}");
            return JsonConvert.DeserializeObject<List<Transaction>>(result);
        }
        public uint ProcessTransaction(Transaction transaction) 
        {
            Response resp = null;
            string result = web.DataPut($"api/Transaction", transaction, resp);
            return uint.TryParse(result, out uint id)? id: 0;
        }  
        #endregion
        public static Item ConvertInvtoItem(Inventory inv)
        {
            return new Item
            {
                Name = inv.Name,
                Id = inv.Id,
                Barcode = inv.Barcode,
                AllQty = inv.AllQty,
                BottleDeposit = inv.BottleDeposit,
                NumSold = 1,
                Price = inv.Price,
                NonTaxable = inv.NonTaxable, 
                ItemType = inv.ItemType,
                Bottles = inv.Bottles,
                SalesTax = inv.SalesTax,
                LocalSalesTax = inv.LocalSalesTax, 
                IdTax = inv.IdTax ,
                NonTaxableLocal = inv.NonTaxableLocal ,
                Discounts = inv.Discounts
            }
            ;
        }
    }
}
