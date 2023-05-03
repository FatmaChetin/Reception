using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomReservation:BaseEntity
    {
        public int RoomID { get; set; }
        public int ReservationID { get; set; }

        //relational properties

        public virtual Room Room { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
