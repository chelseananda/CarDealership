using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Memo
    {
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; }
        public int CarSerial { get; set; }
        public string PurchaseDate {get;set;}
        public int NetPrice { get; set; }
        public int OtherFees { get; set; }
        public int EmployeeID { get; set; }

    }
}
