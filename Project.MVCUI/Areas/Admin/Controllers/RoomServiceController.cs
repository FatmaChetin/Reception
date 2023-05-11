using Project.BLL.Repository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.Admin.Data;
using Project.VM.PureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class RoomServiceController : Controller
    {
        RoomServiceRepository _rSerRep;
        public RoomServiceController()
        {
            _rSerRep = new RoomServiceRepository();
        }
        public ActionResult ListRoomServices(int id)
        {
            List<AdminRoomServiceVM> roomService;
            if (id == null)
            {
                roomService=_rSerRep.Select(x=> new AdminRoomServiceVM 
                { 
                    ID= x.ID,
                    Menu= x.Menu,
                    Beverage= x.Beverage,
                    Price=x.RoomServicePrice
                }).ToList();
            }
            else 
            {
                roomService=_rSerRep.Select(x=> new AdminRoomServiceVM
                {
                    ID = x.ID,
                    Menu = x.Menu,
                    Beverage = x.Beverage,
                    Price = x.RoomServicePrice

                }).ToList();
            }
            AdminRoomServiceListPageVM arc = new AdminRoomServiceListPageVM
            { 
                RoomServices= roomService,
            };
            return View(roomService);
        }
        public ActionResult AddRoomService()
        { 
         return View(); 
        }
        [HttpPost]
        public ActionResult AddRoomService(AdminRoomServiceVM item)
        {
            RoomService rs = new RoomService 
            {
                ID=item.ID,
                Menu= item.Menu,
                Beverage= item.Beverage,
                RoomServicePrice=item.Price
            };
            _rSerRep.Add(rs);
            return View("ListRoomServices");
        }
        public ActionResult UpdateRoomService(int id)
        {
            RoomService selected = _rSerRep.Find(id);
            AdminAddUpdateRoomServicePageVM ars = new AdminAddUpdateRoomServicePageVM 
            { 
                RoomService=new AdminRoomServiceVM
                { 
                    ID=selected.ID,
                    Menu= selected.Menu,
                    Beverage= selected.Beverage,
                    Price= selected.RoomServicePrice
                }
            };
            return View(ars);
        }
        [HttpPost]
        public ActionResult UpdateRoomService(AdminRoomServiceVM roomService)
        { 
            RoomService toBeUpdated=_rSerRep.Find(roomService.ID);
            toBeUpdated.Menu= roomService.Menu;
            toBeUpdated.Beverage= roomService.Beverage;
            toBeUpdated.RoomServicePrice = roomService.Price;
            _rSerRep.Add(toBeUpdated);
            return RedirectToAction("ListRoomServices");
        
        }
        public ActionResult DeleteRoomService(int id) 
        {
            _rSerRep.Delete(_rSerRep.Find(id));
            return RedirectToAction("ListRoomServices");
        }
    }
}