using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class OrderProducts : EntityBase
    {
        public int OrderID { get; set; }

        public int ProdcutID { get; set; }
              
        public Product Product { get; set; }
          
        public int Quantity { get; set; }
    }
}