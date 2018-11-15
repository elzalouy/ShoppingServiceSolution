using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS_Repository
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Client_Name { get; set; }
        public string Client_Email { get; set; }
        public DateTime Client_StartDate { get; set; }
        public virtual Account Client_Account { get; set; }
        public string Client_CreditID { get; set; }
    }
}   