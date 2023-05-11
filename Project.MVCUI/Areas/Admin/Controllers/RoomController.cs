using Project.BLL.Repository.ConcRep;
using Project.VM.PureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class RoomController : Controller
    {
        RoomRepository _rRep;
        RoomTypeRepository _rTypeRep;
        public RoomController()
        {
            _rRep = new RoomRepository();
            _rTypeRep = new RoomTypeRepository();
        }
        private List<AdminRoomTypeVM> GetRoomTypeVM()
        { 
            return _rTypeRep.Select(x=> new AdminRoomTypeVM
            { 
                ID = x.ID,
                TypeName = x.TypeName,
                Description = x.Description,
            
            }).ToList();

        }
        private List<AdminRoomVM> GetRoomVM() 
        { 
            return _rRep.Select(x=> new AdminRoomVM 
            { 
                ID=x.ID,
                RoomNo = x.RoomNo,
                RoomStatus=Convert.ToString(x.RoomStatus),
                RoomTypeID=x.RoomTypeID,

            }).ToList();
        }

    }
}