﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class AdminRoomVM
    {
        public int ID { get; set; }
        public string RoomNo { get; set; }
        public string RoomStatus { get; set; }
        public int? RoomTypeID { get; set; }
        public decimal RoomPricePerNight { get; set; }
        public string RoomTypeName { get; set; }// oda tipini controller panelinde daha rahat gösterebilmek için bu şekilde yapıldı.

    }
}
