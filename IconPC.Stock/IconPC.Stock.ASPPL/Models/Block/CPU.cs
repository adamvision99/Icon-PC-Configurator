using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("Процессор")]
    public class CPU
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Количество ядер")]
        public int NumberOfCores { get; set; }
        [DisplayName("Количество потоков")]
        public int NumberOfThreads { get; set; }
        [DisplayName("Частота Turbo")]
        public double TurboFrequency { get; set; }
        [DisplayName("Сокет")]
        public Socket Socket { get; set; }
        [DisplayName("TDP")]
        public int TDP { get; set; }

    }
}
