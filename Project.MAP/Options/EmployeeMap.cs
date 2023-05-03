using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class EmployeeMap:BaseMap<Employee>
    {
        public EmployeeMap()
        {
            HasOptional(x => x.EmployeeProfile).WithRequired(x => x.Employee);
        }
    }
}
