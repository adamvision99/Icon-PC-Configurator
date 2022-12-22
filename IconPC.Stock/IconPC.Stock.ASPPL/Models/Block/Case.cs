using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("Корпус")]
    public class Case
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Тип корпуса")]
        public string Type { get; set; }
        [DisplayName("Макс.высота кулера(мм)")]
        public int MaximumCoolerHeight { get; set; }
        [DisplayName("Макс.длина видеокарты(мм)")]
        public int MaximumVideoCardLength { get; set; }
        [DisplayName("Крепление СВО")]
        public string WaterCoolingMount { get; set; }
        [DisplayName("Цвет")]
        public string Color { get; set; }
        [DisplayName("Кол-во встроенных вентиляторов")]
        public int FansNumber { get; set; }
    }
}
