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

        public IActionResult Details(Guid id)
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
        public IActionResult Edit(Guid id)
        {
            var model = DB.Details(id);

            return View(model);
        }

        
        public IActionResult Product(Guid ID)
        {
            StoreItem model = null;
            
            try
            {
                model = Db.StoreListings.Find(ID);
            }
            catch (NullReferenceException e)
            {
                System.Diagnostics.Debug.WriteLine("Issue with edit of item ID: " + model.ID +
                    "\n" + "Exception: " + e);
            }

            if(model != null)
            {
                return View(model);
            }
            else
            {
                model = new StoreItem
                {
                    Title = "Title",
                    DescriptionS = "Short Description",
                    DescriptionL = "Long Description",
                    Pricing = 0
                };
                return View(model);
            }
        }
         [HttpPost]  
        public IActionResult ProductSubmit(StoreItem item)
        {
            if (ModelState.IsValid)
            {
                var oldItem = Db.StoreListings.Find(item.ID);
                
                if(oldItem != null)
                {
                    oldItem = item;
                    DB.Save(oldItem);
                }
                else
                {
                    Db.StoreListings.Add(item);
                }
            }

            return Redirect("CurrentStock");
        }

        public IActionResult DeleteProduct(Guid id)
        {
            bool saved = false;
            StoreItem model = null;

            try
            {
                model = Db.StoreListings.Find(id);
            }
            catch(NullReferenceException e) 
            {
                return RedirectToAction("CurrentStock" + e);
            }

            if(model != null )
            {
                saved = DB.Delete(id);
                
            }
            System.Diagnostics.Debug.WriteLine("Entry Deletion:" + saved);

            return RedirectToAction("CurrentStock");
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