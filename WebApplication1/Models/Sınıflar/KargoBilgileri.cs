using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class KargoBilgileri:EntityBase
    {
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public DateTime ShipDate { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
    }
}