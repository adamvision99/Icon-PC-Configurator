namespace IconPC.Stock.SQLDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AfteraddPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemUnits", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.CPUs", "TurboFrequency", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CPUs", "TurboFrequency", c => c.Int(nullable: false));
            DropColumn("dbo.SystemUnits", "Price");
        }
    }
}
