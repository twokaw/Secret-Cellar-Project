using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretCellar
{
    /*
        DCA: Vehicle class(es) the cardholder is allowed to drive
        DCB: Restrictions on driving privileges (e.g., only automatic transmission)
        DCD: Additional privileges granted to the cardholder (e.g., transportation of hazardous material)
        DBA: Expiration date of the document
        DCS: Last name
        DAC: First name
        DAD: Middle name(s)
        DBD: Issue date of the document
        DBB: Date of birth
        DBC: Gender
        DAY: Eye color
        DAU: Height
        DAG: Address: Street name
        DAI: Address: City name
        DAJ: Address: State name
        DAK: Address: Postal code
        DAQ: ID number of the cardholder
        DCF: ID number of the document
        DCG: Country in which the document was issued
        DDE: Indicator that the last name is truncated
        DDF: Indicator that the first name is truncated
        DDG: Indicator that the middle name(s) are truncated 
     */


    public class Identification
    {
        public bool Valid
        {
            get
            {
                return !Underage && !Expired;
            }
        }
        public bool Underage
        {
            get
            {
                return CheckDate(DateOfBirth) < 21;
            }
        }
        public bool Expired
        {
            get
            {
                return DateTime.Now > ExpirationDate;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime ExpirationDate { get; set; }

        public static Identification CheckId(String barcode)
        { 
            CultureInfo enUS = new CultureInfo("en-US");
            if (barcode == null || barcode.Length < 130)
                return null;
            else
            {
                return new Identification()
                {
                    FirstName = GetStr(barcode, "DCS", "DDE"),
                    LastName = GetStr(barcode, "DAC", "DDF"), 
                    DateOfBirth = DateTime.ParseExact(GetStr(barcode, "DBB", "DBA"), "MMddyyyy", new CultureInfo("en-US")),
                    ExpirationDate = DateTime.ParseExact(GetStr(barcode, "DBA", "DBC"), "MMddyyyy", new CultureInfo("en-US"))
                };

            }
        }

        private static string GetStr(String barcode, String start, String end)
        {
            int s = barcode.IndexOf(start) + start.Length;
            return barcode.Substring(s, barcode.IndexOf(end) - s).Trim();
        }

        private static int CheckDate(DateTime date)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = DateTime.Today - date;
            return (zeroTime + span).Year;
        }
    }
}
