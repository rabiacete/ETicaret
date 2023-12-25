using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class Category:EntityBase
    {
        public int ParentID { get; set; } = 0;
     
        public string Name { get; set; }
          
        public bool IsActive { get; set; }






    }
}