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
    public class ChipsetService : IChipsetService
    {
        private IChipsetRepository _chipsetRepository;
        public ChipsetService(IChipsetRepository chipsetRepository) =>
            _chipsetRepository = chipsetRepository;
        public Chipset Add(Chipset Chipset)
        {
            return _chipsetRepository.Add(Chipset);
        }

        public Chipset Edit(int id, Chipset Chipset)
        {
            return _chipsetRepository.Edit(id, Chipset);
        }

        public Chipset Get(int id)
        {
            return _chipsetRepository.Get(id);
        }

        public IEnumerable<Chipset> GetAll()
        {
            return _chipsetRepository.GetAll();
        }

        public void Remove(int id)
        {
            _chipsetRepository.Remove(id);
        }
    }
}
