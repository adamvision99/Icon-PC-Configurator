using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface IRAMtypeRepository
    {
        RAMtype Add(RAMtype RAMtype);
        RAMtype Edit(int id, RAMtype RAMtype);
        void Remove(int id);
        IEnumerable<RAMtype> GetAll();
        RAMtype Get(int id);
    }
}
