using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class CPURepository : ICPURepository
    {
        public CPU Add(CPU cpu)
        {
            using (var context = new StockDbContext())
            {
                context.CPUs.Add(cpu);
                context.SaveChanges();

                return cpu;
            }
        }

        public CPU Edit(int id, CPU cpu)
        {
            using (var context = new StockDbContext())
            {
                var oldCPU = context.CPUs.Where(x => x.Id == id).FirstOrDefault();

                oldCPU.Id = id;
                oldCPU.Name = cpu.Name;
                oldCPU.NumberOfThreads = cpu.NumberOfThreads;
                oldCPU.NumberOfCores = cpu.NumberOfCores;
                oldCPU.TurboFrequency = cpu.TurboFrequency;
                oldCPU.Socket = cpu.Socket;
                oldCPU.TDP = cpu.TDP;

                context.SaveChanges();

                return oldCPU;
            }
        }

        public CPU Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.CPUs.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<CPU> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var cpus = context.CPUs.ToList();
                return cpus;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableCPU = context.CPUs
                    .FirstOrDefault(x => x.Id == id);

                context.CPUs.Remove(removableCPU);

                context.SaveChanges();
            }
        }
    }
}
