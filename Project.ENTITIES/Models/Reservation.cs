using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation:BaseEntity
    {
        public DateTime ReservationTime { get; set; }
        public DateTime CheckIn { get; set; }// giriş tarihi
        public DateTime CheckOut { get; set; }// çıkış tarihi
        public byte GuestCount { get; set; }// müşteri sayısı   
        public decimal RoomServicePrice { get; set; }
        public int? CustomerID { get; set; }
        public int? EmployeeID { get; set; }

        //relational properties
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<RoomReservation> RoomReservations { get; set; }

    }
}
