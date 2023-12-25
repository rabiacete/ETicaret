using And.Eticaret.UI.Web.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace And.Eticaret.UI.Web.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Admin/AdminLogin
        Context db = new Context();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Email,string Password)
        {
           var data= db.Users.Where(x => x.Email == Email 
            && x.Password == Password
            && x.IsActive == true
            && x.IsAdmin == true).ToList();
            
            if (data.Count == 1) {
                Session["AdminLoginUser"] = data.FirstOrDefault();
                return Redirect("/admin");
            
            
            
            }
            else
            {
                return View();
            }

      
        }




    }
}