using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ExplorePakistan.Models;

namespace ExplorePakistan.Controllers
{
    public class DestinationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Destination
        public ActionResult Index(string search, int? categoryId)
        {
            var query = db.Destinations
                .Include(d => d.Category)
                .Include(d => d.Reviews)
                .Where(d => d.IsActive);

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(d =>
                    d.Name.Contains(search) ||
                    d.Province.Contains(search) ||
                    d.Description.Contains(search));
            }

            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(d => d.CategoryId == categoryId);
            }

            ViewBag.Categories = db.Categories.ToList();
            ViewBag.CurrentSearch = search;
            ViewBag.CurrentCategory = categoryId;

            var destinations = query.OrderByDescending(d => d.CreatedAt).ToList();
            return View(destinations);
        }

        // GET: /Destination/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var destination = db.Destinations
                .Include(d => d.Category)
                .Include(d => d.Reviews.Select(r => r.User))
                .FirstOrDefault(d => d.Id == id);

            if (destination == null) return HttpNotFound();

            return View(destination);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}