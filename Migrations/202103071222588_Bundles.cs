namespace StoreSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bundles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bundles",
                c => new
                    {
                        BundleID = c.Guid(nullable: false),
                        BundleName = c.String(),
                        BundleDescription = c.String(),
                        Item1 = c.Guid(nullable: false),
                        Item2 = c.Guid(nullable: false),
                        Item3 = c.Guid(nullable: false),
                        Item4 = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.BundleID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bundles");
        }
    }
}
