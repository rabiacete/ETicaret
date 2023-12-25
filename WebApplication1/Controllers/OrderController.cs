using And.Eticaret.UI.Web.Models.Sınıflar;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class OrderController : AndControllerBase
    {
        // GET: Order
        [Route("Siparisver")]
        public ActionResult AddressList()
        {
            var db = new Context();
            var data = db.Addresses.Where(x => x.UserID == LoginUserID).ToList();
            return View(data);
        }

        public ActionResult CreateUserAddress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUserAddress(UserAddress entity)
        {
            entity.CreateDate = DateTime.Now;
            entity.CreateUserID = LoginUserID;
            entity.IsActive = true;
            entity.UserID = LoginUserID;


            var db = new Context();
            db.Addresses.Add(entity);
            db.SaveChanges();

            var userAddressId = entity.ID;
            return RedirectToAction("CreateOrder", new { userAddressId });

           // return RedirectToAction("AddressList");
        }

        public ActionResult CreateOrder(int? UserAddressID)
        {
            //useraddres null kontrolü
            if(!UserAddressID.HasValue)
            {
                // userAddressId değeri null ise hata mesajını verebilir veya başka bir işlem yapabilirsiniz.
                return RedirectToAction("AddressList");
            }

            var db = new Context();

            var sepet = db.Baskets.Include("Product").Where(x => x.UserID == LoginUserID).ToList();

            Order order = new Order();
            order.CreateDate = DateTime.Now;
            order.CreateUserID = LoginUserID;
            order.StatusID = 1;
            order.TotalProductPrice = sepet.Sum(x => x.Product.Price);
            order.TotalTaxPrice = sepet.Sum(x => x.Product.Tax);
            order.TotalDiscount = sepet.Sum((x) => x.Product.Discount);
            order.TotalPrice = order.TotalProductPrice + order.TotalTaxPrice;
            order.UserID = LoginUserID;
            //alttaki satırı ekledim
            order.UserAddressID= UserAddressID.Value;
            order.OrderProducts = new List<OrderProducts>();    

            foreach (var item in sepet)
            {
                order.OrderProducts.Add(new OrderProducts

                {
                    CreateDate = DateTime.Now,
                    CreateUserID = LoginUserID,
                    ProdcutID = item.ProductID,
                    Quantity = item.Quantity


                });

                db.Orders.Add(order);
               

            }
            db.SaveChanges();
            var orderid = db.Orders.Where(x => x.UserID == LoginUserID).LastOrDefault().ID;
           //    var orderId = db.Orders.Where(x => x.UserID == LoginUserID).OrderByDescending(x => x.CreateDate).Select(x => x.ID).FirstOrDefault();

            return RedirectToAction("Detail", new { id = orderid });
           // return View();

        }

        public ActionResult Detail(int id)
        {
            var db=new Context();
            var data = db.Orders.Include("OrderProducts")
                .Include("OrderProducts.Products")
                .Include("OrderPayment")
                .Include("Status")
                .Include("UserAddress")
                .Where(x => x.ID == id).FirstOrDefault();
            return View(data);

        }

        [Route("Siparişlerim")]
        public ActionResult Index()
        {
            var db=new Context();
            var data = db.Orders.Include("Status").Where(x => x.UserID == LoginUserID).ToList();
            return View(data);
        }
    }
}