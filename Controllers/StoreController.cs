using Microsoft.AspNetCore.Mvc;
using StoreSite.Data;

namespace StoreSite.Controllers
{
    public class StoreController : Controller
    {

        public IDatabaseContext Db = new IDatabaseContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listings()
        {
            var listings = Db.StoreListings;

            return View(listings);
        }
    }
}