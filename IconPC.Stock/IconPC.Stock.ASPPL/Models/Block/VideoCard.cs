using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IconPC.Stock.ASPPL.Models
{
    [DisplayName("Видеокарта")]
    public class VideoCard
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Описание")]
        public string Desctription { get; set; }
        [DisplayName("Размер видеопамяти(GB)")]
        public int MemorySize { get; set; }
        [DisplayName("Разрядность шины(bit)")]
        public int BusWidth { get; set; }
        [DisplayName("Минимальный блок питания(W)")]
        public int MinimumPowerSupply { get; set; }
        [DisplayName("Длина видеокарты(мм)")]
        public int Length { get; set; }
        [DisplayName("Разьемы подключения")]
        public string Connector { get; set; }

    }
}
