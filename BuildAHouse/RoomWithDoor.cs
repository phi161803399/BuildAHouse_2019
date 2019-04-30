using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAHouse
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescription
        { get; }

        public Location DoorLocation
        { get; set; }

        public RoomWithDoor(string name, string decoration, string description):
            base(name, decoration)
        {
            DoorDescription = description;
        }
    }
}
