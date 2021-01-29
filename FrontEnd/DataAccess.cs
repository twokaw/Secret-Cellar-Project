using Newtonsoft.Json;
using System.Collections.Generic;
using Shared;
using static SecretCellar.WebConnector;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;

namespace SecretCellar
{
    public class DataAccess
    {
        private static WebConnector web = null;
        public static DataAccess instance;
        private Image logo;
        private static List<PictureBox> pictureBoxes = new List<PictureBox>();
        public DataAccess(string connectionString)
        {
            if (web == null)
                web = new WebConnector(connectionString);
            instance = new DataAccess();
        }
        public DataAccess() { }

        #region Inventory
        public void DeleteItem(Inventory inv)
        {
            web.DataDelete($"api/inventory/{inv.Id}");
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
        public Transaction GetTransactions(uint transactionID)
        {
            string result = web.DataGet($"api/Transaction/{transactionID}");
            return JsonConvert.DeserializeObject<Transaction>(result);
        }
        public List<Transaction> GetTransactions()
        {
            string result = web.DataGet($"api/Transaction");
            return JsonConvert.DeserializeObject<List<Transaction>>(result);
        }
        public List<Transaction> GetSuspendedTransactions()
        {
            string result = web.DataGet($"api/Transaction/Suspended");
            return JsonConvert.DeserializeObject<List<Transaction>>(result);
        }
        public List<Transaction> GetTransactions(DateTime start, DateTime end )
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
        public bool DeleteTransaction(uint invoiceId)
        {
            Response resp = null;
            web.DataDelete($"api/Transaction/{invoiceId}", resp);

            return resp.StatusCode != System.Net.HttpStatusCode.InternalServerError;
        }

        public bool DeletePayment(uint invoiceId, uint payId)
        {
            Response resp = null;
            web.DataDelete($"api/Transaction/payment/{invoiceId}/{payId}", resp);

            return resp.StatusCode == System.Net.HttpStatusCode.OK;
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
            try { web.DataDelete($"api/Customer/{customer.CustomerID}"); }
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

        public Image ImportLogo()
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

        public Image ImportLogo(string path)
        {

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                string imageFileName = Path.GetFileName(path);
                if (File.Exists($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{imageFileName}"))
                {

                    if (MessageBox.Show("Image exists do you want to overwrite?", "File Already exists", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.InitialDirectory = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";
                        saveFileDialog.FileName = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{ imageFileName}";
                        if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                        {
                            return ImportLogo();
                        }
                        imageFileName = Path.GetFileName(saveFileDialog.FileName);
                    }



                }

                //File.Create($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{ imageFileName}"); when this is used it crashes saying it is being used by another process

                File.Copy(path, $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{ imageFileName}",true);

                //File.Replace(path, $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{ imageFileName}", $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{imageFileName + ".bak"}"); works but moves instead of duplicating file and creates a .bak file in the destination folder
                Properties.Settings.Default.Logo = imageFileName;
                Properties.Settings.Default.Save();

                /*public static void ReplaceFile(string fileToMoveAndDelete, string fileToReplace, string backupOfFileToReplace)
                {
                    // Create a new FileInfo object.    
                    FileInfo fInfo = new FileInfo(fileToMoveAndDelete);

                    // replace the file.    
                    fInfo.Replace(fileToReplace, backupOfFileToReplace, false);
                }*/

            }



            return ImportLogo();
        }

        public List<string> GetImageFiles()
        {
            List<string> result = new List<string>();
            string targetDirectory = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)} ";
            string[] extensions = new[] { "jpg", "jpeg", "bmp", "gif", "png" };
            string[] fileEntries = Directory.GetFiles(targetDirectory).Where(f => extensions.Contains(f.ToLower().Split('.').Last().Trim())).ToArray();
            foreach (string fileName in fileEntries)
                result.Add(Path.GetFileName(fileName));

            return result;
        }

        public Image GetImage(string file)
        {

            if (!string.IsNullOrEmpty(file))
            {
                string logoPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{file}";

                if (File.Exists(logoPath))
                    logo = Image.FromFile(logoPath);
            }

            if (logo == null)
                logo = ImportLogo();

            return logo;
        }

        public void ChangeLogo(string imageFileName)
        {
            Properties.Settings.Default.Logo = imageFileName;
            Properties.Settings.Default.Save();
            ImportLogo();
            RefreshLogos();
        }

        public void AddPictureBox(PictureBox pictureBox)
        {
            if (!pictureBoxes.Contains(pictureBox))
            {
                pictureBoxes.Add(pictureBox);
                pictureBox.Image = ImportLogo();
            }
        }

        public void RemovePictureBox(PictureBox pictureBox)
        {
            pictureBoxes.Remove(pictureBox);
        }

        public void RefreshLogos()
        {
            pictureBoxes.ForEach(x => x.Image = logo);
        }
    }
}


    

