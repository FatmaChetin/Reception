using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomService:BaseEntity
    {// odaya servis edilen ekstraları bu class içerisinde belirledik.

        public string Menu { get; set; }
        public string Beverage { get; set; }
        public decimal RoomServicePrice { get; set; }

        // relational properties
        public List<RoomServiceDetail> RoomServiceDetails { get; set; }
        public List<RoomServiceEmployee> RoomServiceEmployees { get; set; }
    }
}
