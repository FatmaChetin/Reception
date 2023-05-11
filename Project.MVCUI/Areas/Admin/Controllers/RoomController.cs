using Microsoft.Ajax.Utilities;
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
            return _rTypeRep.Select(x => new AdminRoomTypeVM
            {
                ID = x.ID,
                TypeName = x.TypeName,
                Description = x.Description,

            }).ToList();

        }
        private List<AdminRoomVM> GetRoomVM()
        {
            return _rRep.Select(x => new AdminRoomVM
            {
                ID = x.ID,
                RoomNo = x.RoomNo,
                RoomStatus = Convert.ToString(x.RoomStatus),
                RoomTypeID = x.RoomTypeID,

            }).ToList();
        }
        public ActionResult ListRooms(int? id)
        {
            List<AdminRoomVM> rooms = GetRoomVM();
            AdminRoomListPageVM arpm = new AdminRoomListPageVM
            {
                Rooms = rooms,
            };
            _rRep.GetAll();
            return View(arpm);
        }
        public ActionResult AddRoom()
        { 
        List<AdminRoomTypeVM> roomTypes= GetRoomTypeVM();
            AdminAddUpdateRoomPageVM art = new AdminAddUpdateRoomPageVM 
            {
              RoomTypes=roomTypes,
            };
            return View(art);
        }
        [HttpPost]
        public ActionResult AddRoom(AdminRoomVM room) 
        {
            Room r = new Room
            {
                RoomNo = room.RoomNo,
                ID = room.ID,
                RoomStatus = ENTITIES.Enums.RoomStatus.IsOn,
                RoomTypeID = room.RoomTypeID,

            };
            _rRep.Add(r);
            return RedirectToAction("ListRooms");
        }
        public ActionResult UpdateRoom(int id) 
        { 
            List<AdminRoomTypeVM> roomTypes=GetRoomTypeVM();
            AdminAddUpdateRoomPageVM art = new AdminAddUpdateRoomPageVM 
            { 
              RoomTypes= roomTypes,
              Room=_rRep.Where(x=> x.ID==id).Select(x=> new AdminRoomVM 
              {
                  ID=x.ID,
                  RoomTypeID=x.RoomTypeID,
                  RoomNo=x.RoomNo,

              }).FirstOrDefault()
            };
            return View(art);
        
        }
        [HttpPost]
        public ActionResult UpdateRoom(AdminRoomVM room)
        {
            Room toBeUpdated = _rRep.Find(room.ID);
            toBeUpdated.RoomNo = room.RoomNo;
            toBeUpdated.RoomStatus = ENTITIES.Enums.RoomStatus.IsOn;
            toBeUpdated.RoomTypeID = room.RoomTypeID;
            _rRep.Update(toBeUpdated);
            return RedirectToAction("ListRooms");
        }
        public ActionResult DeleteRoom(int id)
        {
            _rRep.Delete(_rRep.Find(id));
            return RedirectToAction("ListRooms");
        }
    }
}