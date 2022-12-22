using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPC.Stock.Entities
{
    public class VideoCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desctription { get; set; }
        public int MemorySize { get; set; }
        public int BusWidth { get; set; }
        public int MinimumPowerSupply { get; set; }
        public int Length { get; set; }
        public string Connector { get; set; }

    }
}
