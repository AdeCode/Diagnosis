using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using diagnosis.Models;

namespace diagnosis.Areas.UserSection.Controllers
{
    public class UserHomeController : Controller
    {
        private livestockDiagnoseEntities db = new livestockDiagnoseEntities();

        //
        // GET: /UserSection/UserHome/

        public ActionResult Index()
        {
            return View(db.users.ToList());
        }

        //
        // GET: /UserSection/UserHome/Details/5

        public ActionResult Details(int id = 0)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // GET: /UserSection/UserHome/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UserSection/UserHome/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(user user)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        //
        // GET: /UserSection/UserHome/Edit/5

        public ActionResult Edit(int id = 0)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /UserSection/UserHome/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(user user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /UserSection/UserHome/Delete/5

        public ActionResult Delete(int id = 0)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /UserSection/UserHome/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            user user = db.users.Find(id);
            db.users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}