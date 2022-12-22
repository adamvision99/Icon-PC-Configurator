using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class SystemUnitRepository : ISystemUnitRepository
    {
        public SystemUnit Add(SystemUnit systemunit)
        {
            using (var context = new StockDbContext())
            {
                context.SystemUnits.Add(systemunit);
                context.SaveChanges();

                return systemunit;
            }
        }

        public SystemUnit Edit(int id, SystemUnit systemunit)
        {
            using (var context = new StockDbContext())
            {
                var oldSystemUnit = context.SystemUnits.Where(x => x.Id == id).FirstOrDefault();

                oldSystemUnit.Id = id;
                oldSystemUnit.Name = systemunit.Name;
                oldSystemUnit.Description = systemunit.Description;
                oldSystemUnit.Series = systemunit.Series;
                oldSystemUnit.CPU = new CPU
                {
                    Id = systemunit.CPU.Id,
                    Name = systemunit.CPU.Name,
                    NumberOfThreads = systemunit.CPU.NumberOfThreads,
                    NumberOfCores = systemunit.CPU.NumberOfCores,
                    TurboFrequency = systemunit.CPU.TurboFrequency,
                    Socket = systemunit.CPU.Socket,
                    TDP = systemunit.CPU.TDP
                };
                oldSystemUnit.Motherboard = systemunit.Motherboard;
                oldSystemUnit.RAM = systemunit.RAM;
                oldSystemUnit.VideoCard = systemunit.VideoCard;
                oldSystemUnit.Cooling = systemunit.Cooling;
                oldSystemUnit.Drive = systemunit.Drive;
                oldSystemUnit.PowerUnit = systemunit.PowerUnit;
                oldSystemUnit.Case = systemunit.Case;
                oldSystemUnit.Price = systemunit.Price;

                context.SaveChanges();

                return oldSystemUnit;
            }
        }

        public SystemUnit Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.SystemUnits.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<SystemUnit> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var systemunits = context.SystemUnits.ToList();
                return systemunits;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableSystemUnit = context.SystemUnits
                    .FirstOrDefault(x => x.Id == id);

                context.SystemUnits.Remove(removableSystemUnit);

                context.SaveChanges();
            }
        }
    }
}
