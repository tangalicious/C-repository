namespace Intro2EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Date", c => c.Int(nullable: false));
        }
    }
}
