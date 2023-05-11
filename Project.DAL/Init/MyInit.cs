using Bogus.DataSets;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using Project.MAP.Options;
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
           
// kullanıcıya database oluştuğunda görevli bir admin , bir resepsiyonist, odalar ve oda tipleri , room service bogustan sahte veri çektik hazır olarak teslim etmek istediğimiz için bu şekilde yaptık.

            #region Admin
            Employee emp=new Employee();
            emp.UserName = "Fatma";
            emp.Password = "1234";
            emp.EmployeeRole = ENTITIES.Enums.EmployeeRole.Admin;
            context.Employees.Add(emp);
            context.SaveChanges();

            #endregion
            #region RoomType
            RoomType rt=new RoomType();
            rt.TypeName = "StandartRoom";
            context.RoomTypes.Add(rt);
            context.SaveChanges();
           
            RoomType rt2= new RoomType();
            rt2.TypeName = "SuitRoom";
            context.RoomTypes.Add(rt2);
            context.SaveChanges();

            RoomType rt3 = new RoomType();
            rt3.TypeName = "KingRoom";
            context.RoomTypes.Add(rt3);
            context.SaveChanges();

//odadan önce 3 farklı oda tiplerini yarattık. odaları ekledğimizde oda tipleride mevcut olsun diye. context.classadı.add dememizin nedeni yaratmış oluğumuz instance bilgilerini istediğimiz classa eklemek ardından da savechanges yaparak kaydetmek. ekleme yapmadan değişiklikleri kaydedemezsin unutma!

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
            for (int i = 101 ; i < 111; i++)
            {
                Room room = new Room();
                room.RoomType.ID = 1;//id üzerinden yakaladık ki daha sonra herhangi bir problem olmasın diye. literal değer girmek daha sonrasında değişiklik yaptığında adminin değerlerin değişmesini engeleyeceği için bu şekilde düzelttik.
                context.Rooms.Add(room);
                
            }
            context.SaveChanges();
            for (int i = 201 ; i < 211; i++)
            {
                Room room2 = new Room();
                room2.RoomType.ID = 2;
                context.Rooms.Add(room2);
               
            }
            context.SaveChanges();
            for (int i = 301; i <304; i++)
            {
                Room room3 = new Room();
                room3.RoomType.ID = 3;
                context.Rooms.Add(room3);
            }
            context.SaveChanges();
            #endregion
            #region RoomService
          
 // roomservice için bogus indirelim çünkü test etmek için kullanacağız gerçek bir menü oluşturmayı veya içicek bilgilerini admine ekletirebiliriz, Adminin Roomservice crud işlemlerinde!!
            for (int i = 0; i < 10; i++)
            {
                RoomService r = new RoomService();
                r.Menu = new Commerce("tr").ProductName();
                r.Beverage = new Commerce("tr").ProductName();
                r.RoomServicePrice = Convert.ToInt32(new Commerce("tr").Price());
                context.RoomServices.Add(r);
            }
            context.SaveChanges();
            #endregion

        }
    }
}
