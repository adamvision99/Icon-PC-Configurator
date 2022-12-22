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
    public class CoolingService : ICoolingService
    {
        private ICoolingRepository _coolingRepository;
        public CoolingService(ICoolingRepository coolingRepository) =>
            _coolingRepository = coolingRepository;
        public Cooling Add(Cooling Cooling)
        {
            return _coolingRepository.Add(Cooling);
        }

        public Cooling Edit(int id, Cooling Cooling)
        {
            return _coolingRepository.Edit(id, Cooling);
        }

        public Cooling Get(int id)
        {
            return _coolingRepository.Get(id);
        }

        public IEnumerable<Cooling> GetAll()
        {
            return _coolingRepository.GetAll();
        }

        public void Remove(int id)
        {
            _coolingRepository.Remove(id);
        }
    }
}
