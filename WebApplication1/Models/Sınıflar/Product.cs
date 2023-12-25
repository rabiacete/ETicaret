using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class Product:EntityBase
    {
        public string Name { get; set; }

        public int CategoryID { get; set; }
          
        public Category Category { get; set; }
             
        public string Brand { get; set; }
            
        public string Model { get; set; }
        
        public string ImageUrl { get; set; }
        
        public string Description { get; set; }
              
        public decimal Price { get; set; }
              
        public decimal Tax { get; set; } //vergi
                
        public decimal Discount { get; set; } //indirim
               
        public int Stock { get; set; }
                
        public bool IsActive { get; set; }
    }
}