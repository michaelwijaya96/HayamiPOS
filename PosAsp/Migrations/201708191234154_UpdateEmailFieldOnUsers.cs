namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmailFieldOnUsers : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "Email" });
            AddColumn("dbo.Users", "UserEmail", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Users", "UserEmail", unique: true);
            DropColumn("dbo.Users", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            DropIndex("dbo.Users", new[] { "UserEmail" });
            DropColumn("dbo.Users", "UserEmail");
            CreateIndex("dbo.Users", "Email", unique: true);
        }
    }
}
