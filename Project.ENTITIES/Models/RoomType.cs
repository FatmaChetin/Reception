using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomType:BaseEntity
    {//todo oda tipi ayrı bir class olarak belirtildi ki özellikler eklenmek istenildiği zaman coplex bir yapıya rahatlıkla çevrilebilmesi için
        public string TypeName { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; }

        //Relational properties

        public virtual List<Room> Rooms { get; set; }

    }
}
