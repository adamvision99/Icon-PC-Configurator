using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("Материнская плата")]
    public class Motherboard
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Сокет")]
        public Socket Socket { get; set; }
        [DisplayName("Чипсет")]
        public Chipset Chipset { get; set; }
        [DisplayName("Количество DRAM")]
        public int NumberOfDRAM { get; set; }
        [DisplayName("Интерфейсы")]
        public string Interfaces { get; set; }
        [DisplayName("Тип памяти ОЗУ")]
        public RAMtype RAMtype { get; set; }

    }
}
