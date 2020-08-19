using FEEDBACK.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace FEEDBACK.Areas.admin.Controllers
{

    public class Search_KSController : Controller
    {
        // GET: admin/Search_KS
       
        [HttpGet]
        public ActionResult Search(string searching)
        {
              CSDL_FEEDBACK db = new CSDL_FEEDBACK();
            
        var danhmuc_ks = db.DM_KHACHSAN.Where(n => n.MALOAI_KS == searching).ToList();
            string search = db.LOAIKHACHSANs.Where(m => m.MALOAI_KS == searching).Select(m => m.GHICHU).SingleOrDefault();
            ViewBag.Search = search;
            return View(danhmuc_ks);
        }
    }
}

