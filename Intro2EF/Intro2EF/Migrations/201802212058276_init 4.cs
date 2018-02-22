namespace Intro2EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Date", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Description", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Description");
            DropColumn("dbo.Orders", "Date");
        }
    }
}
