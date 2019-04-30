using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAHouse
{
    class OutsideWithDoor: Outside, IHasExteriorDoor
    {
        // Doorlocation: Location where the door leads
        public Location DoorLocation { get; set; }
        // Doordescription
        public string DoorDescription { get; }

        public OutsideWithDoor(string name, bool hot, string doorDescription):
            base(name, hot)
        {
            DoorDescription = doorDescription;
        }
    }
}
