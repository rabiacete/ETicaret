using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class Basket:EntityBase
    {
        public int UserID { get; set; }
  
        public int ProductID { get; set; }
              
        public Product Product { get; set; }
            
        public int Quantity { get; set; }


    }
}