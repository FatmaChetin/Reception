using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Employee:BaseEntity
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public EmployeeRole EmployeeRole { get; set; }
       
        // relational properties
        public virtual EmployeeProfile EmployeeProfile { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<RoomEmployee> RoomEmployees { get; set; }
        public virtual List<RoomServiceEmployee> RoomServiceEmployees { get; set; }
    }
}
