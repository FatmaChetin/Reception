using Project.BLL.Repository.ConcRep;
using Project.COMMON.Tools;
using Project.ENTITIES.Enums;
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
    public class EmployeeController : Controller
    {
        EmployeeRepository _eRep;

        public EmployeeController()
        {

            _eRep = new EmployeeRepository();
        }
        public ActionResult ListEmployees(int? id)
        {
            List<AdminEmployeeVM> employees;
            if (id == null)
            {
                employees = _eRep.Select(X => new AdminEmployeeVM
                {
                    ID = X.ID,
                    UserName = X.UserName,
                    Password = X.Password,
                    CreatedDate = X.CreatedDate,
                    UpdatedDate = X.UpdatedDate,
                    DeletedDate = X.DeletedDate,
                    EmployeeRole=X.EmployeeRole.ToString(),

                }).ToList();
            }
            else
            {
                employees = _eRep.Select(X => new AdminEmployeeVM
                {
                    ID = X.ID,
                    UserName = X.UserName,
                    Password = X.Password,
                    CreatedDate = X.CreatedDate,
                    UpdatedDate = X.UpdatedDate,
                    DeletedDate = X.DeletedDate,
                    EmployeeRole= X.EmployeeRole.ToString(),
                    
                }).ToList();
            }
            AdminEmployeeListPageVM aepm = new AdminEmployeeListPageVM
            {
                Employees = employees
            };
            return View(aepm);


        }
        public ActionResult AddEmployee()
        { 
           return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(AdminEmployeeVM item) 
        {
            // if (Enum.TryParse(item.EmployeeRole, out EmployeeRole )) { }
            item.Password = DantexCrypt.Crypt(item.Password);// kullanıcı şifresi bu şekilde kriptoladık.
            Employee employee = new Employee
            { 
                ID=item.ID,
            UserName=item.UserName,
            Password=item.Password,
           
           // todo employeeRole burada nasıl verilebilir bir araştır. htmlden dropdownla mı yapsan.

            };
            _eRep.Add(employee);
            return RedirectToAction("ListEmployees");

        }
        public ActionResult UpdateEmployee(int id) 
        { 
            Employee selected=_eRep.Find(id);
            AdminAddUpdateEmployeePageVM epm = new AdminAddUpdateEmployeePageVM 
            {
                 Employee =new AdminEmployeeVM
                 { 
                 ID = selected.ID,
                 UserName=selected.UserName,
                 Password=selected.Password
                 }
            
            };
            return View(epm);

        }
        [HttpPost]
        public ActionResult UpdateEmployee(AdminEmployeeVM employee) 
        {
            Employee toBeUpdated=_eRep.Find(employee.ID);
            toBeUpdated.UserName= employee.UserName;
            toBeUpdated.Password= employee.Password;
            _eRep.Update(toBeUpdated);
            return RedirectToAction("ListEmployee");
        }
        public ActionResult DeleteEmployee(int id) 
        {
            _eRep.Delete(_eRep.Find(id));
            return RedirectToAction("ListEmployees");
        }
    }
}