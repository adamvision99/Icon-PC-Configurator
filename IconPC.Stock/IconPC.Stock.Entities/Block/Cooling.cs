using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPC.Stock.Entities
{
    public class Cooling
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int HeatAmount { get; set; }
        public string Comment { get; set; }
        public string Color { get; set; }
    }
}
