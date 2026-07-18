using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ExplorePakistan.Models;

namespace ExplorePakistan.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.TotalDestinations = db.Destinations.Count();
            ViewBag.TotalUsers = db.Users.Count();
            ViewBag.TotalReviews = db.Reviews.Count();
            ViewBag.TotalMessages = db.ContactMessages.Count();
            ViewBag.RecentDestinations = db.Destinations
                .Include(d => d.Category)
                .OrderByDescending(d => d.CreatedAt)
                .Take(5).ToList();
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Destination destination)
        {
            if (ModelState.IsValid)
            {
                destination.CreatedAt = DateTime.Now;
                db.Destinations.Add(destination);
                db.SaveChanges();
                TempData["Success"] = "Destination created successfully!";
                return RedirectToAction("Destinations");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", destination.CategoryId);
            return View(destination);
        }

        // GET: Admin/Destinations
        public ActionResult Destinations()
        {
            var destinations = db.Destinations
                .Include(d => d.Category)
                .OrderByDescending(d => d.CreatedAt).ToList();
            return View(destinations);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var destination = db.Destinations.Find(id);
            if (destination == null) return HttpNotFound();
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", destination.CategoryId);
            return View(destination);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Destination destination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(destination).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Success"] = "Destination updated!";
                return RedirectToAction("Destinations");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", destination.CategoryId);
            return View(destination);
        }

        // POST: Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var destination = db.Destinations.Find(id);
            if (destination != null)
            {
                db.Destinations.Remove(destination);
                db.SaveChanges();
                TempData["Success"] = "Destination deleted!";
            }
            return RedirectToAction("Destinations");
        }

        // GET: Admin/Messages
        public ActionResult Messages()
        {
            var messages = db.ContactMessages.OrderByDescending(m => m.CreatedAt).ToList();
            return View(messages);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}