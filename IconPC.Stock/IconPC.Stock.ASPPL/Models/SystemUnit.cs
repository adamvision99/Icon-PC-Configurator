using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("Системный блок")]
    public class SystemUnit
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Серия")]
        public string Series { get; set; }
        [DisplayName("Процессор")]
        public CPU CPU { get; set; }
        [DisplayName("Материнская плата")]
        public Motherboard Motherboard { get; set; }
        [DisplayName("ОЗУ")]
        public RAM RAM { get; set; }
        [DisplayName("Видеокарта")]
        public VideoCard VideoCard { get; set; }
        [DisplayName("Охлаждение")]
        public Cooling Cooling { get; set; }
        [DisplayName("Накопитель")]
        public Drive Drive { get; set; }
        [DisplayName("Блок питания")]
        public PowerUnit PowerUnit { get; set; }
        [DisplayName("Корпус")]
        public Case Case { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }

    }
}
