namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductHdStorage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDts",
                c => new
                    {
                        ProductDtID = c.Int(nullable: false, identity: true),
                        ProductSize = c.String(nullable: false, maxLength: 10),
                        ProductQty = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        ProductHdID = c.Int(nullable: false),
                        StorageID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductDtID)
                .ForeignKey("dbo.ProductHds", t => t.ProductHdID, cascadeDelete: true)
                .ForeignKey("dbo.Storages", t => t.StorageID, cascadeDelete: true)
                .Index(t => t.ProductHdID)
                .Index(t => t.StorageID);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        StorageID = c.Int(nullable: false, identity: true),
                        StorageName = c.String(nullable: false, maxLength: 60),
                        StorageCapacity = c.Int(nullable: false),
                        StorageStock = c.Int(nullable: false),
                        StoragePrior = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.StorageID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDts", "StorageID", "dbo.Storages");
            DropForeignKey("dbo.ProductDts", "ProductHdID", "dbo.ProductHds");
            DropIndex("dbo.ProductDts", new[] { "StorageID" });
            DropIndex("dbo.ProductDts", new[] { "ProductHdID" });
            DropTable("dbo.Storages");
            DropTable("dbo.ProductDts");
        }
    }
}
