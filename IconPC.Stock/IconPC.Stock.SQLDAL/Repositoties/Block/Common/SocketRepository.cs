using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class SocketRepository : ISocketRepository
    {
        public Socket Add(Socket socket)
        {
            using (var context = new StockDbContext())
            {
                context.Sockets.Add(socket);
                context.SaveChanges();

                return socket;
            }
        }

        public Socket Edit(int id, Socket socket)
        {
            using (var context = new StockDbContext())
            {
                var oldSocket = context.Sockets.Where(x => x.Id == id).FirstOrDefault();

                oldSocket.Id = id;
                oldSocket.Name = socket.Name;

                context.SaveChanges();

                return oldSocket;
            }
        }

        public Socket Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.Sockets.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<Socket> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var sockets = context.Sockets.ToList();
                return sockets;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableSocket = context.Sockets
                    .FirstOrDefault(x => x.Id == id);

                context.Sockets.Remove(removableSocket);

                context.SaveChanges();
            }
        }
    }
}
