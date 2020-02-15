namespace WilsonTeaRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderRequirement : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Order", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Order", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Order", "Phone", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Order", "Phone", c => c.String());
            AlterColumn("dbo.Order", "LastName", c => c.String());
            AlterColumn("dbo.Order", "FirstName", c => c.String());
        }
    }
}
