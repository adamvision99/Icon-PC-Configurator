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
    public class SystemUnitService : ISystemUnitService
    {
        private ISystemUnitRepository _systemunitRepository;
        public SystemUnitService(ISystemUnitRepository systemUnitRepository) =>
            _systemunitRepository = systemUnitRepository;
        public SystemUnit Add(SystemUnit SystemUnit)
        {
            return _systemunitRepository.Add(SystemUnit);
        }

        public SystemUnit Edit(int id, SystemUnit SystemUnit)
        {
            return _systemunitRepository.Edit(id, SystemUnit);
        }

        public SystemUnit Get(int id)
        {
            return _systemunitRepository.Get(id);
        }

        public IEnumerable<SystemUnit> GetAll()
        {
            return _systemunitRepository.GetAll();
        }

        public void Remove(int id)
        {
            _systemunitRepository.Remove(id);
        }
    }
}
