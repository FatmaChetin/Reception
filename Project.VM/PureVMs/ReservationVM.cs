using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class ReservationVM
    {
        public DateTime ReservationTime { get; set; }
        public DateTime CheckIn { get; set; }// giriş tarihi
        public DateTime CheckOut { get; set; }// çıkış tarihi
        public byte GuestCount { get; set; }// müşteri sayısı   
        public decimal RoomServicePrice { get; set; }
        public int? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
    }
}
