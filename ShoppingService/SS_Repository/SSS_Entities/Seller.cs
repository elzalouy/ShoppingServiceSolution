using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS_Repository
{
    public class Seller
    {
        public int Seller_ID { get; set; }
        public string Seller_Name { get; set; }
        public string Seller_Email { get; set; }
        public string Seller_CreditID { get; set; }
        public long Seller_Salary { get; set; }
        public string Seller_Country { get; set; }
        public string Seller_Address { get; set; }
        public virtual Account Seller_Account { get; set; }

    }
}