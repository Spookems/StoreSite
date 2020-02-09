using StoreSite.Models.Classes;
using System.Data.Entity;


namespace StoreSite.Data
{
    public class IDatabaseContext : DbContext
    {
        public IDatabaseContext() : base("WebsiteTemplate")
        {

        }
        public DbSet<StoreItem> StoreListings { get; set; }
    }
}
