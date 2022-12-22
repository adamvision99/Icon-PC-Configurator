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
    public class PowerUnitService : IPowerUnitService
    {
        private IPowerUnitRepository _powerunitRepository;
        public PowerUnitService(IPowerUnitRepository powerunitRepository) =>
            _powerunitRepository = powerunitRepository;
        public PowerUnit Add(PowerUnit PowerUnit)
        {
            return _powerunitRepository.Add(PowerUnit);
        }

        public PowerUnit Edit(int id, PowerUnit PowerUnit)
        {
            return _powerunitRepository.Edit(id, PowerUnit);
        }

        public PowerUnit Get(int id)
        {
            return _powerunitRepository.Get(id);
        }

        public IEnumerable<PowerUnit> GetAll()
        {
            return _powerunitRepository.GetAll();
        }

        public void Remove(int id)
        {
            _powerunitRepository.Remove(id);
        }
    }
}
