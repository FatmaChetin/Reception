using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Guest:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string TrId { get; set; }
        public string Email { get; set; }
        public string RoomNo { get; set; }
        public string Address { get; set; }

        //relational properties

        public virtual List<GuestRoom> GuestRooms { get; set; }
    }
}
