﻿using Microsoft.AspNetCore.Mvc;
using StoreSite.Data;
using StoreSite.Models.Classes;
using StoreSite.Models.DBInteraction;

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
    }
}