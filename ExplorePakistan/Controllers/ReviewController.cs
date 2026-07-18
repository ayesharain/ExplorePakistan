using System;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ExplorePakistan.Models;

namespace ExplorePakistan.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int destinationId, int rating, string comment)
        {
            var review = new Review
            {
                DestinationId = destinationId,
                Rating = rating,
                Comment = comment,
                UserId = User.Identity.GetUserId(),
                CreatedAt = DateTime.Now
            };

            db.Reviews.Add(review);
            db.SaveChanges();

            return RedirectToAction("Details", "Destination", new { id = destinationId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}