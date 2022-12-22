using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.BLL.Interfaces;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.BLL.MyBLL
{
    public class SocketService : ISocketService
    {
        private ISocketRepository _socketRepository;
        public SocketService(ISocketRepository socketRepository) =>
            _socketRepository = socketRepository;
        public Socket Add(Socket Socket)
        {
            return _socketRepository.Add(Socket);
        }

        public Socket Edit(int id, Socket Socket)
        {
            return _socketRepository.Edit(id, Socket);
        }

        public Socket Get(int id)
        {
            return _socketRepository.Get(id);
        }

        public IEnumerable<Socket> GetAll()
        {
            return _socketRepository.GetAll();
        }

        public void Remove(int id)
        {
            _socketRepository.Remove(id);
        }
    }
}
