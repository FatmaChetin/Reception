using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class GuestRoomMap : BaseMap<GuestRoom>
    {
        public GuestRoomMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            { 
                x.RoomID, 
                x.GuestID 
            
            });
        }
    }
}
