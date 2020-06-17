using Newtonsoft.Json;
using System.Collections.Generic;
using Shared;
using static SecretCellar.WebConnector;

namespace SecretCellar
{
    public class DataAccess
    {      
        private static WebConnector web = null;

        public DataAccess(string connectionString)
        {
            if(web == null)
                web = new WebConnector(connectionString);
        }
        public DataAccess() { }

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

        public EmployeeModel GetEmployee(int EmpID)
        {
            string result = web.DataGet($"api/Employee/{EmpID}");
            return (EmployeeModel)JsonConvert.DeserializeObject(result, typeof(EmployeeModel));
        }
        public void UpdateItem(Inventory inv)
        {
            web.DataPut($"api/inventory/{inv.Id}", inv);
        }

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
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }

        public static Item ConvertInvtoItem(Inventory inv)
        {
            return new Item(inv.Name, inv.Id, inv.Barcode, inv.Qty, 1, inv.Price, !inv.NonTaxable, inv.ItemType, inv.Bottles, 0, 0);
        }
    }
}
