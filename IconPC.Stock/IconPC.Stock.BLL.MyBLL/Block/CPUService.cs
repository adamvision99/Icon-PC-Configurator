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
    public class CPUService : ICPUService
    {
        private ICPURepository _cpuRepository;
        public CPUService(ICPURepository testRepository) =>
            _cpuRepository = testRepository;
        public CPU Add(CPU CPU)
        {
            return _cpuRepository.Add(CPU);
        }

        public CPU Edit(int id, CPU CPU)
        {
            return _cpuRepository.Edit(id, CPU);
        }

        public CPU Get(int id)
        {
            return _cpuRepository.Get(id);
        }

        public IEnumerable<CPU> GetAll()
        {
            return _cpuRepository.GetAll();
        }

        public void Remove(int id)
        {
            _cpuRepository.Remove(id);
        }
    }
}
