using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class RAMRepository : IRAMRepository
    {
        public RAM Add(RAM ram)
        {
            using (var context = new StockDbContext())
            {
                context.RAMs.Add(ram);
                context.SaveChanges();

                return ram;
            }
        }

        public RAM Edit(int id, RAM ram)
        {
            using (var context = new StockDbContext())
            {
                var oldRAM = context.RAMs.Where(x => x.Id == id).FirstOrDefault();

                oldRAM.Id = id;
                oldRAM.Name = ram.Name;
                oldRAM.Type = ram.Type;
                oldRAM.Size = ram.Size;
                oldRAM.NumberOfModules = ram.NumberOfModules;
                oldRAM.MemoryFrequency = ram.MemoryFrequency;
                oldRAM.Latency = ram.Latency;

                context.SaveChanges();

                return oldRAM;
            }
        }

        public RAM Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.RAMs.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<RAM> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var rams = context.RAMs.ToList();
                return rams;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableRAM = context.RAMs
                    .FirstOrDefault(x => x.Id == id);

                context.RAMs.Remove(removableRAM);

                context.SaveChanges();
            }
        }
    }
}
