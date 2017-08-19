namespace PosAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCreatedAtToUsers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.Users", "UpdDate", c => c.DateTime());
        }
        
        public override void Down()
        {
        }
    }
}
