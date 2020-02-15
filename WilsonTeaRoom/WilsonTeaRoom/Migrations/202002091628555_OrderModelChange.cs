namespace WilsonTeaRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "FirstName", c => c.String());
            AddColumn("dbo.Order", "LastName", c => c.String());
            AddColumn("dbo.Order", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Order", "Phone");
            DropColumn("dbo.Order", "LastName");
            DropColumn("dbo.Order", "FirstName");
        }
    }
}
