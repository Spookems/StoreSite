using StoreSite.Data;
using StoreSite.Models.Classes;
using System;
using System.Data.Entity;

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
            throw new NotImplementedException();
        }

        public StoreItem Details(int id)
        {
            var item = SqlData.StoreListings.Find(id);

            System.Diagnostics.Debug.WriteLine("Item: " + item.Title);
            System.Diagnostics.Debug.WriteLine("Item: " + item.Pricing);
            System.Diagnostics.Debug.WriteLine("Item: " + item.ImageL);


            return item;
        }

        public bool Edit(int id)
        {
            throw new NotImplementedException();
        }

        public void FilterEntries(string filter1, string filter2)
        {
            throw new NotImplementedException();
        }

        public DbSet<StoreItem> ListAll()
        {
            return SqlData.StoreListings;
        }
    }
}
