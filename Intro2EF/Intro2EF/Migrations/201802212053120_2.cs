namespace Intro2EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            DropColumn("dbo.Customers", "CredLim");
            DropColumn("dbo.Customers", "Active");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "CredLim", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Orders");
        }
    }
}
