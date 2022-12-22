using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPC.Stock.Entities
{
    public class Case
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaximumCoolerHeight { get; set; }
        public int MaximumVideoCardLength { get; set; }
        public string WaterCoolingMount { get; set; }
        public string Color { get; set; }
        public int FansNumber { get; set; }
    }
}
