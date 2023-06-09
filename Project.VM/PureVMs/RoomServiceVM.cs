﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class RoomServiceVM
    {
        public string Menu { get; set; }
        public string Beverage { get; set; }
        public decimal RoomServicePrice { get; set; }
        public List<ReservationVM> Reservations { get; set; }
        public List<RoomVM> Rooms { get; set; }
        public List<EmployeeVM> Employees { get; set; }

    }
}
