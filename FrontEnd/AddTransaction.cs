using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SecretCellar
{
    public class AddTransaction
    {
        public string Barcode;
        public string Description;
        public double Price;
        public int RegisterNumber;
        public DateTime SoldDateTime;
        public int EmpID;
        public int CustomerID;
        public double DiscountAmount;
        public double SubTotal;
        public double Total;
        public string PaymentMethod;
        public double Discount;
        public string DiscountReason;
        public double CalculatedTax;

        public AddTransaction(string Barcode, string Description, double Price)
        {
            this.Barcode = Barcode;
            this.Description = Description;
            this.Price = Price;
        }



    }
}
