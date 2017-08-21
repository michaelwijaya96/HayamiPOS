namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockAdjusts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockAdjusts",
                c => new
                    {
                        StockAdjustID = c.Int(nullable: false, identity: true),
                        AdjustQty = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 50),
                        ProductDtID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockAdjustID)
                .ForeignKey("dbo.ProductHds", t => t.ProductDtID, cascadeDelete: true)
                .ForeignKey("dbo.ProductDts", t => t.ProductDtID, cascadeDelete: true)
                .Index(t => t.ProductDtID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockAdjusts", "ProductDtID", "dbo.ProductDts");
            DropForeignKey("dbo.StockAdjusts", "ProductDtID", "dbo.ProductHds");
            DropIndex("dbo.StockAdjusts", new[] { "ProductDtID" });
            DropTable("dbo.StockAdjusts");
        }
    }
}
