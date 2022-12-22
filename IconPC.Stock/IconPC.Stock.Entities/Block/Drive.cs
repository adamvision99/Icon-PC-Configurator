using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPC.Stock.Entities
{
    public class Drive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int WriteSpeed { get; set; }
        public int ReadSpeed { get; set; }
        public int TBW { get; set; }

    }
}
