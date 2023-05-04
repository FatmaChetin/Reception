using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Init
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            // kullanıcıya database oluştuğunda görevli bir admin , bir resepsiyonist, odalar ve oda tipleri hazır olarak teslim etmek istediğimiz için bu şekilde yaptık.
            #region Admin
            Employee emp=new Employee();
            emp.UserName = "Fatma";
            emp.Password = "1234";
            emp.EmployeeRole = ENTITIES.Enums.EmployeeRole.Admin;
            context.Employees.Add(emp);
            context.SaveChanges();

            #endregion


            #region Receptionist
            Employee emp2 = new Employee();
            emp2.UserName = "Burak";
            emp2.Password = "0101";
            emp2.EmployeeRole= ENTITIES.Enums.EmployeeRole.Receptionist;
            context.Employees.Add(emp2);
            context.SaveChanges();
            #endregion

            #region Rooms
            Room r1 = new Room();
            r1.RoomNo = "101";
            r1.RoomType = ENTITIES.Enums.RoomType.Standart;


            #endregion

        }
    }
}
