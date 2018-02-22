namespace Intro2EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _34 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Description", c => c.Int(nullable: false));
        }
    }
}
