using And.Eticaret.UI.Web.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CategoryController : AndControllerBase
    {
        // GET: Category

        [Route("Kategori/{isim}/{id}")]
        public ActionResult Index(string isim, int id)
        {
            var db = new Context();
        
           var data=   db.Products.Where(x => x.IsActive == true && x.CategoryID == id).ToList();

             ViewBag.category = db.Categories.Where(x => x.ID == id).FirstOrDefault();   
            return View(data);
        }
    }
}