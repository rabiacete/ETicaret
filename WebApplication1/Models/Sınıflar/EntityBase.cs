using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

       public DateTime CreateDate { get; set; }

       public int CreateUserID { get; set; }
       
       public DateTime? UpdateDate { get; set; }
            
       public int? UpdateUserID { get; set; }
    }
}