using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{//todo:  roomtype classını sonradan oluşturduk. bu yüzden map, bll, dal katmanlarını roomtypela ilgili yapılması gereken herşeyi sırayla eklemelisin.
       public class RoomType:BaseEntity
    { 
        public string TypeName { get; set; } 
        public decimal PricePerNight { get; set; }
        public string Description { get; set; }

        //Relational properties

        public virtual List<Room> Rooms { get; set; }

    }
}
