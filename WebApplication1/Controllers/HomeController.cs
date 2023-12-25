using And.Eticaret.UI.Web.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace And.Eticaret.UI.Web.Controllers
{
    public class HomeController : AndControllerBase
    {

        Context db = new Context();

        // GET: Home



        [Route("hakkimizda")]
        public ActionResult hakkimizda()
        {
            return View();
        }


        public ActionResult Index()

        {
            ViewBag.IsLogin = this.IsLogin;
            var data = db.Products.OrderByDescending(x => x.CreateDate).Take(5).ToList();

            return View(data);
        }

        public PartialViewResult GetMenu()
        {

            var menus = db.Categories.Where(x => x.ParentID == 0).ToList();
            return PartialView(menus);

        }

        [Route("Uye-Giriş")]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Uye-Giriş")]
        public ActionResult Login(string Email, string Password)
        {
            var db = new Context();
            var users = db.Users.Where(x => x.Email == Email
            && x.Password == Password
            && x.IsActive == true
            && x.IsAdmin == false).ToList();

            if (users.Count == 1) {
                //giriş ok

                Session["LoginUserID"] = users.FirstOrDefault().ID;

                Session["LoginUser"] = users.FirstOrDefault();
                return Redirect("/");


            }
            else
            {
                ViewBag.Error = "Hatalı kullanıcı adı veya şifre";

                return View();


            }
        }

      
        
        
        [Route("Uye-Kayit")]

        public ActionResult CreateUser()
        {
            return View();
        }
        
        [HttpPost]
        [Route("Uye-Kayit")]
        public ActionResult CreateUser(User entity)
        {

            try
            {
                entity.CreateDate = DateTime.Now;
                entity.CreateUserID = 1;
                entity.IsActive = true;
                entity.IsAdmin = false;

                db.Users.Add(entity);
                db.SaveChanges();

                return Redirect("/");

            }


            catch (Exception ex)
            {


                
                return View();


            }




        }

   


    }
}