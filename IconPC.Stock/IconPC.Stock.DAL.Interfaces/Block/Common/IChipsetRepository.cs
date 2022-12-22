﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.DAL.Interfaces
{
    public interface IChipsetRepository
    {
        Chipset Add(Chipset chipset);
        Chipset Edit(int id, Chipset chipset);
        void Remove(int id);
        IEnumerable<Chipset> GetAll();
        Chipset Get(int id);
    }
}
