using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class RAMtypeRepository : IRAMtypeRepository
    {
        public RAMtype Add(RAMtype ramtype)
        {
            using (var context = new StockDbContext())
            {
                context.RAMtypes.Add(ramtype);
                context.SaveChanges();

                return ramtype;
            }
        }

        public RAMtype Edit(int id, RAMtype ramtype)
        {
            using (var context = new StockDbContext())
            {
                var oldRAMtype = context.RAMtypes.Where(x => x.Id == id).FirstOrDefault();

                oldRAMtype.Id = id;
                oldRAMtype.Name = ramtype.Name;

                context.SaveChanges();

                return oldRAMtype;
            }
        }

        public RAMtype Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.RAMtypes.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<RAMtype> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var ramtypes = context.RAMtypes.ToList();
                return ramtypes;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableRAMtype = context.RAMtypes
                    .FirstOrDefault(x => x.Id == id);

                context.RAMtypes.Remove(removableRAMtype);

                context.SaveChanges();
            }
        }
    }
}
