using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPC.Stock.Entities
{
    public class CPU
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfThreads { get; set; }
        public double TurboFrequency { get; set; }
        public Socket Socket { get; set; }
        public int TDP { get; set; }

    }
}
