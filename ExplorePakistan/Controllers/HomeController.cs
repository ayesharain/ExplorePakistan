using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ExplorePakistan.Models;

namespace ExplorePakistan.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            ViewBag.Categories = db.Categories.Include(c => c.Destinations).ToList();
            ViewBag.FeaturedDestinations = db.Destinations
     .Include(d => d.Category)
     .Include(d => d.Reviews)
     .Where(d => d.IsFeatured && d.IsActive)
     .Take(4)
     .ToList();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}