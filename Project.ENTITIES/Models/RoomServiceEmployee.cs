using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomServiceEmployee:BaseEntity
    {
        public int RoomServiceID { get; set; }
        public int EmployeeID { get; set; }
        // relational properties
        public virtual RoomService RoomService { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
