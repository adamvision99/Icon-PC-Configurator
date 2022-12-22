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
    public class CaseService : ICaseService
    {
        private ICaseRepository _caseRepository;
        public CaseService(ICaseRepository caseRepository) =>
            _caseRepository = caseRepository;
        public Case Add(Case Case)
        {
            return _caseRepository.Add(Case);
        }

        public Case Edit(int id, Case Case)
        {
            return _caseRepository.Edit(id, Case);
        }

        public Case Get(int id)
        {
            return _caseRepository.Get(id);
        }

        public IEnumerable<Case> GetAll()
        {
            return _caseRepository.GetAll();
        }

        public void Remove(int id)
        {
            _caseRepository.Remove(id);
        }
    }
}
