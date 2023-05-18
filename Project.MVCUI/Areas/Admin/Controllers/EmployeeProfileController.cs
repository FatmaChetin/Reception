using Project.BLL.Repository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.Admin.Data.AdminPageVMs.AdminAddUpdatePageVms;
using Project.MVCUI.Areas.Admin.Data.AdminPageVMs.AdminListPageVMs;
using Project.MVCUI.Areas.Admin.Data.AdminPureVMs;
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
        private List<AdminEmployeeVM> GetEmployeeVM()
        {
            return _eRep.Select(x => new AdminEmployeeVM
            {
            ID = x.ID,
            UserName = x.UserName,
            Password = x.Password,
            EmployeeRole=x.EmployeeRole.ToString()
            }).ToList();
        }
        private List<AdminEmployeeProfileVM> GetEmployeeProfVM()
        {
            return _eProfRep.Select(x=> new AdminEmployeeProfileVM 
            { 
            ID=x.Employee.ID,
            FirstName=x.FirstName,
            LastName=x.LastName,
            ContactNumber=x.ContactNumber,
            
            }).ToList();
        }
        public ActionResult ListEmployeeProfiles(int? id)
        {
            List<AdminEmployeeProfileVM> prof=GetEmployeeProfVM();
            AdminEmployeeProfileListPageVM eProf = new AdminEmployeeProfileListPageVM
            { 
                EmployeeProfiles = prof,
            
            };
            _eProfRep.GetAll();
            return View(eProf);
        }
        public ActionResult AddEmployeeProfile()
        { 
            List<AdminEmployeeVM> emp = GetEmployeeVM();
            AdminAddUpdateEmployeeProfilePageVM empProf = new AdminAddUpdateEmployeeProfilePageVM 
            {
                Employees= emp
            };
            return View(empProf);

        }// todo bire bir ilişkide nasıl olmalı onu öğren

        public ActionResult AddEmployeeProfile(AdminEmployeeProfileVM empProf)
        {
            EmployeeProfile eProf = new EmployeeProfile 
            {
                FirstName=empProf.FirstName,
                LastName=empProf.LastName,
                ContactNumber=empProf.ContactNumber
            
            };
            _eProfRep.Add(eProf);
            return RedirectToAction("ListEmployeeProfiles");

        }
        public ActionResult UpdateEmployeeProfile(int id)
        { 
         List<AdminEmployeeVM> emp=GetEmployeeVM();
            AdminAddUpdateEmployeeProfilePageVM eProf = new AdminAddUpdateEmployeeProfilePageVM
            {
                Employees = emp,
                EmployeeProfile = _eProfRep.Where(x => x.ID == x.Employee.ID).Select(x=> new AdminEmployeeProfileVM 
                {
                ID = x.Employee.ID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                ContactNumber=x.ContactNumber
                }).FirstOrDefault()
            };
            return View(eProf);
        }
        [HttpPost]
        public ActionResult UpdateEmployeeProfile(AdminEmployeeProfileVM profile) 
        {
            EmployeeProfile toBeUpdated = _eProfRep.Find(profile.ID);
            toBeUpdated.FirstName = profile.FirstName;
            toBeUpdated.LastName = profile.LastName;
            toBeUpdated.ContactNumber= profile.ContactNumber;
            _eProfRep.Add(toBeUpdated);
            return RedirectToAction("ListEmployeeProfiles");
        }

        public ActionResult DeleteEmployeeProfile(int id)
        {
            _eProfRep.Delete(_eProfRep.Find(id));
            return RedirectToAction("ListEmployeeProfiles");

        }
    }
}