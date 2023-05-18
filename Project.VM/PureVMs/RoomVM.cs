using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class RoomVM
    {

        public string RoomNo { get; set; }
        public string RoomStatus { get; set; }
        public int? RoomTypeID { get; set; }
        public List<ReservationVM> Reservations { get; set; }
        public List<RoomServiceVM> RoomServices { get; set; }
        public List<EmployeeVM> Employees { get; set; }
    }
}
