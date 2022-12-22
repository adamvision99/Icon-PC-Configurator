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
    public class MotherboardService : IMotherboardService
    {
        private IMotherboardRepository _motherboardRepository;
        public MotherboardService(IMotherboardRepository motherboardRepository) =>
            _motherboardRepository = motherboardRepository;
        public Motherboard Add(Motherboard Motherboard)
        {
            return _motherboardRepository.Add(Motherboard);
        }

        public Motherboard Edit(int id, Motherboard Motherboard)
        {
            return _motherboardRepository.Edit(id, Motherboard);
        }

        public Motherboard Get(int id)
        {
            return _motherboardRepository.Get(id);
        }

        public IEnumerable<Motherboard> GetAll()
        {
            return _motherboardRepository.GetAll();
        }

        public void Remove(int id)
        {
            _motherboardRepository.Remove(id);
        }
    }
}
