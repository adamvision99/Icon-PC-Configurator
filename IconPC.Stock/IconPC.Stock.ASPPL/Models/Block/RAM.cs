using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("ОЗУ")]
    public class RAM
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Тип памяти ОЗУ")]
        public RAMtype Type { get; set; }
        [DisplayName("Объем памяти(GB)")]
        public int Size { get; set; }
        [DisplayName("Количество модулей(шт)")]
        public int NumberOfModules { get; set; }
        [DisplayName("Частота памяти (Mhz)")]
        public int MemoryFrequency { get; set; }
        [DisplayName("Латентность (CL)")]
        public int Latency { get; set; }
    }
}
