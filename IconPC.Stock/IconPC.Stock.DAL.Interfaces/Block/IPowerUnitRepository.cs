using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface IPowerUnitRepository
    {
        PowerUnit Add(PowerUnit PowerUnit);
        PowerUnit Edit(int id, PowerUnit PowerUnit);
        void Remove(int id);
        IEnumerable<PowerUnit> GetAll();
        PowerUnit Get(int id);
    }
}
