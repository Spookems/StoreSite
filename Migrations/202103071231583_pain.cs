namespace StoreSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StoreItems",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true),
                    Title = c.String(),
                    DescriptionS = c.String(),
                    DescriptionL = c.String(),
                    ImageS = c.String(),
                    ImageL = c.String(),
                    Pricing = c.Int(nullable: false),
                    AssociatedDeals = c.Guid(),
                    LocationLine1 = c.String(),
                    LocationLine2 = c.String(),
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropTable("dbo.StoreItems");
        }
    }
}
