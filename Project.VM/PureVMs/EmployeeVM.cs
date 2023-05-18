using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class EmployeeVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmployeeRole { get; set; }
      
        public List<RoomServiceVM> RoomServices { get; set; }
        public List<RoomVM> Rooms { get; set; }
    }
}
