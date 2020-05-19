using Newtonsoft.Json;
using System.Collections.Generic;
using Shared;

namespace SecretCellar
{
    public class DataAccess
    {      
        private readonly WebConnector web ;


        public DataAccess(string connectionString)
        {
            web = new WebConnector(connectionString);
        }

        public void DeleteItem(Inventory inv)
        {
            web.DataDelete ($"api/inventory/{inv.InventoryID}");
        }  

        public List<Inventory> GetInventory()
        {
            string test = web.DataGet("api/inventory");
            return (List<Inventory>)JsonConvert.DeserializeObject(test, typeof(List<Inventory>));
           
        }

        public Inventory GetItem(string barcode)
        {
            string result = web.DataGet($"api/inventory/{barcode}");
            return (Inventory)JsonConvert.DeserializeObject(result, typeof(Inventory));
        }
        public EmployeeModel GetEmployee(int EmpID)
        {
            string result = web.DataGet($"api/Employee/{EmpID}");
            return (EmployeeModel)JsonConvert.DeserializeObject(result, typeof(EmployeeModel));
        }
        public void UpdateItem(Inventory inv)
        {
            web.DataPut($"api/inventory/{inv.InventoryID}", inv);
        }
    }
}
