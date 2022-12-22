using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface IMotherboardRepository
    {
        Motherboard Add(Motherboard Motherboard);
        Motherboard Edit(int id, Motherboard Motherboard);
        void Remove(int id);
        IEnumerable<Motherboard> GetAll();
        Motherboard Get(int id);
    }
}
