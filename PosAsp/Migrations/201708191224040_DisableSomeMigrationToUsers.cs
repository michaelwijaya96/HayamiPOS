namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisableSomeMigrationToUsers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserRole", c => c.String(maxLength: 1));
            AlterColumn("dbo.Users", "UserImg", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserImg", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "UserRole", c => c.String(nullable: false, maxLength: 1));
        }
    }
}
