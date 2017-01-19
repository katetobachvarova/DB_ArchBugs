using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DB_ArchBugs.Classes;
using DB_ArchBugs.DataModel;

namespace DB_ArchBugs.WebRepo.Controllers
{
    public class BugReportsController : Controller
    {
        //private ArchBugsDbContext db = new ArchBugsDbContext();
        private DisconnectedRepository db = new DisconnectedRepository();

        // GET: BugReports
        public ActionResult Index()
        {
            List<BugReport> bugReports = db.GetArchBugsWithUsersAndLocations();
            return View(bugReports);
        }

        // GET: BugReports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BugReport bugReport = db.GetBugReportById(id.Value);
            if (bugReport == null)
            {
                return HttpNotFound();
            }
            return View(bugReport);
        }

        // GET: BugReports/Create
        public ActionResult Create()
        {
            //ViewBag.LocationId = new SelectList(db.Locations, "Id", "Description");
            //ViewBag.UserId = new SelectList(db.Users, "Id", "Name");
            return View();
        }

        // POST: BugReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,SeverityType,LocationId,UserId")] BugReport bugReport)
        {
            //if (ModelState.IsValid)
            //{
            //    db.BugReports.Add(bugReport);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            //ViewBag.LocationId = new SelectList(db.Locations, "Id", "Description", bugReport.LocationId);
            //ViewBag.UserId = new SelectList(db.Users, "Id", "Name", bugReport.UserId);
            //return View(bugReport);
            return View();
        }

        // GET: BugReports/Edit/5
        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //BugReport bugReport = db.BugReports.Find(id);
            //if (bugReport == null)
            //{
            //    return HttpNotFound();
            //}
            //ViewBag.LocationId = new SelectList(db.Locations, "Id", "Description", bugReport.LocationId);
            //ViewBag.UserId = new SelectList(db.Users, "Id", "Name", bugReport.UserId);
            //return View(bugReport);
            return View();

        }

        // POST: BugReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,SeverityType,LocationId,UserId")] BugReport bugReport)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(bugReport).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.LocationId = new SelectList(db.Locations, "Id", "Description", bugReport.LocationId);
            //ViewBag.UserId = new SelectList(db.Users, "Id", "Name", bugReport.UserId);
            //return View(bugReport);
            return View();

        }

        // GET: BugReports/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //BugReport bugReport = db.BugReports.Find(id);
            //if (bugReport == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(bugReport);
            return View();

        }

        // POST: BugReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //BugReport bugReport = db.BugReports.Find(id);
            //db.BugReports.Remove(bugReport);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
