using And.Eticaret.UI.Web.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class AndControllerBase: Controller
    {
        //kullanıcı login kontrolü
        public bool IsLogin { get; private set; }    

        //Giriş Yapmış Kişinin Idsi
        public int LoginUserID { get; private set; }
        
        //LoginUserEntity
        public User LoginUserEntity { get; private set; }
        protected override void Initialize(RequestContext requestContext)
        {
            // Session["LoginUserID"] = users.FirstOrDefault().ID;
            //     Session["LoginUser"] = users.FirstOrDefault();


            if (requestContext.HttpContext.Session["LoginUserID"]!=null)
            {
                //kullanıcı giriş yapmış
                IsLogin= true;
                LoginUserID = (int)requestContext.HttpContext.Session["LoginUserID"];
                LoginUserEntity = (And.Eticaret.UI.Web.Models.Sınıflar.User)requestContext.HttpContext.Session["LoginUser"];

            }



            base.Initialize(requestContext);
        }
    }
}