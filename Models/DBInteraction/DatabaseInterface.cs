using StoreSite.Models.Classes;
using System.Collections.Generic;
using System.Data.Entity;

namespace StoreSite.Models.DBInteraction
{
    interface IDatabaseInterface
    {

        public bool Add();

        public bool Delete(int id);

        public void Save(StoreItem id);

        public StoreItem Details(int id);

        public DbSet<StoreItem> ListAll();

        public IEnumerable<StoreItem> FilterEntries(string filter1);
    }
}
