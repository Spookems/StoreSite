namespace StoreSite.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StoreItems",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    DescriptionS = c.String(),
                    DescriptionL = c.String(),
                    ImageS = c.String(),
                    ImageL = c.String(),
                    Pricing = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropTable("dbo.StoreItems");
        }
    }
}
