using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class CaseRepository : ICaseRepository
    {
        public Case Add(Case _case)
        {
            using (var context = new StockDbContext())
            {
                context.Cases.Add(_case);
                context.SaveChanges();

                return _case;
            }
        }

        public Case Edit(int id, Case _case)
        {
            using (var context = new StockDbContext())
            {
                var oldCase = context.Cases.Where(x => x.Id == id).FirstOrDefault();

                oldCase.Id = id;
                oldCase.Name = _case.Name;
                oldCase.Type = _case.Type;
                oldCase.MaximumVideoCardLength = _case.MaximumVideoCardLength;
                oldCase.MaximumCoolerHeight = _case.MaximumCoolerHeight;
                oldCase.WaterCoolingMount = _case.WaterCoolingMount;
                oldCase.Color = _case.Color;
                oldCase.FansNumber = _case.FansNumber;

                context.SaveChanges();

                return oldCase;
            }
        }

        public Case Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.Cases.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<Case> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var cases = context.Cases.ToList();
                return cases;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableCase = context.Cases
                    .FirstOrDefault(x => x.Id == id);

                context.Cases.Remove(removableCase);

                context.SaveChanges();
            }
        }
    }
}
