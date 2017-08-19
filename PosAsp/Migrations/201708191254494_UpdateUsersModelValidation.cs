namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUsersModelValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserToken", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserToken", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
