using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface ICaseRepository
    {
        Case Add(Case Case);
        Case Edit(int id, Case Case);
        void Remove(int id);
        IEnumerable<Case> GetAll();
        Case Get(int id);
    }
}
