using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface ISocketRepository
    {
        Socket Add(Socket Socket);
        Socket Edit(int id, Socket Socket);
        void Remove(int id);
        IEnumerable<Socket> GetAll();
        Socket Get(int id);
    }
}
