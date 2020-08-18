using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FEEDBACK.Models;

namespace FEEDBACK.Areas.admin.Controllers
{
    public class LOAIKHACHSANsController : Controller
    {
        private CSDL_FEEDBACK db = new CSDL_FEEDBACK();

        // GET: admin/LOAIKHACHSANs
        public ActionResult Index()
        {
            return View(db.LOAIKHACHSANs.ToList());
        }

        // GET: admin/LOAIKHACHSANs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIKHACHSAN lOAIKHACHSAN = db.LOAIKHACHSANs.Find(id);
            if (lOAIKHACHSAN == null)
            {
                return HttpNotFound();
            }
            return View(lOAIKHACHSAN);
        }

        // GET: admin/LOAIKHACHSANs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/LOAIKHACHSANs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MALOAI_KS,GHICHU")] LOAIKHACHSAN lOAIKHACHSAN)
        {
            if (ModelState.IsValid)
            {
                db.LOAIKHACHSANs.Add(lOAIKHACHSAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lOAIKHACHSAN);
        }

        // GET: admin/LOAIKHACHSANs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIKHACHSAN lOAIKHACHSAN = db.LOAIKHACHSANs.Find(id);
            if (lOAIKHACHSAN == null)
            {
                return HttpNotFound();
            }
            return View(lOAIKHACHSAN);
        }

        // POST: admin/LOAIKHACHSANs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MALOAI_KS,GHICHU")] LOAIKHACHSAN lOAIKHACHSAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lOAIKHACHSAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lOAIKHACHSAN);
        }

        // GET: admin/LOAIKHACHSANs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIKHACHSAN lOAIKHACHSAN = db.LOAIKHACHSANs.Find(id);
            if (lOAIKHACHSAN == null)
            {
                return HttpNotFound();
            }
            return View(lOAIKHACHSAN);
        }

        // POST: admin/LOAIKHACHSANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LOAIKHACHSAN lOAIKHACHSAN = db.LOAIKHACHSANs.Find(id);
            db.LOAIKHACHSANs.Remove(lOAIKHACHSAN);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
