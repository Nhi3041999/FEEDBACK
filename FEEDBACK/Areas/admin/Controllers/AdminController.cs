using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FEEDBACK.Models;
using System.Web.Security;

namespace FEEDBACK.Areas.admin.Controllers
{
    public class AdminController : AuthorController
    {
        CSDL_FEEDBACK db = new CSDL_FEEDBACK();

        //
        // GET: /admin/Admin/
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Danhsach_KS()
        {
            return View(db.DM_KHACHSAN.ToList());
        }


    }
}