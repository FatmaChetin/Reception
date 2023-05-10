using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room:BaseEntity
    {
        public string RoomNo { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public int? RoomTypeID { get; set; }



        //Relational properties
        public virtual List<RoomReservation> RoomReservations { get; set; }
        public virtual List<RoomEmployee> RoomEmployees { get; set; }
        public virtual List<GuestRoom> GuestRooms { get; set; }
        public virtual List<RoomServiceDetail> RoomServiceRooms { get; set; }
        public virtual RoomType RoomType { get; set; }

    }
}
