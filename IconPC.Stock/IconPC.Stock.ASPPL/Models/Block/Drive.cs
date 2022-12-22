using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("Накопитель")]
    public class Drive
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Тип")]
        public string Type { get; set; }
        [DisplayName("Объем (GB)")]
        public int Capacity { get; set; }
        [DisplayName("Скорость Записи (Mb/s)")]
        public int WriteSpeed { get; set; }
        [DisplayName("Скорость чтения (Mb/s)")]
        public int ReadSpeed { get; set; }
        [DisplayName("Ресурс TBW (TB)")]
        public int TBW { get; set; }

    }
}
