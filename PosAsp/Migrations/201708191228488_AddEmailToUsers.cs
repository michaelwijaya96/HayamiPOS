namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Users", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Email" });
            DropColumn("dbo.Users", "Email");
        }
    }
}
