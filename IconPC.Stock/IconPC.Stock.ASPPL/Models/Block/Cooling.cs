using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("Охлаждение")]
    public class Cooling
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Тип охлаждения")]
        public string Type { get; set; }
        [DisplayName("Количество отводимого тепла (W)")]
        public int HeatAmount { get; set; }
        [DisplayName("Комментарий")]
        public string Comment { get; set; }
        [DisplayName("Цвет")]
        public string Color { get; set; }
    }
}
