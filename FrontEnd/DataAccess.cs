using Newtonsoft.Json;
using System.Collections.Generic;
using Shared;
using static SecretCellar.WebConnector;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SecretCellar
{
    public class DataAccess
    {      
        private static WebConnector web = null;
        public static DataAccess instance;
        private Image logo;
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
        public List<Transaction> GetSuspendedTransactions()
        {
            string result = web.DataGet($"api/Transaction/Suspended");
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
            string result = web.DataPost($"api/Transaction", transaction, resp);
            transaction.InvoiceID = uint.TryParse(result, out uint id) ? id : 0;

            return transaction.InvoiceID;
        }
        #endregion

        #region Customer
        public List<Customer> GetCustomer()
        {
            string result = web.DataGet("api/Customer");
            return JsonConvert.DeserializeObject<List<Customer>>(result);
        }

        public Customer GetCustomer(uint CustomerID)
        {
            string result = web.DataGet($"api/Customer/{CustomerID}");
            return JsonConvert.DeserializeObject<Customer>(result);
        }

        public uint UpdateCustomer(Customer customer)
        {
            Response resp = null;
            string result = web.DataPut($"api/Customer", customer, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        
        public uint NewCustomer(Customer customer)
        {
            Response resp = null;
            string result = web.DataPost($"api/Customer", customer, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        public void DeleteCustomer(Customer customer)
        {
            try { web.DataDelete($"api/Customer/{customer.CustomerID}");  }
            catch (Exception ex) { LogError(ex, "DeleteCustomer"); }
        }
        #endregion

        #region Discount
        public List<Discount> GetDiscount()
        {
            string result = web.DataGet("api/Discount");
            return JsonConvert.DeserializeObject<List<Discount>>(result);
        }

        public Discount GetDiscount(uint DiscountID)
        {
            string result = web.DataGet($"api/Discount/{DiscountID}");
            return JsonConvert.DeserializeObject<Discount>(result);
        }

        public uint UpdateDiscount(Discount Discount)
        {
            Response resp = null;
            string result = web.DataPut($"api/Discount", Discount, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        #endregion

        public void LogError(string message, string source, string notes = "")
        {
            Console.WriteLine($"{source} - {message}");
        }

        public void LogError(Exception error, string source, string notes = "")
        {
            LogError(error.Message, source, notes);
        }

        public  Image ReloadLogo()
        {

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Logo))
            {
                string logoPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{Properties.Settings.Default.Logo}";

                if (File.Exists(logoPath))
                    logo = Image.FromFile(logoPath);
            }

            if (logo == null)
                logo = Properties.Resources.Logo;
            
            return logo;
        }

        public Image ReloadLogo(string path)
        {
            
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                string imageFileName = Path.GetFileName(path);
                if (File.Exists($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{imageFileName}"))
                {
                    
                    if (MessageBox.Show("Image exists do you want to overwrite?","File Already exists",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.InitialDirectory = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";
                        saveFileDialog.FileName = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{ imageFileName}";
                        if (saveFileDialog.ShowDialog()== DialogResult.Cancel)
                        {
                            return ReloadLogo();
                        }
                        imageFileName = Path.GetFileName(saveFileDialog.FileName);
                    }


                    
                }

                File.Copy(path, $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{ imageFileName}");
                
                Properties.Settings.Default.Logo = imageFileName;
                Properties.Settings.Default.Save();
               
            }

           

            return ReloadLogo();
        }

    }
}
