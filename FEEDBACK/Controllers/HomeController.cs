
using FEEDBACK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FEEDBACK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        CSDL_FEEDBACK db = new CSDL_FEEDBACK();
        public ActionResult Danhsach_KS()
        {
            return View(db.DM_KHACHSAN.ToList());
        }
        /********************************************************************/
        public ActionResult Create_KS()
        {
            return View();
        }

        public ActionResult Edit_KS()
        {
            return View();
        }

        public ActionResult EEEit_KS()
        {
            return View();
        }




    }
}