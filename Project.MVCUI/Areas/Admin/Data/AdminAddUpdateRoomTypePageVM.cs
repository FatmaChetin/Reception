using Project.VM.PureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.Admin.Data
{
    public class AdminAddUpdateRoomTypePageVM
    {
        public AdminRoomTypeVM RoomType { get; set; }
        public List<AdminRoomVM> Rooms { get; set; }
    }
}