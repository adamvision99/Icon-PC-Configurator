using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class PowerUnitRepository : IPowerUnitRepository
    {
        public PowerUnit Add(PowerUnit powerunit)
        {
            using (var context = new StockDbContext())
            {
                context.PowerUnits.Add(powerunit);
                context.SaveChanges();

                return powerunit;
            }
        }

        public PowerUnit Edit(int id, PowerUnit powerunit)
        {
            using (var context = new StockDbContext())
            {
                var oldPowerUnit = context.PowerUnits.Where(x => x.Id == id).FirstOrDefault();

                oldPowerUnit.Id = id;
                oldPowerUnit.Name = powerunit.Name;
                oldPowerUnit.Watt = powerunit.Watt;
                oldPowerUnit.Plus80 = powerunit.Plus80;

                context.SaveChanges();

                return oldPowerUnit;
            }
        }

        public PowerUnit Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.PowerUnits.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<PowerUnit> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var powerunits = context.PowerUnits.ToList();
                return powerunits;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removablePowerUnit = context.PowerUnits
                    .FirstOrDefault(x => x.Id == id);

                context.PowerUnits.Remove(removablePowerUnit);

                context.SaveChanges();
            }
        }
    }
}
