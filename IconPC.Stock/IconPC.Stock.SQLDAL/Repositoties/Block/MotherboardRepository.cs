using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class MotherboardRepository : IMotherboardRepository
    {
        public Motherboard Add(Motherboard motherboard)
        {
            using (var context = new StockDbContext())
            {
                context.Motherboards.Add(motherboard);
                context.SaveChanges();

                return motherboard;
            }
        }

        public Motherboard Edit(int id, Motherboard motherboard)
        {
            using (var context = new StockDbContext())
            {
                var oldMotherboard = context.Motherboards.Where(x => x.Id == id).FirstOrDefault();

                oldMotherboard.Id = id;
                oldMotherboard.Name = motherboard.Name;
                oldMotherboard.Socket = motherboard.Socket;
                oldMotherboard.Chipset = motherboard.Chipset;
                oldMotherboard.NumberOfDRAM = motherboard.NumberOfDRAM;
                oldMotherboard.Interfaces = motherboard.Interfaces;
                oldMotherboard.RAMtype = motherboard.RAMtype;

                context.SaveChanges();

                return oldMotherboard;
            }
        }

        public Motherboard Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.Motherboards.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<Motherboard> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var motherboards = context.Motherboards.ToList();
                return motherboards;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableMotherboard = context.Motherboards
                    .FirstOrDefault(x => x.Id == id);

                context.Motherboards.Remove(removableMotherboard);

                context.SaveChanges();
            }
        }
    }
}
