using Project.BLL.Repository.ConcRep;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.Admin.Data.AdminPageVMs.AdminListPageVMs;
using Project.VM.PureVMs;
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
            Employee employee = new Employee
            { 
            UserName=item.UserName,
            Password=item.Password,
            ID = item.ID,
           // EmployeeRole=item
            
            };

        
        }
    }
}