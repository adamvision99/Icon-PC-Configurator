using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class CoolingRepository : ICoolingRepository
    {
        public Cooling Add(Cooling cooling)
        {
            using (var context = new StockDbContext())
            {
                context.Coolings.Add(cooling);
                context.SaveChanges();

                return cooling;
            }
        }

        public Cooling Edit(int id, Cooling cooling)
        {
            using (var context = new StockDbContext())
            {
                var oldCooling = context.Coolings.Where(x => x.Id == id).FirstOrDefault();

                oldCooling.Id = id;
                oldCooling.Name = cooling.Name;
                oldCooling.Type = cooling.Type;
                oldCooling.HeatAmount = cooling.HeatAmount;
                oldCooling.Comment = cooling.Comment;
                oldCooling.Color = cooling.Color;

                context.SaveChanges();

                return oldCooling;
            }
        }

        public Cooling Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.Coolings.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<Cooling> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var coolings = context.Coolings.ToList();
                return coolings;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableCooling = context.Coolings
                    .FirstOrDefault(x => x.Id == id);

                context.Coolings.Remove(removableCooling);

                context.SaveChanges();
            }
        }
    }
}
