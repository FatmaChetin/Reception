using Project.MVCUI.Areas.Admin.Data.AdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.Admin.Data.AdminPageVMs.AdminAddUpdatePageVms
{
    public class AdminAddUpdateEmployeeProfilePageVM
    {
        public AdminEmployeeProfileVM EmployeeProfile { get; set; }
        public AdminEmployeeVM Employee { get; set; }
    }
}