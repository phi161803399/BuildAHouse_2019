﻿using System;
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
        OutsideWithDoor backYard;
        OutsideWithDoor frontYard;
        Outside garden;
        public Form1()
        {
            InitializeComponent();
            CreateLocations();
        }

        public void CreateLocations()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");
            diningRoom = new Room("Dining Room", "crystal chandelier");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            garden = new Outside("Garden", true);

            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { livingRoom };
            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            frontYard.Exits = new Location[] { garden, backYard };
            backYard.Exits = new Location[] { garden, frontYard };
            garden.Exits = new Location[] { backYard, frontYard };

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
        }
    }
}
