using StoreSite.Models.Classes;
using System.Data.Entity;

namespace StoreSite.Models.DBInteraction
{
    interface IDatabaseInterface
    {

        public bool Add();

        public bool Delete(int id);

        public bool Edit(int id);

        public StoreItem Details(int id);

        public DbSet<StoreItem> ListAll();

        public void FilterEntries(string filter1, string filter2);
    }
}
