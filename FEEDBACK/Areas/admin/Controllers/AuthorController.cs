using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FEEDBACK.Areas.admin.Controllers
{
    public class AuthorController : Controller
    {

        public AuthorController()
        {
            String session = System.Web.HttpContext.Current.Session["ten_dn"] as String;
            if (System.Web.HttpContext.Current.Session["ten_dn"] == null || session != "admin")
            {

                System.Web.HttpContext.Current.Response.Redirect("~/");

            }

        }
        //
        // GET: /admin/Author/

    }
}