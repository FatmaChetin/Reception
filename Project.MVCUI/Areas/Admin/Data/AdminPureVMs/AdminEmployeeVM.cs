using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MVCUI.Areas.Admin.Data.AdminPureVMs
{
    public class AdminEmployeeVM
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmployeeRole { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
