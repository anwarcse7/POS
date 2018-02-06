using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using POS.Models;

namespace POS.Controllers
{
    public class UserRoleController : Controller
    {
        private DBConnection db = new DBConnection();

        // GET: /UserRole/
        public ActionResult Index()
        {
            return View(db.UserRole.ToList());
        }

        // GET: /UserRole/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRole userrole = db.UserRole.Find(id);
            if (userrole == null)
            {
                return HttpNotFound();
            }
            return View(userrole);
        }

        // GET: /UserRole/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /UserRole/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="UserRoleId,UserRoleName,Status,CreatedUser,CreateDate,EditedUser,EditedDate")] UserRole userrole)
        {
            if (ModelState.IsValid)
            {
                db.UserRole.Add(userrole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userrole);
        }

        // GET: /UserRole/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRole userrole = db.UserRole.Find(id);
            if (userrole == null)
            {
                return HttpNotFound();
            }
            return View(userrole);
        }

        // POST: /UserRole/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="UserRoleId,UserRoleName,Status,CreatedUser,CreateDate,EditedUser,EditedDate")] UserRole userrole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userrole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userrole);
        }

        // GET: /UserRole/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRole userrole = db.UserRole.Find(id);
            if (userrole == null)
            {
                return HttpNotFound();
            }
            return View(userrole);
        }

        // POST: /UserRole/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRole userrole = db.UserRole.Find(id);
            db.UserRole.Remove(userrole);
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
