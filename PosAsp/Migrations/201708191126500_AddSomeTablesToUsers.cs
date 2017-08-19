namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeTablesToUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserPassword", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Users", "UserRole", c => c.String(nullable: false, maxLength: 1));
            AddColumn("dbo.Users", "UserImg", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Users", "UserToken", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Users", "UpdDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UpdDate");
            DropColumn("dbo.Users", "UserToken");
            DropColumn("dbo.Users", "UserImg");
            DropColumn("dbo.Users", "UserRole");
            DropColumn("dbo.Users", "UserPassword");
        }
    }
}
