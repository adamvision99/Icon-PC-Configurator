using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;    

namespace IconPC.Stock.BLL.Interfaces
{
    public interface ICoolingService
    {
        Cooling Add(Cooling Cooling);
        Cooling Edit(int id, Cooling Cooling);
        void Remove(int id);
        IEnumerable<Cooling> GetAll();
        Cooling Get(int id);
    }
}
