using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class GuestRoom:BaseEntity
    {
        public int GuestID { get; set; }
        public int RoomID { get; set; }

        //relational properties

        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
    }
}
