using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace And.Eticaret.UI.Web.Areas.Admin
{
    public class AdminControllerBase : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            var IsLogin = false;
            if (requestContext.HttpContext.Session["AdminLoginUser"] == null)
            {
                requestContext.HttpContext.Response.Redirect("/Admin/AdminLogin");
                //Admin Girişi Yapılmamış

            }
            else
            {
                base.Initialize(requestContext);

            }

            base.Initialize(requestContext);
        }


    }
}