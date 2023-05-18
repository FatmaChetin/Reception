using Project.BLL.Repository.ConcRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class EmployeeProfileController : Controller
    {
        EmployeeProfileRepository _eProfRep;
        EmployeeRepository _eRep;
        public EmployeeProfileController()
        {
            _eProfRep = new EmployeeProfileRepository();
            _eRep = new EmployeeRepository();
        }

        public ActionResult DeleteEmployeeProfile(int id)
        {
            _eProfRep.Delete(_eProfRep.Find(id));
            return RedirectToAction("ListEmployeeProfiles");

        }
    }
}