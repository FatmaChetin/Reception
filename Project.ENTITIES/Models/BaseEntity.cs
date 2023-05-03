using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DataStatus DataStatus { get; set; }
        public BaseEntity()
        {
            CreatedDate=DateTime.Now;
            DataStatus = DataStatus.Inserted;
           
        }
    }
}
