﻿using System.Collections.Generic;
namespace IconPC.Stock.ASPPL.Mappers
{
    public interface IMapper<BLL, PL>
        where BLL : class
        where PL : class
    {
        BLL Map(PL model);
        PL Map(BLL model);
        IEnumerable<BLL> Map(IEnumerable<PL> model);
        IEnumerable<PL> Map(IEnumerable<BLL> model);

    }
}