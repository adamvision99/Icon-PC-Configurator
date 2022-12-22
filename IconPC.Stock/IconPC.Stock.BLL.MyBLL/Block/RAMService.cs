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
    public class RAMService : IRAMService
    {
        private IRAMRepository _ramRepository;
        public RAMService(IRAMRepository ramRepository) =>
            _ramRepository = ramRepository;
        public RAM Add(RAM RAM)
        {
            return _ramRepository.Add(RAM);
        }

        public RAM Edit(int id, RAM RAM)
        {
            return _ramRepository.Edit(id, RAM);
        }

        public RAM Get(int id)
        {
            return _ramRepository.Get(id);
        }

        public IEnumerable<RAM> GetAll()
        {
            return _ramRepository.GetAll();
        }

        public void Remove(int id)
        {
            _ramRepository.Remove(id);
        }
    }
}
