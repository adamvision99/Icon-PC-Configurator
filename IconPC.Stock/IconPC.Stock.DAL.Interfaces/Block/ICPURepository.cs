using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface ICPURepository
    {
        CPU Add(CPU CPU);
        CPU Edit(int id, CPU CPU);
        void Remove(int id);
        IEnumerable<CPU> GetAll();
        CPU Get(int id);
    }
}
