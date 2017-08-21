namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductImgsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductImgs",
                c => new
                    {
                        ProductImgID = c.Int(nullable: false, identity: true),
                        ImgExt = c.String(nullable: false, maxLength: 5),
                        ImgName = c.String(nullable: false, maxLength: 100),
                        ImgPath = c.String(nullable: false, maxLength: 255),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 50),
                        ProductHdID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductImgID)
                .ForeignKey("dbo.ProductHds", t => t.ProductHdID, cascadeDelete: true)
                .Index(t => t.ProductHdID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductImgs", "ProductHdID", "dbo.ProductHds");
            DropIndex("dbo.ProductImgs", new[] { "ProductHdID" });
            DropTable("dbo.ProductImgs");
        }
    }
}
