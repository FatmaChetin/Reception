using Project.BLL.Repository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.Admin.Data.AdminPageVMs.AdminAddUpdatePageVms;
using Project.MVCUI.Areas.Admin.Data.AdminPageVMs.AdminListPageVMs;
using Project.MVCUI.Areas.Admin.Data.AdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class RoomTypeController : Controller
    {
        RoomTypeRepository _rTypeRep;
       
    
        public RoomTypeController()
        {
            _rTypeRep = new RoomTypeRepository();
        }
        public ActionResult ListRoomTypes(int? id)
        {
            List<AdminRoomTypeVM> roomTypes;
            if (id == null)
            {
                roomTypes = _rTypeRep.Select(x => new AdminRoomTypeVM
                {

                    ID = x.ID,
                    TypeName = x.TypeName,
                    Description = x.Description,
                    PriceForType = x.PriceForType,
                    DeletedDate=x.DeletedDate,
                    CreatedDate=x.CreatedDate,
                    UpdatedDate=x.UpdatedDate

                }).ToList();
            }
            else
            {
                roomTypes = _rTypeRep.Select(x => new AdminRoomTypeVM
                {
                    ID = x.ID,
                    TypeName = x.TypeName,
                    Description = x.Description,
                    PriceForType = x.PriceForType,
                    DeletedDate = x.DeletedDate,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate
                }).ToList();
            }
            AdminRoomTypeListPageVM aR = new AdminRoomTypeListPageVM
            {
                RoomTypes = roomTypes,

            };
            return View(aR);
           
        }
        public ActionResult AddRoomType()
        { 
             return View();
        }
        [HttpPost]
        public ActionResult AddRoomType(AdminRoomTypeVM item) 
        {
            RoomType rT = new RoomType 
            { 
            TypeName = item.TypeName,
            Description = item.Description,
            PriceForType= item.PriceForType,
            ID= item.ID
            };
            _rTypeRep.Add(rT);
            return RedirectToAction("ListRoomTypes");
        }
        public ActionResult UpdateRoomType(int id)
        {
            RoomType selected = _rTypeRep.Find(id);

            AdminAddUpdateRoomTypePageVM auRT = new AdminAddUpdateRoomTypePageVM
            {
                RoomType = new AdminRoomTypeVM

                {
                    ID= selected.ID,
                    TypeName = selected.TypeName,
                    Description = selected.Description,
                    PriceForType= selected.PriceForType,
                   
                }

            };
            return View(auRT);
        }
        [HttpPost]
        public ActionResult UpdateRoomType(AdminRoomTypeVM roomType)
        { 
        RoomType toBeUpdated=_rTypeRep.Find(roomType.ID);
            toBeUpdated.TypeName = roomType.TypeName;
            toBeUpdated.Description = roomType.Description;
            toBeUpdated.PriceForType = roomType.PriceForType;
           
            
            _rTypeRep.Update(toBeUpdated);
            return RedirectToAction("ListRoomTypes");
        
        }
        public ActionResult DeleteRoomType(int id)
        {
            _rTypeRep.Delete(_rTypeRep.Find(id));
            return RedirectToAction("ListRoomTypes");
        }

    }
}