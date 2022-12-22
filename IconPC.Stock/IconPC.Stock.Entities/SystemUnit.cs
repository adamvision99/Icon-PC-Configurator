using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPC.Stock.Entities
{
    public class SystemUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Series { get; set; }
        public int Price { get; set; }
        public CPU CPU { get; set; }
        public Motherboard Motherboard { get; set; }
        public RAM RAM { get; set; }
        public VideoCard VideoCard { get; set; }
        public Cooling Cooling { get; set; }
        public Drive Drive { get; set; }
        public PowerUnit PowerUnit { get; set; }
        public Case Case { get; set; }

    }
}
