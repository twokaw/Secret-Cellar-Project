﻿
namespace Shared
{
    public class BaseCustomer
    {
        public uint CustomerID { get; set; }
        public double CustomerDiscount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public bool IsWholesale { get; set; }
        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                    return FirstName;
                else if (string.IsNullOrWhiteSpace(FirstName))
                    return LastName;
                else
                    return $"{LastName}, {FirstName}";
            }
        }
    }

    public class Customer: BaseCustomer 
    {

        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public double BalanceDue { get; set; }
        public double Credit { get; set; }
        public uint SuspendedTransactions { get; set; }

    }
}