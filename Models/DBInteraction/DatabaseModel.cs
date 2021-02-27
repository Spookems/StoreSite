using StoreSite.Data;
using StoreSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StoreSite.Models.DBInteraction
{
    public class DatabaseModel : IDatabaseInterface
    {
        IDatabaseContext SqlData = new IDatabaseContext();

        public DatabaseModel()
        {

        }

        public bool Add()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            bool saved = false;

            var item = SqlData.StoreListings.Find(id);

            if(item != null)
            {
                SqlData.StoreListings.Remove(item);

                SqlData.SaveChanges();

                saved = true;
            }

            return saved;
        }

        public StoreItem Details(int id)
        {
            var item = SqlData.StoreListings.Find(id);

            return item;
        }

        public void Save(StoreItem newItem)
        {
            var oldItem = SqlData.StoreListings.Find(newItem.ID);

            oldItem.Title = newItem.Title;
            oldItem.DescriptionS = newItem.DescriptionS;
            oldItem.DescriptionL = newItem.DescriptionL;
            oldItem.ImageS = newItem.ImageS;
            oldItem.ImageL = newItem.ImageL;
            oldItem.Pricing = newItem.Pricing;

            SqlData.SaveChanges();
        }

        public IEnumerable<StoreItem> FilterEntries(string filter1)
        {
            var model = SqlData.StoreListings.Where(i => i.Title == filter1);

            return model;
        }

        public DbSet<StoreItem> ListAll()
        {
            return SqlData.StoreListings;
        }
    }
}
