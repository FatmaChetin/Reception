using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MVCUI.Areas.Admin.Data.AdminPureVMs
{
    public class AdminRoomTypeVM
    {
        public int ID { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public decimal PriceForType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }



    }
}
