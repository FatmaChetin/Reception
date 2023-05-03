using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomEmployee:BaseEntity
    {
        public int RoomID { get; set; }
        public int EmployeeID { get; set; }

        //relational properties
        public virtual Room Room { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
