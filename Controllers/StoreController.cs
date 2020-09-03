using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

       // To Do: Add in Edit Action for current Stock

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = Db.StoreListings.Find(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(StoreItem newItem)
        {

            if (ModelState.IsValid)
            {
                var oldItem = Db.StoreListings.Find(newItem.ID);

                oldItem.Title = newItem.Title;
                oldItem.DescriptionS = newItem.DescriptionS;
                oldItem.DescriptionL = newItem.DescriptionL;
                oldItem.ImageS = newItem.ImageS;
                oldItem.ImageL = newItem.ImageL;
                oldItem.Pricing = newItem.Pricing;

                Db.SaveChanges();
            }

            return View();
        }
    }
}