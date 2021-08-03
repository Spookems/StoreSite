namespace StoreSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuuillable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StoreItems", "InlcudedDeals", c => c.Guid());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StoreItems", "InlcudedDeals", c => c.Guid(nullable: false));
        }
    }
}
