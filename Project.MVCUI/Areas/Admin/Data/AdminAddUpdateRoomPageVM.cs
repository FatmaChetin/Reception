using Project.VM.PureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.Admin.Data
{
    public class AdminAddUpdateRoomPageVM
    {
        public AdminRoomVM Room { get; set; }
        public List<AdminRoomTypeVM> RoomTypes { get; set; }
    }
}