using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.BLL.Interfaces
{
    public interface ICPUService
    {
        CPU Add(CPU CPU);
        CPU Edit(int id, CPU CPU);
        void Remove(int id);
        IEnumerable<CPU> GetAll();
        CPU Get(int id);
    }
}
