using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class IndirimKuponları : EntityBase
    {
        public string CouponCode { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime ExpiryDate { get; set; }

    

        // İndirim kuponunun bir siparişle ilişkisi
     


    }
}