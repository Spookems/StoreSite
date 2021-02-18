using Microsoft.AspNetCore.Mvc;
using StoreSite.Data;
using StoreSite.Models.Classes;
using StoreSite.Models.DBInteraction;
using System;

namespace StoreSite.Controllers
{
    public class StoreController : Controller
    {

        public IDatabaseContext Db = new IDatabaseContext();

        public DatabaseModel DB = new DatabaseModel();


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listings()
        {
            var listings = DB.ListAll();

            return View(listings);
        }

        public IActionResult Details(int id)
        {
            var model = DB.Details(id);

            return View(model);
        }

        public IActionResult CurrentStock()
        {
            var listings = DB.ListAll();

            return View(listings);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = DB.Details(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(StoreItem newItem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB.Save(newItem);
                }
                catch (NullReferenceException e)
                {
                    System.Diagnostics.Debug.WriteLine("Issue with edit of item ID: " + newItem.ID +
                        "\n" + "Exception: " + e);
                    return Redirect("/Home/Error");
                }

            }

            return View();
        }

        public void FilterListings(string input1, string input2, string input3, string input4)
        {

        }

        public IActionResult Search(string input)
        {
            var model = DB.FilterEntries(input);

            return Redirect("Listings");
        }
    }
}