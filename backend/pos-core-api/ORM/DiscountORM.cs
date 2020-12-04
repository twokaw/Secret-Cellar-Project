using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class DiscountORM
    {
        readonly DbConn db = new DbConn();

        private const string SQLGET = @"
            SELECT receiptID, register, sold_datetime, customerID, empID, location, tax_exempt, discount, shipping
            FROM transaction
        ";
    }
}
