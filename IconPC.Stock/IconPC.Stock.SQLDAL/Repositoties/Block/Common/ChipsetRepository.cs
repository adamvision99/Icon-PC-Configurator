using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class ChipsetRepository : IChipsetRepository
    {
        public Chipset Add(Chipset chipset)
        {
            using (var context = new StockDbContext())
            {
                context.Chipsets.Add(chipset);
                context.SaveChanges();

                return chipset;
            }
        }

        public Chipset Edit(int id, Chipset chipset)
        {
            using (var context = new StockDbContext())
            {
                var oldChipset = context.Chipsets.Where(x => x.Id == id).FirstOrDefault();

                oldChipset.Id = id;
                oldChipset.Name = chipset.Name;

                context.SaveChanges();

                return oldChipset;
            }
        }

        public Chipset Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.Chipsets.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<Chipset> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var chipsets = context.Chipsets.ToList();
                return chipsets;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableChipset = context.Chipsets
                    .FirstOrDefault(x => x.Id == id);

                context.Chipsets.Remove(removableChipset);

                context.SaveChanges();
            }
        }
    }
}
