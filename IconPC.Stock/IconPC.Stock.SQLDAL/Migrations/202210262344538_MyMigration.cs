namespace IconPC.Stock.SQLDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        MaximumCoolerHeight = c.Int(nullable: false),
                        MaximumVideoCardLength = c.Int(nullable: false),
                        WaterCoolingMount = c.String(),
                        Color = c.String(),
                        FansNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chipsets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coolings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        HeatAmount = c.Int(nullable: false),
                        Comment = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CPUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfCores = c.Int(nullable: false),
                        NumberOfThreads = c.Int(nullable: false),
                        TurboFrequency = c.Int(nullable: false),
                        TDP = c.Int(nullable: false),
                        Socket_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sockets", t => t.Socket_Id)
                .Index(t => t.Socket_Id);
            
            CreateTable(
                "dbo.Sockets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Capacity = c.Int(nullable: false),
                        WriteSpeed = c.Int(nullable: false),
                        ReadSpeed = c.Int(nullable: false),
                        TBW = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfDRAM = c.Int(nullable: false),
                        Interfaces = c.String(),
                        Chipset_Id = c.Int(),
                        RAMtype_Id = c.Int(),
                        Socket_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chipsets", t => t.Chipset_Id)
                .ForeignKey("dbo.RAMtypes", t => t.RAMtype_Id)
                .ForeignKey("dbo.Sockets", t => t.Socket_Id)
                .Index(t => t.Chipset_Id)
                .Index(t => t.RAMtype_Id)
                .Index(t => t.Socket_Id);
            
            CreateTable(
                "dbo.RAMtypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PowerUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Watt = c.Int(nullable: false),
                        Plus80 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RAMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.Int(nullable: false),
                        NumberOfModules = c.Int(nullable: false),
                        MemoryFrequency = c.Int(nullable: false),
                        Latency = c.Int(nullable: false),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RAMtypes", t => t.Type_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.SystemUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Series = c.String(),
                        Case_Id = c.Int(),
                        Cooling_Id = c.Int(),
                        CPU_Id = c.Int(),
                        Drive_Id = c.Int(),
                        Motherboard_Id = c.Int(),
                        PowerUnit_Id = c.Int(),
                        RAM_Id = c.Int(),
                        VideoCard_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cases", t => t.Case_Id)
                .ForeignKey("dbo.Coolings", t => t.Cooling_Id)
                .ForeignKey("dbo.CPUs", t => t.CPU_Id)
                .ForeignKey("dbo.Drives", t => t.Drive_Id)
                .ForeignKey("dbo.Motherboards", t => t.Motherboard_Id)
                .ForeignKey("dbo.PowerUnits", t => t.PowerUnit_Id)
                .ForeignKey("dbo.RAMs", t => t.RAM_Id)
                .ForeignKey("dbo.VideoCards", t => t.VideoCard_Id)
                .Index(t => t.Case_Id)
                .Index(t => t.Cooling_Id)
                .Index(t => t.CPU_Id)
                .Index(t => t.Drive_Id)
                .Index(t => t.Motherboard_Id)
                .Index(t => t.PowerUnit_Id)
                .Index(t => t.RAM_Id)
                .Index(t => t.VideoCard_Id);
            
            CreateTable(
                "dbo.VideoCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Desctription = c.String(),
                        MemorySize = c.Int(nullable: false),
                        BusWidth = c.Int(nullable: false),
                        MinimumPowerSupply = c.Int(nullable: false),
                        Length = c.Int(nullable: false),
                        Connector = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SystemUnits", "VideoCard_Id", "dbo.VideoCards");
            DropForeignKey("dbo.SystemUnits", "RAM_Id", "dbo.RAMs");
            DropForeignKey("dbo.SystemUnits", "PowerUnit_Id", "dbo.PowerUnits");
            DropForeignKey("dbo.SystemUnits", "Motherboard_Id", "dbo.Motherboards");
            DropForeignKey("dbo.SystemUnits", "Drive_Id", "dbo.Drives");
            DropForeignKey("dbo.SystemUnits", "CPU_Id", "dbo.CPUs");
            DropForeignKey("dbo.SystemUnits", "Cooling_Id", "dbo.Coolings");
            DropForeignKey("dbo.SystemUnits", "Case_Id", "dbo.Cases");
            DropForeignKey("dbo.RAMs", "Type_Id", "dbo.RAMtypes");
            DropForeignKey("dbo.Motherboards", "Socket_Id", "dbo.Sockets");
            DropForeignKey("dbo.Motherboards", "RAMtype_Id", "dbo.RAMtypes");
            DropForeignKey("dbo.Motherboards", "Chipset_Id", "dbo.Chipsets");
            DropForeignKey("dbo.CPUs", "Socket_Id", "dbo.Sockets");
            DropIndex("dbo.SystemUnits", new[] { "VideoCard_Id" });
            DropIndex("dbo.SystemUnits", new[] { "RAM_Id" });
            DropIndex("dbo.SystemUnits", new[] { "PowerUnit_Id" });
            DropIndex("dbo.SystemUnits", new[] { "Motherboard_Id" });
            DropIndex("dbo.SystemUnits", new[] { "Drive_Id" });
            DropIndex("dbo.SystemUnits", new[] { "CPU_Id" });
            DropIndex("dbo.SystemUnits", new[] { "Cooling_Id" });
            DropIndex("dbo.SystemUnits", new[] { "Case_Id" });
            DropIndex("dbo.RAMs", new[] { "Type_Id" });
            DropIndex("dbo.Motherboards", new[] { "Socket_Id" });
            DropIndex("dbo.Motherboards", new[] { "RAMtype_Id" });
            DropIndex("dbo.Motherboards", new[] { "Chipset_Id" });
            DropIndex("dbo.CPUs", new[] { "Socket_Id" });
            DropTable("dbo.Tests");
            DropTable("dbo.VideoCards");
            DropTable("dbo.SystemUnits");
            DropTable("dbo.RAMs");
            DropTable("dbo.PowerUnits");
            DropTable("dbo.RAMtypes");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Drives");
            DropTable("dbo.Sockets");
            DropTable("dbo.CPUs");
            DropTable("dbo.Coolings");
            DropTable("dbo.Chipsets");
            DropTable("dbo.Cases");
        }
    }
}
