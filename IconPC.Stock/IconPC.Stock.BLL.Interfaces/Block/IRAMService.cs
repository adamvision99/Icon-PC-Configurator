using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.BLL.Interfaces
{
    public interface IRAMService
    {
        RAM Add(RAM RAM);
        RAM Edit(int id, RAM RAM);
        void Remove(int id);
        IEnumerable<RAM> GetAll();
        RAM Get(int id);
    }
}
