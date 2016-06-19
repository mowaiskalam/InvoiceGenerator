using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InvoiceGenerator.Helper
{
    class UserSession
    {
        public static int? UserID { get; set; }

        public static tblUser currentUser { get; set;}

        public static int? InvoiceID { get; set; }

        public static bool ShowPaidInvoice { get; set; }

    }
}
