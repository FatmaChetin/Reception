using Project.BLL.Repository.ConcRep;
using Project.MVCUI.Areas.Admin.Data.AdminPageVMs.AdminListPageVMs;
using Project.MVCUI.Areas.Admin.Data.AdminPureVMs;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        ReservationRepository _resRep;
       
        public ReservationController()
        {
            _resRep = new ReservationRepository();
           
        }
        
       //adminin sadece reservationı Listeleme yapabilmesini istedim

        public ActionResult ListReservations(int? id)
        {
            
            List<AdminReservationVM> reservations;
            if (id == null) 
            {
                reservations = _resRep.Select(x => new AdminReservationVM
                {
                    ID = x.ID,
                    ReservationTime = x.ReservationTime,
                    CheckIn = x.CheckIn,
                    CheckOut = x.CheckOut,
                    GuestCount = x.GuestCount,
                    CreatedDate = x.CreatedDate,
                    DeletedDate = x.DeletedDate,
                    UpdatedDate = x.UpdatedDate,
                   

                }).ToList();
               
            }
            else 
            {
                reservations = _resRep.Select(x => new AdminReservationVM
                {
                    ID = x.ID,
                    ReservationTime = x.ReservationTime,
                    CheckIn = x.CheckIn,
                    CheckOut = x.CheckOut,
                    GuestCount = x.GuestCount,
                    CreatedDate = x.CreatedDate,
                    DeletedDate = x.DeletedDate,
                    UpdatedDate = x.UpdatedDate,


                }).ToList();
            }
            AdminReservationListPageVM rpvm = new AdminReservationListPageVM
            { 
                Reservations= reservations,
            };
            return View(rpvm);
        }
    }
}