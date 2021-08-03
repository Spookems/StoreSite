using StoreSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace StoreSite.Models.DBInteraction
{
    interface IDatabaseInterface
    {

        public bool Add(Guid id);

        public bool Delete(Guid id);

        public void Save(StoreItem id);

        public StoreItem Details(Guid id);

        public DbSet<StoreItem> ListAll();

        public IEnumerable<StoreItem> FilterEntries(string filter1);
    }
}
