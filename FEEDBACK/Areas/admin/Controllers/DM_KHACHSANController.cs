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
    public class DM_KHACHSANController : Controller
    {
        private CSDL_FEEDBACK db = new CSDL_FEEDBACK();

        // GET: admin/DM_KHACHSAN
        public ActionResult Index()
        {
            var dM_KHACHSAN = db.DM_KHACHSAN.Include(d => d.LOAIKHACHSAN);
            return View(dM_KHACHSAN.ToList());
        }

        // GET: admin/DM_KHACHSAN/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DM_KHACHSAN dM_KHACHSAN = db.DM_KHACHSAN.Find(id);
            if (dM_KHACHSAN == null)
            {
                return HttpNotFound();
            }
            return View(dM_KHACHSAN);
        }

        // GET: admin/DM_KHACHSAN/Create
        public ActionResult Create()
        {
            ViewBag.MALOAI_KS = new SelectList(db.LOAIKHACHSANs, "MALOAI_KS", "GHICHU");
            return View();
        }

        // POST: admin/DM_KHACHSAN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAKS,TENCOSO,SOPHONG,SOGIUONG,DIACHI,SDT,EMAIL,GHICHU,MALOAI_KS,TRANGTHAI")] DM_KHACHSAN dM_KHACHSAN)
        {
            if (ModelState.IsValid)
            {
                db.DM_KHACHSAN.Add(dM_KHACHSAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MALOAI_KS = new SelectList(db.LOAIKHACHSANs, "MALOAI_KS", "GHICHU", dM_KHACHSAN.MALOAI_KS);
            return View(dM_KHACHSAN);
        }

        // GET: admin/DM_KHACHSAN/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DM_KHACHSAN dM_KHACHSAN = db.DM_KHACHSAN.Find(id);
            if (dM_KHACHSAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MALOAI_KS = new SelectList(db.LOAIKHACHSANs, "MALOAI_KS", "GHICHU", dM_KHACHSAN.MALOAI_KS);
            return View(dM_KHACHSAN);
        }

        // POST: admin/DM_KHACHSAN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAKS,TENCOSO,SOPHONG,SOGIUONG,DIACHI,SDT,EMAIL,GHICHU,MALOAI_KS,TRANGTHAI")] DM_KHACHSAN dM_KHACHSAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dM_KHACHSAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MALOAI_KS = new SelectList(db.LOAIKHACHSANs, "MALOAI_KS", "GHICHU", dM_KHACHSAN.MALOAI_KS);
            return View(dM_KHACHSAN);
        }

        // GET: admin/DM_KHACHSAN/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DM_KHACHSAN dM_KHACHSAN = db.DM_KHACHSAN.Find(id);
            if (dM_KHACHSAN == null)
            {
                return HttpNotFound();
            }
            return View(dM_KHACHSAN);
        }

        // POST: admin/DM_KHACHSAN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DM_KHACHSAN dM_KHACHSAN = db.DM_KHACHSAN.Find(id);
            db.DM_KHACHSAN.Remove(dM_KHACHSAN);
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
