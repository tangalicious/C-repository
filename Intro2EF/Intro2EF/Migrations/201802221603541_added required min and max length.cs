namespace Intro2EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedrequiredminandmaxlength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "State", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Orders", "Description", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Description", c => c.String());
            AlterColumn("dbo.Customers", "State", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
