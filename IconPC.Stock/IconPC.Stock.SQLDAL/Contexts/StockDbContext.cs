using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IconPC.Stock.Entities;

namespace IconPC.Stock.SQLDAL
{
    public class StockDbContext : DbContext
    {
        public StockDbContext() : base("MyConnectionString")
        {

        }

        public DbSet<Chipset> Chipsets { get; set; }
        public DbSet<RAMtype> RAMtypes { get; set; }
        public DbSet<Socket> Sockets { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Cooling> Coolings { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerUnit> PowerUnits { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<VideoCard> VideoCards { get; set; }
        public DbSet<SystemUnit> SystemUnits { get; set; }
    }
}
