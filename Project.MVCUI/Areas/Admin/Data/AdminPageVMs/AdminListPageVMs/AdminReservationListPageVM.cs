using Project.MVCUI.Areas.Admin.Data.AdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.Admin.Data.AdminPageVMs.AdminListPageVMs
{
    public class AdminReservationListPageVM
    {
        public List<AdminReservationVM> Reservations { get; set; }
    }
}