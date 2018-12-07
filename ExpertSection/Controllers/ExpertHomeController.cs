using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using diagnosis.Models;

namespace diagnosis.Areas.ExpertSection.Controllers
{
    public class ExpertHomeController : Controller
    {
        private livestockDiagnoseEntities db = new livestockDiagnoseEntities();

        //
        // GET: /ExpertSection/ExpertHome/

        public ActionResult Index()
        {
            return View(db.Experts.ToList());
        }

        //
        // GET: /ExpertSection/ExpertHome/Details/5

        public ActionResult Details(int id = 0)
        {
            Expert expert = db.Experts.Find(id);
            if (expert == null)
            {
                return HttpNotFound();
            }
            return View(expert);
        }

        //
        // GET: /ExpertSection/ExpertHome/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ExpertSection/ExpertHome/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Expert expert)
        {
            if (ModelState.IsValid)
            {
                db.Experts.Add(expert);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expert);
        }

        //
        // GET: /ExpertSection/ExpertHome/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Expert expert = db.Experts.Find(id);
            if (expert == null)
            {
                return HttpNotFound();
            }
            return View(expert);
        }

        //
        // POST: /ExpertSection/ExpertHome/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Expert expert)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expert).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expert);
        }

        //
        // GET: /ExpertSection/ExpertHome/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Expert expert = db.Experts.Find(id);
            if (expert == null)
            {
                return HttpNotFound();
            }
            return View(expert);
        }

        //
        // POST: /ExpertSection/ExpertHome/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expert expert = db.Experts.Find(id);
            db.Experts.Remove(expert);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult ManageAccount()
        {
            return View(db.Experts.ToList());
        }
    }
}