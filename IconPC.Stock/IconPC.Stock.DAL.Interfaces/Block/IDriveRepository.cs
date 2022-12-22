using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface IDriveRepository
    {
        Drive Add(Drive Drive);
        Drive Edit(int id, Drive Drive);
        void Remove(int id);
        IEnumerable<Drive> GetAll();
        Drive Get(int id);
    }
}
