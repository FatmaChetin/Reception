using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer:Guest
    {
        public decimal TotalPrice { get; set; }

        // relational properties

        public virtual List<Reservation> Reservations { get; set; }

    }
}
