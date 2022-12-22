using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("Блок питания")]
    public class PowerUnit
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Количество ватт(W)")]
        public int Watt { get; set; }
        [DisplayName("Сертификация 80 Plus")]
        public string Plus80 { get; set; }

    }
}
