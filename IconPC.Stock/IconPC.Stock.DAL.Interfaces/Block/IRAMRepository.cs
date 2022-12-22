using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface IRAMRepository
    {
        RAM Add(RAM RAM);
        RAM Edit(int id, RAM RAM);
        void Remove(int id);
        IEnumerable<RAM> GetAll();
        RAM Get(int id);
    }
}
