﻿using Newtonsoft.Json;
using System.Collections.Generic;
using Shared;
using static SecretCellar.WebConnector;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using System.IO.Ports;
using NCR_Printer;

namespace SecretCellar
{
    public class DataAccess
    {
        private static WebConnector web = null;
        public static DataAccess instance;
        private Image logo;
        private static readonly List<PictureBox> pictureBoxes = new List<PictureBox>();
        public DataAccess(string connectionString)
        {
            instance = new DataAccess();
            ErrorLogging.Path = Application.StartupPath;

            if (web == null)
                web = new WebConnector(connectionString);
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
            string result = web.DataPut($"api/Inventory", item, resp);

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
        public List<Transaction> GetTransactions(DateTime start, DateTime end)
        {
            string result = web.DataGet($"api/Transaction?start={start}&end={end}");
            return JsonConvert.DeserializeObject<List<Transaction>>(result);
        }
        public List<Transaction> GetCustomerTransactions(uint customerID, bool includeItems = true, bool includePayments = true)
        {
            string result = web.DataGet($"api/Transaction/Customer/{customerID}?includeItems={includeItems}&includePayments={includePayments}");
            return JsonConvert.DeserializeObject<List<Transaction>>(result);
        }
        public List<Transaction> GetCustomerTransactions(uint customerID, DateTime start, DateTime end, bool includeItems = true, bool includePayments = true)
        {
            string result = web.DataGet($"api/Transaction/Customer/{customerID}?start={start}&end={end}&includeItems={includeItems}&includePayments={includePayments}");
            return JsonConvert.DeserializeObject<List<Transaction>>(result); //yyyy-MM-dd%20HH%3Amm%3As
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

            return resp?.StatusCode != System.Net.HttpStatusCode.InternalServerError;
        }

        public bool DeletePayment(uint invoiceId, uint payId)
        {
            Response resp = null;
            web.DataDelete($"api/Transaction/payment/{invoiceId}/{payId}", resp);

            return resp.StatusCode == System.Net.HttpStatusCode.OK;
        }

        #endregion

        #region Customer
        private List<Customer> customers = null;
        private DateTime customerLastUpdate = DateTime.MinValue;
        
        public List<Customer> GetCustomer(bool force = false)
        {
            if(force || customers == null || customerLastUpdate.AddMinutes(15) < DateTime.Now )
            {
                string result = web.DataGet("api/Customer");
                customers =  JsonConvert.DeserializeObject<List<Customer>>(result);
                customerLastUpdate = DateTime.Now;
            }
            return customers;
        }

        public   Customer GetCustomer(uint customerID, bool force = false)
        {
            Customer c = null;
            if (force)
            {
                string result = web.DataGet($"api/Customer/{customerID}");
                c = JsonConvert.DeserializeObject<Customer>(result);
            }
            else
            {
               c =  GetCustomer().FirstOrDefault(x => x.CustomerID == customerID);
            }

            return c;
        }

        public List<Customer> GetCustomer(string cust_name, bool force = false)
        {
            return GetCustomer(force)
                .Where(x => (x.LastName.IndexOf(cust_name, StringComparison.OrdinalIgnoreCase) >= 0) || 
                             x.FirstName.IndexOf(cust_name, StringComparison.OrdinalIgnoreCase) >= 0 ||
                             x.PhoneNumber.IndexOf(cust_name, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(x => x.LastName)
                .ToList();
        }

        public Customer GetCustomerByPhone(string phone, bool force = false)
        {
            Customer c = null;
            if (force)
            {
                string result = web.DataGet($"api/Customer/phone/{phone}");
                c = JsonConvert.DeserializeObject<Customer>(result);
            }
            else
            {
                c = GetCustomer().FirstOrDefault(x => x.PhoneNumber == phone);
            }

            return c;
        }

        public uint UpdateCustomer(Customer customer)
        {
            Response resp = null;
            string result = web.DataPut($"api/Customer", customer, resp);
            GetCustomer(true);

            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }

        public uint NewCustomer(Customer customer)
        {
            Response resp = null;
            string result = web.DataPost($"api/Customer", customer, resp);
            GetCustomer(true);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        public void DeleteCustomer(Customer customer)
        {
            try { 
                web.DataDelete($"api/Customer/{customer.CustomerID}");
                GetCustomer(true);
            }
            catch (Exception ex) { LogError(ex, "DeleteCustomer"); }
        }
        #endregion

        #region CustomerNote
        public List<CustomerNote> GetCustomerNotes(uint typeId = 0)
        {
            string result = web.DataGet($"api/CustomerNote?typeID={typeId}");
            return JsonConvert.DeserializeObject<List<CustomerNote>>(result);
        }

        public List<CustomerNote> GetCustomerNotes(uint customerID, uint typeId = 0)
        {
            string result = web.DataGet($"api/CustomerNote/{customerID}?typeID={typeId}");
            return JsonConvert.DeserializeObject<List<CustomerNote>>(result);
        }


        public uint UpdateCustomerNote(CustomerNote customerNote)
        {
            Response resp = null;
            string result = web.DataPut($"api/CustomerNote", customerNote, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }

        public uint NewCustomerNote(CustomerNote customerNote)
        {
            Response resp = null;
            string result = web.DataPost($"api/CustomerNote", customerNote, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        public void DeleteCustomerNote(CustomerNote customerNote)
        {
            try { web.DataDelete($"api/CustomerNote/{customerNote.IdNote}"); }
            catch (Exception ex) { LogError(ex, "DeleteCustomerNote"); }
        }
        #endregion

        #region CustomerFavorite
        public List<CustomerFavorites> GetCustomerFavorites()
        {
            string result = web.DataGet($"api/Customer/Favorite");
            return JsonConvert.DeserializeObject<List<CustomerFavorites>>(result);
        }

        public CustomerFavorites GetCustomerFavorite(uint customerID)
        {
            string result = web.DataGet($"api/Customer/Favorite/{customerID}");
            return JsonConvert.DeserializeObject<CustomerFavorites>(result);
        }

        public void AddCustomerFavorite(uint customerID, uint InventoryID)
        {
            web.DataPut($"api/Customer/Favorite/{customerID}/{InventoryID}");
        }

        public void DeleteCustomerFavorite(uint customerID, uint InventoryID)
        {
            web.DataDelete($"api/Customer/Favorite/{customerID}/{InventoryID}");
        }

        #endregion
        #region CustomerOrder
        public List<CustomerOrder> GetCustomerOrder(bool includeHistory = false)
        {
            string result = web.DataGet($"api/CustomerOrder?includeHistory={includeHistory }");
            return JsonConvert.DeserializeObject<List<CustomerOrder>>(result);
        }

        public CustomerOrder GetCustomerOrderforCustomer(uint customerID, bool includeHistory = false)
        {
            string result = web.DataGet($"api/CustomerOrder/{customerID}?includeHistory={includeHistory }");
            return JsonConvert.DeserializeObject<CustomerOrder>(result);
        }
        public CustomerOrder GetCustomerOrder(uint customerOrderID, bool includeHistory = false)
        {
            string result = web.DataGet($"api/CustomerOrder/order/{customerOrderID}?includeHistory={includeHistory }");
            return JsonConvert.DeserializeObject<CustomerOrder>(result);
        }

        public uint UpdateCustomerOrder(CustomerOrder customerOrder)
        {
            Response resp = null;
            string result = web.DataPut($"api/CustomerOrder", customerOrder, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }

        public uint NewCustomerOrder(CustomerOrder customerOrder)
        {
            Response resp = null;
            string result = web.DataPost($"api/CustomerOrder", customerOrder, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        public void DeleteCustomerOrder(CustomerOrder customerOrder)
        {
            try { web.DataDelete($"api/CustomerOrdere/{customerOrder.CustomerOrderID}"); }
            catch (Exception ex) { LogError(ex, "DeleteCustomerOrder"); }
        }

        #endregion
        #region NoteType
        public List<NoteType> GetNotesTypes()
        {
            string result = web.DataGet($"api/CustomerNote/NoteType");
            return JsonConvert.DeserializeObject<List<NoteType>>(result);
        }


        public uint UpdateNoteType(NoteType noteType)
        {
            Response resp = null;
            string result = web.DataPut($"api/CustomerNote/NoteType", noteType, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }

        public uint NewNoteType(NoteType noteType)
        {
            Response resp = null;
            string result = web.DataPost($"api/CustomerNote/NoteType", noteType, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        public void DeleteNoteType(NoteType noteType)
        {
            try { web.DataDelete($"api/CustomerNote/NoteType/{noteType.IdNoteType}"); }
            catch (Exception ex) { LogError(ex, "DeleteCustomerNoteType"); }
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
        public void DeleteDiscount(Discount discount)
        {
            try { web.DataDelete($"api/Discount/{discount.DiscountID}"); }
            catch (Exception ex) { LogError(ex, "DeleteDiscount"); }
        }
        #endregion

        #region Printer
        public List<Printer> GetPrinter()
        {
            string result = web.DataGet("api/Printer");
            return JsonConvert.DeserializeObject<List<Printer>>(result);
        }

        public Printer GetPrinter(uint PrinterId)
        {
            string result = web.DataGet($"api/Printer/{PrinterId}");
            return JsonConvert.DeserializeObject<Printer>(result);
        }

        public string GetPrinterMake(uint makeId)
        {
            string result = web.DataGet($"api/Printer/Make/{makeId}");
            return result;
        }

        public List<string> GetPrinterMake()
        {
            string result = web.DataGet($"api/Printer/Make");
            return JsonConvert.DeserializeObject<List<string>>(result);
        }

        public uint UpdatePrinter(Printer  printer)
        {
            Response resp = null;
            string result = web.DataPut($"api/Printer", printer , resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }

        public uint NewPrinter(Printer printer)
        {
            Response resp = null;
            string result = web.DataPost($"api/Printer", printer, resp);
            if (uint.TryParse(result, out uint id))
                return id;
            else
                return 0;
        }
        public void DeletePrinter(Printer printer)
        {
            try { web.DataDelete($"api/printer/{printer.ModelId}"); }
            catch (Exception ex) { LogError(ex, "DeletePrinter"); }
        }
        #endregion

        #region Event
        public List<Event> GetEvent()
        {
            string result = web.DataGet("api/Event");
            return JsonConvert.DeserializeObject<List<Event>>(result);
        }

        public Event GetEvent(uint id)
        {
            string result = web.DataGet($"api/Event/id/{id}");
            return JsonConvert.DeserializeObject<Event>(result);
        }
        public Event GetEvent(string barcode)
        {
            string result = web.DataGet($"api/Event/{barcode}");
            return JsonConvert.DeserializeObject<Event>(result);
        }

        public uint UpdateEvent(Event updatedEvent)
        {
            Response resp = null;
            string result = web.DataPut($"api/Event/", updatedEvent, resp);

            return uint.TryParse(result, out uint id) ? 0 : id;
        }

        public uint CreateEvent(Event newEvent)
        {
            Response resp = null;
            string result = web.DataPost($"api/Event/", newEvent, resp);

            return uint.TryParse(result, out uint id) ? 0 : id;
        }

        public void DeleteEvent(uint eventId) {
            try { web.DataDelete($"api/Event/{eventId}"); }
            catch (Exception e) { LogError(e, "DeleteEvent"); }
        }

        public List<EventWaitlistItem> GetEventsWaitlists() {
            string result = web.DataGet("api/Event/Waitlists");
            return JsonConvert.DeserializeObject<List<EventWaitlistItem>>(result);
        }

        public uint AddEventWaitlistItem(EventWaitlistItem newEventWaitlistItem) {
            Response resp = null;
            string result = web.DataPost($"api/Event/Waitlists", newEventWaitlistItem, resp);

            return uint.TryParse(result, out uint id) ? 0 : id;
        }
        
        public void DeleteEventWaitlistItem(uint eventId, uint customerId) {
            try { web.DataDelete($"api/Event/Waitlists/Delete/eventId={eventId}&customerId={customerId}"); }
            catch (Exception e) { LogError(e, "DeleteEvent"); }
        }



        #endregion

        #region Error logging
        public void LogError(string message, string source, string notes = "")
        {
            Console.WriteLine($"{source} - {message}");
            Shared.ErrorLogging.WriteToErrorLog(message, source, notes);
        }

        public void LogError(Exception error, string source, string notes = "")
        {
            LogError(error.Message, source, notes);
        }

       
        #endregion

        #region Logo
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
        public string LogoName()
        {
            return Properties.Settings.Default.Logo;
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
                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            InitialDirectory = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}",
                            FileName = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{ imageFileName}"
                        };
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
            result.Add("");
            foreach (string fileName in fileEntries)
                result.Add(Path.GetFileName(fileName));

            return result;
        }

        public Image GetImage()
        {
            return ImportLogo();
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
#endregion

        public void OpenCashDrawer() {
            try {
                if (SerialPort.GetPortNames().Contains(Properties.Settings.Default.CashDrawerPort))
                    new CashDrawer(Properties.Settings.Default.CashDrawerPort).OpenDrawer();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


    

