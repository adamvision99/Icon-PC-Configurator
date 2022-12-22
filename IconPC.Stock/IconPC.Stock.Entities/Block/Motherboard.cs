using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPC.Stock.Entities
{
    public class Motherboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Socket Socket { get; set; }
        public Chipset Chipset { get; set; }
        public int NumberOfDRAM { get; set; }
        public string Interfaces { get; set; }
        public RAMtype RAMtype { get; set; }

    }
}
