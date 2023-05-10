using Project.DAL.Init;
using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
 // Init klasöründe kullandığımız MyInit classı bize database hazırlanırken gereken bilgileri program çalıştığı anlada sqle de eklemek için kullandık. daha sonra sqle elle veri girmemek için. bundan dolayı hazırladığımız MyInit classını MyContext classı ctor içerisinde yazmamız gerekiyor.setinitializer olarak unutma bundan dolayı böyle yaptık. MyContext classımız bize sql tablolarını oluşturur girdiğimiz bilgilerde bu tablolarla eklenecek bundan dolayı!!!!
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeProfileMap());
            modelBuilder.Configurations.Add(new GuestMap());
            modelBuilder.Configurations.Add(new GuestRoomMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new RoomEmployeeMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new RoomReservationMap());
            modelBuilder.Configurations.Add(new RoomServiceMap());
            modelBuilder.Configurations.Add(new RoomServiceEmployeeMap());
            modelBuilder.Configurations.Add(new RoomServiceDetailMap());
            modelBuilder.Configurations.Add(new RoomTypeMap());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestRoom> GuestRooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoomEmployee> RoomEmployees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<RoomService> RoomServices { get; set; }
        public DbSet<RoomServiceEmployee> RoomServiceEmployees { get; set; }
        public DbSet<RoomServiceDetail> RoomServiceDetails { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<RoomType> RoomTypes { get; set;}
        
    }
}
