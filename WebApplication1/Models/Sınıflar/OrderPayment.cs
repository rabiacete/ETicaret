using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class OrderPayment:EntityBase
    {
        public int OrderID { get; set; }
        public int OrderType { get; set; }
       public decimal Price { get; set; }       
       public string Bank { get; set; }
    }

public enum OrderType
{
    Havale = 0,
    Kredikarti = 1
      
     }

}