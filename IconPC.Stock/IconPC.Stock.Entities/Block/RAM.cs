using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPC.Stock.Entities
{
    public class RAM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RAMtype Type { get; set; }
        public int Size { get; set; }
        public int NumberOfModules { get; set; }
        public int MemoryFrequency { get; set; }
        public int Latency { get; set; }
    }
}
