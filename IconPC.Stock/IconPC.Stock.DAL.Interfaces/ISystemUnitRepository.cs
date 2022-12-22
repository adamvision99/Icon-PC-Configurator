using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface ISystemUnitRepository
    {
        SystemUnit Add(SystemUnit SystemUnit);
        SystemUnit Edit(int id, SystemUnit SystemUnit);
        void Remove(int id);
        IEnumerable<SystemUnit> GetAll();
        SystemUnit Get(int id);
    }
}
