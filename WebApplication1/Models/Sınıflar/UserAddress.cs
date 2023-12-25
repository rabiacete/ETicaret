using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class UserAddress:EntityBase
    {

                public int UserID { get; set; }
                public User User { get; set; }
                public string Title { get; set; }

                public string City { get; set; }
                public string Address { get; set; }
                public bool IsActive { get; set; }



    }
}