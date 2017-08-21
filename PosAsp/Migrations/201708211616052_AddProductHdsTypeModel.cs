namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductHdsTypeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        ModelName = c.String(nullable: false, maxLength: 60),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ModelID);
            
            CreateTable(
                "dbo.ProductHds",
                c => new
                    {
                        ProductHdID = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(nullable: false, maxLength: 40),
                        ProductName = c.String(nullable: false, maxLength: 60),
                        ProductDesc = c.String(nullable: false, maxLength: 255),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 50),
                        ModelID = c.Int(nullable: false),
                        TypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductHdID)
                .ForeignKey("dbo.Models", t => t.ModelID, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.ModelID)
                .Index(t => t.TypeID);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false, maxLength: 60),
                        TypePrice = c.Decimal(nullable: false, precision: 23, scale: 6),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductHds", "TypeID", "dbo.Types");
            DropForeignKey("dbo.ProductHds", "ModelID", "dbo.Models");
            DropIndex("dbo.ProductHds", new[] { "TypeID" });
            DropIndex("dbo.ProductHds", new[] { "ModelID" });
            DropTable("dbo.Types");
            DropTable("dbo.ProductHds");
            DropTable("dbo.Models");
        }
    }
}
