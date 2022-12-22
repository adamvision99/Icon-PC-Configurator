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
    public class RAMtypeService : IRAMtypeService
    {
        private IRAMtypeRepository _ramtypeRepository;
        public RAMtypeService(IRAMtypeRepository ramRepository) =>
            _ramtypeRepository = ramRepository;
        public RAMtype Add(RAMtype RAMtype)
        {
            return _ramtypeRepository.Add(RAMtype);
        }

        public RAMtype Edit(int id, RAMtype RAMtype)
        {
            return _ramtypeRepository.Edit(id, RAMtype);
        }

        public RAMtype Get(int id)
        {
            return _ramtypeRepository.Get(id);
        }

        public IEnumerable<RAMtype> GetAll()
        {
            return _ramtypeRepository.GetAll();
        }

        public void Remove(int id)
        {
            _ramtypeRepository.Remove(id);
        }
    }
}
