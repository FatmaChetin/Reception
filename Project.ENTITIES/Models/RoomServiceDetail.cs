using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomServiceDetail:BaseEntity
    {
        public int RoomID { get; set; }
        public int RoomServiceID { get; set; }
        //relational properties
        public virtual Room Room { get; set; }
        public virtual RoomService RoomService { get; set; }
    }
}
