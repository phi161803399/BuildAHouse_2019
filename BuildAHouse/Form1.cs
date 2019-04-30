using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAHouse
{
    public partial class Form1 : Form
    {
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room diningRoom;
        OutsideWithDoor backyard;
        OutsideWithDoor frontyard;
        Outside garden;
        public Form1()
        {
            InitializeComponent();
            CreateLocations();
        }

        public void CreateLocations()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen");
            diningRoom = new Room("Dining Room", "dining room decoration");
            backyard = new OutsideWithDoor("Backyard", false);
            frontyard = new OutsideWithDoor("Frontyard", false);
            garden = new Outside("Garden", true);

            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { livingRoom };
            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            frontyard.Exits = new Location[] { garden, backyard };
            backyard.Exits = new Location[] { garden, frontyard };
            garden.Exits = new Location[] { backyard, frontyard };

            kitchen.DoorLocation = backyard;
            backyard.DoorLocation = kitchen;
            livingRoom.DoorLocation = frontyard;
            frontyard.DoorLocation = livingRoom;
        }
    }
}
